using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_cellSimulatorV1._1.CellClasses
{
    public class CellUserAL:CellLookupMolicel
    {
        static public CellBaseClass tableFindByVoltage(float voltage, SystemStatus_e systemStatus)
        {
            CellBaseClass cellTable = new CellBaseClass();

            if((systemStatus == SystemStatus_e.SYSTEM_IDLE) || (systemStatus == SystemStatus_e.SYSTEM_CHARGING))
            {
                if(voltage >= molicelChargeTable[0].voltage)
                {
                    cellTable = molicelChargeTable[0];
                }
                else if (voltage <= molicelChargeTable[lookupTableLen - 1].voltage)
                {
                    cellTable = molicelChargeTable[lookupTableLen - 1];
                }
                else
                {
                    for(int i = 0; i < (lookupTableLen - 1); i++)
                    {
                        if(voltage >= molicelChargeTable[i].voltage)
                        {
                            cellTable = Interpolation(molicelChargeTable[i], molicelChargeTable[i + 1]);
                            break;
                        }
                    }
                }
            }
            else
            {
                if (voltage >= moliceDischargeTable[0].voltage)
                {
                    cellTable = moliceDischargeTable[0];
                }
                else if (voltage <= moliceDischargeTable[lookupTableLen - 1].voltage)
                {
                    cellTable = moliceDischargeTable[lookupTableLen - 1];
                }
                else
                {
                    for (int i = 0; i < (lookupTableLen - 1); i++)
                    {
                        if (voltage >= moliceDischargeTable[i].voltage)
                        {
                            cellTable = Interpolation(moliceDischargeTable[i], moliceDischargeTable[i + 1]);
                            break;
                        }
                    }
                }
            }

            return cellTable;
        }

        static private CellBaseClass Interpolation(CellBaseClass index1, CellBaseClass index2)
        {
            CellBaseClass interpolatedIndex = new CellBaseClass();

            float slope = index1.voltage / index2.voltage;

            interpolatedIndex.voltage = slope * index1.voltage;
            interpolatedIndex.capacity = slope * index2.capacity;

            return interpolatedIndex;
        }
    }
}
