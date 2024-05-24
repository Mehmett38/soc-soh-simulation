﻿using _001_cellSimulatorV1._1.CellClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_cellSimulatorV1._1
{
    public class CellLookupMolicel : CellBaseClass
    {
        static public int lookupTableLen;
        static public float minVoltage;
        static public float maxVoltage;
        static public float cellCapacity;

        public CellLookupMolicel()
        {
            lookupTableLen = molicelChargeTable.Count;
            minVoltage = moliceDischargeTable[lookupTableLen - 1].voltage;
            maxVoltage = molicelChargeTable[0].voltage;
            cellCapacity = molicelChargeTable[0].capacity;
        }

        public static List<CellBaseClass> molicelChargeTable = new List<CellBaseClass>()
        {
            new CellBaseClass {voltage = 4.1803f, capacity = 4500},
            new CellBaseClass {voltage = 4.1781f, capacity = 4455},
            new CellBaseClass {voltage = 4.1737f, capacity = 4410},
            new CellBaseClass {voltage = 4.1675f, capacity = 4365},
            new CellBaseClass {voltage = 4.1598f, capacity = 4320},
            new CellBaseClass {voltage = 4.1509f, capacity = 4275},
            new CellBaseClass {voltage = 4.1411f, capacity = 4230},
            new CellBaseClass {voltage = 4.1305f, capacity = 4185},
            new CellBaseClass {voltage = 4.1194f, capacity = 4140},
            new CellBaseClass {voltage = 4.108f, capacity = 4095},
            new CellBaseClass {voltage = 4.0964f, capacity = 4050},
            new CellBaseClass {voltage = 4.0847f, capacity = 4005},
            new CellBaseClass {voltage = 4.0731f, capacity = 3960},
            new CellBaseClass {voltage = 4.0616f, capacity = 3915},
            new CellBaseClass {voltage = 4.0504f, capacity = 3870},
            new CellBaseClass {voltage = 4.0394f, capacity = 3825},
            new CellBaseClass {voltage = 4.0287f, capacity = 3780},
            new CellBaseClass {voltage = 4.0185f, capacity = 3735},
            new CellBaseClass {voltage = 4.0085f, capacity = 3690},
            new CellBaseClass {voltage = 3.999f, capacity = 3645},
            new CellBaseClass {voltage = 3.9898f, capacity = 3600},
            new CellBaseClass {voltage = 3.981f, capacity = 3555},
            new CellBaseClass {voltage = 3.9726f, capacity = 3510},
            new CellBaseClass {voltage = 3.9644f, capacity = 3465},
            new CellBaseClass {voltage = 3.9566f, capacity = 3420},
            new CellBaseClass {voltage = 3.949f, capacity = 3375},
            new CellBaseClass {voltage = 3.9416f, capacity = 3330},
            new CellBaseClass {voltage = 3.9344f, capacity = 3285},
            new CellBaseClass {voltage = 3.9274f, capacity = 3240},
            new CellBaseClass {voltage = 3.9204f, capacity = 3195},
            new CellBaseClass {voltage = 3.9135f, capacity = 3150},
            new CellBaseClass {voltage = 3.9066f, capacity = 3105},
            new CellBaseClass {voltage = 3.8996f, capacity = 3060},
            new CellBaseClass {voltage = 3.8926f, capacity = 3015},
            new CellBaseClass {voltage = 3.8854f, capacity = 2970},
            new CellBaseClass {voltage = 3.8781f, capacity = 2925},
            new CellBaseClass {voltage = 3.8707f, capacity = 2880},
            new CellBaseClass {voltage = 3.863f, capacity = 2835},
            new CellBaseClass {voltage = 3.8551f, capacity = 2790},
            new CellBaseClass {voltage = 3.8469f, capacity = 2745},
            new CellBaseClass {voltage = 3.8384f, capacity = 2700},
            new CellBaseClass {voltage = 3.8297f, capacity = 2655},
            new CellBaseClass {voltage = 3.8207f, capacity = 2610},
            new CellBaseClass {voltage = 3.8114f, capacity = 2565},
            new CellBaseClass {voltage = 3.8017f, capacity = 2520},
            new CellBaseClass {voltage = 3.7918f, capacity = 2475},
            new CellBaseClass {voltage = 3.7817f, capacity = 2430},
            new CellBaseClass {voltage = 3.7713f, capacity = 2385},
            new CellBaseClass {voltage = 3.7606f, capacity = 2340},
            new CellBaseClass {voltage = 3.7497f, capacity = 2295},
            new CellBaseClass {voltage = 3.7387f, capacity = 2250},
            new CellBaseClass {voltage = 3.7275f, capacity = 2205},
            new CellBaseClass {voltage = 3.7162f, capacity = 2160},
            new CellBaseClass {voltage = 3.7049f, capacity = 2115},
            new CellBaseClass {voltage = 3.6935f, capacity = 2070},
            new CellBaseClass {voltage = 3.6821f, capacity = 2025},
            new CellBaseClass {voltage = 3.6709f, capacity = 1980},
            new CellBaseClass {voltage = 3.6597f, capacity = 1935},
            new CellBaseClass {voltage = 3.6487f, capacity = 1890},
            new CellBaseClass {voltage = 3.6379f, capacity = 1845},
            new CellBaseClass {voltage = 3.6274f, capacity = 1800},
            new CellBaseClass {voltage = 3.6171f, capacity = 1755},
            new CellBaseClass {voltage = 3.6073f, capacity = 1710},
            new CellBaseClass {voltage = 3.5978f, capacity = 1665},
            new CellBaseClass {voltage = 3.5887f, capacity = 1620},
            new CellBaseClass {voltage = 3.5801f, capacity = 1575},
            new CellBaseClass {voltage = 3.572f, capacity = 1530},
            new CellBaseClass {voltage = 3.5643f, capacity = 1485},
            new CellBaseClass {voltage = 3.5572f, capacity = 1440},
            new CellBaseClass {voltage = 3.5505f, capacity = 1395},
            new CellBaseClass {voltage = 3.5443f, capacity = 1350},
            new CellBaseClass {voltage = 3.5386f, capacity = 1305},
            new CellBaseClass {voltage = 3.5333f, capacity = 1260},
            new CellBaseClass {voltage = 3.5284f, capacity = 1215},
            new CellBaseClass {voltage = 3.5238f, capacity = 1170},
            new CellBaseClass {voltage = 3.5194f, capacity = 1125},
            new CellBaseClass {voltage = 3.5151f, capacity = 1080},
            new CellBaseClass {voltage = 3.5107f, capacity = 1035},
            new CellBaseClass {voltage = 3.5062f, capacity = 990},
            new CellBaseClass {voltage = 3.5013f, capacity = 945},
            new CellBaseClass {voltage = 3.4959f, capacity = 900},
            new CellBaseClass {voltage = 3.4897f, capacity = 855},
            new CellBaseClass {voltage = 3.4825f, capacity = 810},
            new CellBaseClass {voltage = 3.4739f, capacity = 765},
            new CellBaseClass {voltage = 3.4637f, capacity = 720},
            new CellBaseClass {voltage = 3.4515f, capacity = 675},
            new CellBaseClass {voltage = 3.4369f, capacity = 630},
            new CellBaseClass {voltage = 3.4195f, capacity = 585},
            new CellBaseClass {voltage = 3.3989f, capacity = 540},
            new CellBaseClass {voltage = 3.3744f, capacity = 495},
            new CellBaseClass {voltage = 3.3455f, capacity = 450},
            new CellBaseClass {voltage = 3.3117f, capacity = 405},
            new CellBaseClass {voltage = 3.2722f, capacity = 360},
            new CellBaseClass {voltage = 3.2264f, capacity = 315},
            new CellBaseClass {voltage = 3.1735f, capacity = 270},
            new CellBaseClass {voltage = 3.1127f, capacity = 225},
            new CellBaseClass {voltage = 3.0431f, capacity = 180},
            new CellBaseClass {voltage = 2.9637f, capacity = 135},
            new CellBaseClass {voltage = 2.8736f, capacity = 90},
            new CellBaseClass {voltage = 2.7716f, capacity = 45},
            new CellBaseClass {voltage = 2.6567f, capacity = 0},
        };


        public static List<CellBaseClass> moliceDischargeTable = new List<CellBaseClass>()
        {
            new CellBaseClass {voltage = 4.1609f, capacity = 4500},
            new CellBaseClass {voltage = 4.1556f, capacity = 4455},
            new CellBaseClass {voltage = 4.1493f, capacity = 4410},
            new CellBaseClass {voltage = 4.142f, capacity = 4365},
            new CellBaseClass {voltage = 4.1339f, capacity = 4320},
            new CellBaseClass {voltage = 4.1252f, capacity = 4275},
            new CellBaseClass {voltage = 4.116f, capacity = 4230},
            new CellBaseClass {voltage = 4.1064f, capacity = 4185},
            new CellBaseClass {voltage = 4.0965f, capacity = 4140},
            new CellBaseClass {voltage = 4.0864f, capacity = 4095},
            new CellBaseClass {voltage = 4.0761f, capacity = 4050},
            new CellBaseClass {voltage = 4.0658f, capacity = 4005},
            new CellBaseClass {voltage = 4.0554f, capacity = 3960},
            new CellBaseClass {voltage = 4.0451f, capacity = 3915},
            new CellBaseClass {voltage = 4.0348f, capacity = 3870},
            new CellBaseClass {voltage = 4.0247f, capacity = 3825},
            new CellBaseClass {voltage = 4.0146f, capacity = 3780},
            new CellBaseClass {voltage = 4.0047f, capacity = 3735},
            new CellBaseClass {voltage = 3.995f, capacity = 3690},
            new CellBaseClass {voltage = 3.9853f, capacity = 3645},
            new CellBaseClass {voltage = 3.9759f, capacity = 3600},
            new CellBaseClass {voltage = 3.9666f, capacity = 3555},
            new CellBaseClass {voltage = 3.9574f, capacity = 3510},
            new CellBaseClass {voltage = 3.9484f, capacity = 3465},
            new CellBaseClass {voltage = 3.9395f, capacity = 3420},
            new CellBaseClass {voltage = 3.9307f, capacity = 3375},
            new CellBaseClass {voltage = 3.922f, capacity = 3330},
            new CellBaseClass {voltage = 3.9134f, capacity = 3285},
            new CellBaseClass {voltage = 3.9049f, capacity = 3240},
            new CellBaseClass {voltage = 3.8964f, capacity = 3195},
            new CellBaseClass {voltage = 3.8879f, capacity = 3150},
            new CellBaseClass {voltage = 3.8794f, capacity = 3105},
            new CellBaseClass {voltage = 3.8709f, capacity = 3060},
            new CellBaseClass {voltage = 3.8624f, capacity = 3015},
            new CellBaseClass {voltage = 3.8538f, capacity = 2970},
            new CellBaseClass {voltage = 3.8452f, capacity = 2925},
            new CellBaseClass {voltage = 3.8365f, capacity = 2880},
            new CellBaseClass {voltage = 3.8277f, capacity = 2835},
            new CellBaseClass {voltage = 3.8187f, capacity = 2790},
            new CellBaseClass {voltage = 3.8097f, capacity = 2745},
            new CellBaseClass {voltage = 3.8005f, capacity = 2700},
            new CellBaseClass {voltage = 3.7912f, capacity = 2655},
            new CellBaseClass {voltage = 3.7817f, capacity = 2610},
            new CellBaseClass {voltage = 3.7721f, capacity = 2565},
            new CellBaseClass {voltage = 3.7623f, capacity = 2520},
            new CellBaseClass {voltage = 3.7524f, capacity = 2475},
            new CellBaseClass {voltage = 3.7424f, capacity = 2430},
            new CellBaseClass {voltage = 3.7321f, capacity = 2385},
            new CellBaseClass {voltage = 3.7218f, capacity = 2340},
            new CellBaseClass {voltage = 3.7113f, capacity = 2295},
            new CellBaseClass {voltage = 3.7007f, capacity = 2250},
            new CellBaseClass {voltage = 3.6899f, capacity = 2205},
            new CellBaseClass {voltage = 3.6791f, capacity = 2160},
            new CellBaseClass {voltage = 3.6681f, capacity = 2115},
            new CellBaseClass {voltage = 3.6571f, capacity = 2070},
            new CellBaseClass {voltage = 3.646f, capacity = 2025},
            new CellBaseClass {voltage = 3.6348f, capacity = 1980},
            new CellBaseClass {voltage = 3.6235f, capacity = 1935},
            new CellBaseClass {voltage = 3.6123f, capacity = 1890},
            new CellBaseClass {voltage = 3.6009f, capacity = 1845},
            new CellBaseClass {voltage = 3.5896f, capacity = 1800},
            new CellBaseClass {voltage = 3.5783f, capacity = 1755},
            new CellBaseClass {voltage = 3.5669f, capacity = 1710},
            new CellBaseClass {voltage = 3.5555f, capacity = 1665},
            new CellBaseClass {voltage = 3.5442f, capacity = 1620},
            new CellBaseClass {voltage = 3.5328f, capacity = 1575},
            new CellBaseClass {voltage = 3.5214f, capacity = 1530},
            new CellBaseClass {voltage = 3.51f, capacity = 1485},
            new CellBaseClass {voltage = 3.4986f, capacity = 1440},
            new CellBaseClass {voltage = 3.4871f, capacity = 1395},
            new CellBaseClass {voltage = 3.4756f, capacity = 1350},
            new CellBaseClass {voltage = 3.4639f, capacity = 1305},
            new CellBaseClass {voltage = 3.452f, capacity = 1260},
            new CellBaseClass {voltage = 3.44f, capacity = 1215},
            new CellBaseClass {voltage = 3.4277f, capacity = 1170},
            new CellBaseClass {voltage = 3.4151f, capacity = 1125},
            new CellBaseClass {voltage = 3.4021f, capacity = 1080},
            new CellBaseClass {voltage = 3.3886f, capacity = 1035},
            new CellBaseClass {voltage = 3.3746f, capacity = 990},
            new CellBaseClass {voltage = 3.3598f, capacity = 945},
            new CellBaseClass {voltage = 3.3443f, capacity = 900},
            new CellBaseClass {voltage = 3.3278f, capacity = 855},
            new CellBaseClass {voltage = 3.3102f, capacity = 810},
            new CellBaseClass {voltage = 3.2913f, capacity = 765},
            new CellBaseClass {voltage = 3.2711f, capacity = 720},
            new CellBaseClass {voltage = 3.2491f, capacity = 675},
            new CellBaseClass {voltage = 3.2254f, capacity = 630},
            new CellBaseClass {voltage = 3.1995f, capacity = 585},
            new CellBaseClass {voltage = 3.1713f, capacity = 540},
            new CellBaseClass {voltage = 3.1405f, capacity = 495},
            new CellBaseClass {voltage = 3.1067f, capacity = 450},
            new CellBaseClass {voltage = 3.0697f, capacity = 405},
            new CellBaseClass {voltage = 3.0291f, capacity = 360},
            new CellBaseClass {voltage = 2.9846f, capacity = 315},
            new CellBaseClass {voltage = 2.9357f, capacity = 270},
            new CellBaseClass {voltage = 2.882f, capacity = 225},
            new CellBaseClass {voltage = 2.823f, capacity = 180},
            new CellBaseClass {voltage = 2.7583f, capacity = 135},
            new CellBaseClass {voltage = 2.6874f, capacity = 90},
            new CellBaseClass {voltage = 2.6097f, capacity = 45},
            new CellBaseClass {voltage = 2.5246f, capacity = 0},
        };

    }
}
