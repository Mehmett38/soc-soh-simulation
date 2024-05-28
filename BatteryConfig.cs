using _001_cellSimulatorV1._1.CellClasses;
using _001_cellSimulatorV1._1.Simulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_cellSimulatorV1._1
{
    public partial class BatteryConfig : Form
    {
        static public BatterySoxInf battery = new BatterySoxInf();
        

        public BatteryConfig(BatterySoxInf batSox)
        {
            InitializeComponent();

            if(batSox.voltage == 0)
            {
                textBoxVoltage.Text = "3.5";
                textBoxSoh.Text = "100";
                textBoxWidtdrawnCurrent.Text = "50000";
            }
            else
            {
                textBoxDownDod.Text = batSox.downDodRatio.ToString();
                textBoxUpDod.Text = batSox.upDodRatio.ToString();
                textBoxSoh.Text = batSox.soh.ToString();
                textBoxVoltage.Text = batSox.voltage.ToString();
                textBoxWidtdrawnCurrent.Text = batSox.maxWidtdrawnCurrent.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            battery.downDodRatio = int.Parse(textBoxDownDod.Text);
            battery.upDodRatio = int.Parse(textBoxUpDod.Text);
            battery.soh = float.Parse(textBoxSoh.Text);
            battery.voltage = float.Parse(textBoxVoltage.Text);
            battery.maxWidtdrawnCurrent = int.Parse(textBoxWidtdrawnCurrent.Text);

            chechCellLimits();

            this.Close();
        }

        private void chechCellLimits()
        {
            //reset up and down dod value
            battery.downDodCapacity = 0;
            battery.upDodCapacity = 0;

            //take the cell total capacity
            battery.totalcapacity = CellUserAL.cellCapacity;                            //!< system total capacity
            battery.dodCapacity = battery.totalcapacity * ((100 - battery.downDodRatio -  battery.upDodRatio) / 100.0f);
            battery.netCapacity = battery.dodCapacity * (battery.soh / 100.0f);                    //!< system SOH capacity

            //calculate min and max capacity according to SOH and dod capacity
            float downDodCapacity = battery.totalcapacity * (battery.soh / 100.0f) * (battery.downDodRatio / 100.0f);
            float upDodCapacity = battery.totalcapacity * (battery.soh / 100.0f) * ((100.0f - battery.upDodRatio) / 100.0f);

            float downDodVoltage = CellUserAL.tableFindByCapacity(downDodCapacity, battery, CellBaseClass.SystemStatus_e.SYSTEM_DISCHAGING).voltage;
            float upDodVoltage = CellUserAL.tableFindByCapacity(upDodCapacity, battery, CellBaseClass.SystemStatus_e.SYSTEM_CHARGING).voltage;

            //set the system down and up dod capacity values !!!NOTE change the order of this function line-60 is needed 
            battery.downDodCapacity = downDodCapacity;
            battery.upDodCapacity = upDodCapacity;

            battery.minVoltage = (float)downDodVoltage;
            battery.maxVoltage = (float)upDodVoltage;

            if (battery.voltage <= downDodVoltage)
            {
                battery.voltage = downDodVoltage;
            }
            else if(battery.voltage >= upDodVoltage)
            {
                battery.voltage = upDodVoltage;
            }

            //find the intantaneous capacity according to voltage, soh and dod
            CellBaseClass cellDatas = CellUserAL.tableFindByVoltage(battery, CellBaseClass.SystemStatus_e.SYSTEM_DISCHAGING);

            battery.batInstantaneousCapacity = (cellDatas.capacity < 0.001f) ? 0 : cellDatas.capacity;
         }

        public BatterySoxInf getBattery()
        {
            return battery;
        }
    }
}
