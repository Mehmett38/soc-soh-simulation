using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_cellSimulatorV1._1.CellClasses
{
    public class CellBaseClass
    {

        public enum SystemStatus_e
        {
            SYSTEM_IDLE,
            SYSTEM_CHARGING,
            SYSTEM_DISCHAGING
        }

        public float voltage { get; set;}
        public float capacity { get; set;}
    }
}
