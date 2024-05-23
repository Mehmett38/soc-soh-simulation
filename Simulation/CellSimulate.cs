using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_cellSimulatorV1._1.Simulation
{
    public class CellSimulate
    {
        Thread chargeThread;
        Thread dischargeThread;

        string progSocName;
        string pctBoxVoltageName;
        string labelSocName;
        string labelVoltName;

        public CellSimulate(string progSocName, string pctBoxVoltageName, string labelSocName, string labelVoltName)
        {
            chargeThread = new Thread(chargeThreadFunc);
            dischargeThread = new Thread(dischargeThreadFunc);

            this.progSocName = progSocName;
            this.pctBoxVoltageName = pctBoxVoltageName;
            this.labelSocName = labelSocName;
            this.labelVoltName = labelVoltName;
        }

        public void batConfigProgressBar(Control control, BatterySoxInf batInf)
        {
            ((PictureBox)control.Controls[pctBoxVoltageName]).Height = 150 - (int)(batInf.voltage / batInf.maxVoltage * 150.0f);
            ((ProgressBar)control.Controls[progSocName]).Maximum = (int)batInf.dodCapacity;
            ((ProgressBar)control.Controls[progSocName]).Minimum = 0;

            ((ProgressBar)control.Controls[progSocName]).Value = (int)batInf.batInstantaneousCapacity;
            ((Label)control.Controls[labelSocName]).Text = "SOC : " + (batInf.batInstantaneousCapacity / batInf.dodCapacity * 100.0f).ToString();
            ((Label)control.Controls[labelVoltName]).Text = "V : " + (batInf.voltage).ToString() + "/" + (batInf.maxVoltage).ToString();
        }

        private void dischargeThreadFunc()
        {

        }

        private void chargeThreadFunc()
        {

        }
    }
}
