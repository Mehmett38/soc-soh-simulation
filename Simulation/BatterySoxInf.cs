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
        public float soh { get; set; }
        public float sox { get; set; }
        public float voltage { get; set; }
        public float minVoltage { get; set; }
        public float maxVoltage { get; set; }
        public int downDodRatio { get; set; }                   //between 0-100
        public int upDodRatio { get; set; }                     //between 0-100
        public float dodRatio{ get; set; }                      //betweeb 0-1
        public float downDodCapacity { get; set; }
        public float upDodCapacity { get; set; }
        public float totalcapacity { get; set; }
        public float netCapacity { get; set; }
        public float dodCapacity { get; set; }
        public float batInstantaneousCapacity { get; set; }
        public int parallelCellNumber { get; set; }
        public int maxWidtdrawnCurrent { get; set; }
    }
}
