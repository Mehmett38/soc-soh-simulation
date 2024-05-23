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
            float downDodVoltage = CellUserAL.minVoltage * ((float)battery.downDodRatio + 100.0f) / 100.0f;
            float upDodVoltage = CellUserAL.maxVoltage * (100.0f -  (float)battery.upDodRatio) / 100.0f;

            battery.minVoltage = (float)downDodVoltage;
            battery.maxVoltage = (float)upDodVoltage;

            if (battery.voltage < downDodVoltage)
            {
                battery.voltage = downDodVoltage;
            }
            else if(battery.voltage > upDodVoltage)
            {
                battery.voltage = upDodVoltage;
            }

            float dod = (100.0f - battery.downDodRatio - battery.upDodRatio) / 100.0f;

            battery.totalcapacity = CellUserAL.capacity;
            battery.dodCapacity = battery.totalcapacity * dod;

            CellBaseClass cellDatas = CellUserAL.tableFindByVoltage(battery.voltage, CellBaseClass.SystemStatus_e.SYSTEM_IDLE);

            battery.batInstantaneousCapacity = cellDatas.capacity * dod * (battery.soh / 100.0f);

        }

        public BatterySoxInf getBattery()
        {
            return battery;
        }
    }
}
