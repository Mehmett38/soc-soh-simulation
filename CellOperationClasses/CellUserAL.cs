﻿using _001_cellSimulatorV1._1.Simulation;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace _001_cellSimulatorV1._1.CellClasses
{
    public class CellUserAL:CellLookupMolicel
    {
        private enum InterpolationSource_e
        {
            INTERPOLATE_BY_CAPACITY,
            INTERPOLATE_BY_VOLTAGE
        }

        public static CellBaseClass tableFindByVoltage(BatterySoxInf bat, SystemStatus_e systemStatus)
        {
            CellBaseClass cellTable = new CellBaseClass();

            if(systemStatus == SystemStatus_e.SYSTEM_CHARGING)
            {
                if(bat.voltage >= molicelChargeTable[0].voltage)
                {
                    cellTable = molicelChargeTable[0];
                }
                else if (bat.voltage <= molicelChargeTable[lookupTableLen - 1].voltage)
                {
                    cellTable = molicelChargeTable[lookupTableLen - 1];
                }
                else
                {
                    for(int i = 0; i < lookupTableLen; i++)
                    {
                        if(bat.voltage >= molicelChargeTable[i].voltage)
                        {
                            cellTable = Interpolation(molicelChargeTable[i], molicelChargeTable[i - 1], bat.voltage, InterpolationSource_e.INTERPOLATE_BY_VOLTAGE);
                            break;
                        }
                    }
                }
            }
            else if(systemStatus == SystemStatus_e.SYSTEM_DISCHAGING)
            {
                if (bat.voltage >= moliceDischargeTable[0].voltage)
                {
                    cellTable = moliceDischargeTable[0];
                }
                else if (bat.voltage <= moliceDischargeTable[lookupTableLen - 1].voltage)
                {
                    cellTable = moliceDischargeTable[lookupTableLen - 1];
                }
                else
                {
                    for (int i = 0; i < lookupTableLen; i++)
                    {
                        if (bat.voltage >= moliceDischargeTable[i].voltage)
                        {
                            cellTable = Interpolation(moliceDischargeTable[i], moliceDischargeTable[i - 1], bat.voltage, InterpolationSource_e.INTERPOLATE_BY_VOLTAGE);
                            break;
                        }
                    }
                }
            }
            else
            {
                if (bat.voltage >= molicelIdleTable[0].voltage)
                {
                    cellTable = molicelIdleTable[0];
                }
                else if (bat.voltage <= molicelIdleTable[lookupTableLen - 1].voltage)
                {
                    cellTable = molicelIdleTable[lookupTableLen - 1];
                }
                else
                {
                    for (int i = 0; i < lookupTableLen; i++)
                    {
                        if (bat.voltage >= molicelIdleTable[i].voltage)
                        {
                            cellTable = Interpolation(molicelIdleTable[i], molicelIdleTable[i - 1], bat.voltage, InterpolationSource_e.INTERPOLATE_BY_VOLTAGE);
                            break;
                        }
                    }
                }
            }

            float interpolatedCapacity = cellTable.capacity * bat.parallelCellNumber * (bat.soh / 100.0f) - bat.downDodCapacity;
            interpolatedCapacity = (interpolatedCapacity < 0) ? 0 : interpolatedCapacity;
            interpolatedCapacity = (interpolatedCapacity > bat.netCapacity) ? bat.netCapacity : interpolatedCapacity;

            return new CellBaseClass()
            {
                capacity = interpolatedCapacity,
            }; 
        }

        public static CellBaseClass tableFindByCapacity(float capacity, BatterySoxInf bat, SystemStatus_e systemStatus)
        {
            CellBaseClass cellTable = new CellBaseClass();

            capacity /= bat.parallelCellNumber;

            capacity += (bat.downDodCapacity / bat.parallelCellNumber);
            capacity = capacity * (100.0f / bat.soh);

            if (systemStatus == SystemStatus_e.SYSTEM_CHARGING)
            {
                if (capacity >= molicelChargeTable[0].capacity)
                {
                    cellTable = molicelChargeTable[0];
                }
                else if (capacity <= molicelChargeTable[lookupTableLen - 1].capacity)
                {
                    cellTable = molicelChargeTable[lookupTableLen - 1];
                }
                else
                {
                    for (int i = 0; i < lookupTableLen; i++)
                    {
                        if (capacity >= molicelChargeTable[i].capacity)
                        {
                            cellTable = Interpolation(molicelChargeTable[i], molicelChargeTable[i - 1], capacity, InterpolationSource_e.INTERPOLATE_BY_CAPACITY);
                            break;
                        }
                    }
                }
            }
            else if(systemStatus == SystemStatus_e.SYSTEM_DISCHAGING)
            {
                if (capacity >= moliceDischargeTable[0].capacity)
                {
                    cellTable = moliceDischargeTable[0];
                }
                else if (capacity <= moliceDischargeTable[lookupTableLen - 1].capacity)
                {
                    cellTable = moliceDischargeTable[lookupTableLen - 1];
                }
                else
                {
                    for (int i = 0; i < lookupTableLen; i++)
                    {
                        if (capacity >= moliceDischargeTable[i].capacity)
                        {
                            cellTable = Interpolation(moliceDischargeTable[i], moliceDischargeTable[i - 1], capacity, InterpolationSource_e.INTERPOLATE_BY_CAPACITY);
                            break;
                        }
                    }
                }
            }
            else
            {
                if (capacity >= molicelIdleTable[0].capacity)
                {
                    cellTable = molicelIdleTable[0];
                }
                else if (capacity <= molicelIdleTable[lookupTableLen - 1].capacity)
                {
                    cellTable = molicelIdleTable[lookupTableLen - 1];
                }
                else
                {
                    for (int i = 0; i < lookupTableLen; i++)
                    {
                        if (capacity >= molicelIdleTable[i].capacity)
                        {
                            cellTable = Interpolation(molicelIdleTable[i], molicelIdleTable[i - 1], capacity, InterpolationSource_e.INTERPOLATE_BY_CAPACITY);
                            break;
                        }
                    }
                }
            }

            return cellTable;
        }

        static private CellBaseClass Interpolation(CellBaseClass index1, CellBaseClass index2, float readVal, InterpolationSource_e interpolateSource)
        {
            CellBaseClass interpolatedIndex = new CellBaseClass
            {
                capacity = index1.capacity,
                voltage = index1.voltage
            };

            float slope = 0.0f;
            float offset = 0.0f;

            if(interpolateSource == InterpolationSource_e.INTERPOLATE_BY_CAPACITY)
            {
                slope = (index2.voltage -  index1.voltage) / (index2.capacity - index1.capacity);
                offset = index1.voltage - (index1.capacity * slope);

                float voltage = readVal * slope + offset;       // ax + b 
                
                if(voltage < minVoltage)
                {
                    interpolatedIndex.voltage = minVoltage;
                }
                else if(voltage < maxVoltage)
                {
                    interpolatedIndex.voltage = voltage;
                }
                else
                {
                    interpolatedIndex.voltage = maxVoltage;
                }
            }
            else
            {
                slope = (index2.capacity - index1.capacity) / (index2.voltage - index1.voltage);
                offset = index1.capacity - (index1.voltage * slope);

                float capacity = readVal * slope + offset;       // ax + b 

                if (capacity < 0)
                {
                    interpolatedIndex.capacity = 0;
                }
                else if (capacity < cellCapacity)
                {
                    interpolatedIndex.capacity = capacity;
                }
                else
                {
                    interpolatedIndex.capacity = cellCapacity;
                }
            }

            return interpolatedIndex;
        }
    }
}
