using _001_cellSimulatorV1._1.SerialPortOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_cellSimulatorV1._1.Simulation
{
    public class BatterySoxInf
    {
        public int downDodRatio { get; set; }
        public int upDodRatio { get; set; }
        public float soh { get; set; }
        public float sox { get; set; }
        public float voltage { get; set; }
        public float minVoltage { get; set; }
        public float maxVoltage { get; set; }
        public float totalcapacity { get; set; }
        public float dodCapacity { get; set; }
        public float batInstantaneousCapacity { get; set; }
        public int maxWidtdrawnCurrent { get; set; }
    }
}
