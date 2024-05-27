using _001_cellSimulatorV1._1.CellClasses;
using _001_cellSimulatorV1._1.SerialPortOperation;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _001_cellSimulatorV1._1.Simulation
{
    public class CellSimulate
    {
        Thread chargeThread;
        Thread dischargeThread;
        Thread idleThread;

        string progSocName;
        string pctBoxVoltageName;
        string labelSocName;
        string labelVoltName;
        string chartvoltCapacityName;

        private BatterySoxInf batSox;
        private SerialPort port;
        private Control groBoxSimulation;
        private ThredStatus thredStatus = ThredStatus.THREADS_STOP;

        public CellSimulate(string progSocName, string pctBoxVoltageName, string labelSocName, string labelVoltName, string chartvoltCapacityName)
        {
            this.progSocName = progSocName;
            this.pctBoxVoltageName = pctBoxVoltageName;
            this.labelSocName = labelSocName;
            this.labelVoltName = labelVoltName;
            this.chartvoltCapacityName = chartvoltCapacityName;
        }

        public void batConfigProgressBar(Control control, BatterySoxInf batInf)
        {
            ((PictureBox)control.Controls[pctBoxVoltageName]).Height = 150 - (int)(batInf.voltage / batInf.maxVoltage * 150.0f);
            ((ProgressBar)control.Controls[progSocName]).Maximum = (int)batInf.dodCapacity;
            ((ProgressBar)control.Controls[progSocName]).Minimum = 0;

            ((ProgressBar)control.Controls[progSocName]).Value = (int)batInf.batInstantaneousCapacity;

            ((Label)control.Controls[labelSocName]).Text = $"SOC : { (batInf.batInstantaneousCapacity / batInf.dodCapacity) * 100.0f}";
            ((Label)control.Controls[labelVoltName]).Text = "V : " + (batInf.voltage).ToString() + " / " + (batInf.maxVoltage).ToString();
        }

        public void startSimulation(BatterySoxInf batSox, SerialPort port, Control groBoxSimulation, RadioButton radioBtnCharge)
        {
            if (!((thredStatus == ThredStatus.IDLE_THREAD_RUNNING) || (thredStatus == ThredStatus.THREADS_STOP)))
                return;

            //stop the idle thread
            if(thredStatus == ThredStatus.IDLE_THREAD_RUNNING)
                idleThread.Abort();

            if ((batSox.voltage != 0) && (PortProcess.serialPortStatus == SerialPortConnection_e.PORT_CONNECTED))
            {
                this.batSox = batSox;
                this.port = port;
                this.groBoxSimulation = groBoxSimulation;

                if (radioBtnCharge.Checked)
                {
                    try
                    {
                        thredStatus = ThredStatus.CHARGE_THREAD_RUNNING;
                        chargeThread = new Thread(chargeThreadFunc);
                        resetChart();
                        chargeThread.Start();
                    }
                    catch (Exception ex)
                    {
                        thredStatus = ThredStatus.THREADS_STOP;
                        MessageBox.Show("Thread Çalıştırılamadı", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        thredStatus = ThredStatus.DISCHARGE_THREAD_RUNNING;
                        dischargeThread = new Thread(dischargeThreadFunc);
                        resetChart();
                        dischargeThread.Start();
                    }
                    catch (Exception ex)
                    {
                        thredStatus = ThredStatus.THREADS_STOP;
                        MessageBox.Show("Thread Çalıştırılamadı", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Öncelikle Pil Konfigürasyonlarını Yapın ve Bağlantının Açık Olduğundan Emin Olun", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void stopSimulation(BatterySoxInf batSox, SerialPort port, Control groBoxSimulation)
        {
            this.batSox = batSox;
            this.port = port;
            this.groBoxSimulation = groBoxSimulation;

            if (thredStatus == ThredStatus.DISCHARGE_THREAD_RUNNING)
            {
                dischargeThread.Abort();
                thredStatus = ThredStatus.IDLE_THREAD_RUNNING;
                idleThread = new Thread(idleThreadFunc);
                idleThread.Start();
            }
            else if(thredStatus == ThredStatus.CHARGE_THREAD_RUNNING)
            {
                chargeThread.Abort();
                thredStatus = ThredStatus.IDLE_THREAD_RUNNING;
                idleThread = new Thread(idleThreadFunc);
                idleThread.Start();
            }
        }

        private void chargeThreadFunc()
        {
            ProgressBar socProg = (ProgressBar)groBoxSimulation.Controls[progSocName];
            Chart chartVoltCapacity = (Chart)groBoxSimulation.Controls[chartvoltCapacityName];
            Label socLabel = (Label)groBoxSimulation.Controls[labelSocName];
            Label voltLabel = (Label)groBoxSimulation.Controls[labelVoltName];
            PictureBox voltagePicture = (PictureBox)groBoxSimulation.Controls[pctBoxVoltageName];
            DateTime dateTime = new System.DateTime(1999, 1, 13, 3, 57, 32, 11);
            int milisecond1;
            int milisecond2;
            int delay;
            Random rnd = new Random();

            if(thredStatus != ThredStatus.CHARGE_THREAD_RUNNING)
            resetChart();

            while (true)
            {
                dateTime = DateTime.Now;
                milisecond1 = dateTime.Millisecond;

                float instantCurrent = rnd.Next(0, batSox.maxWidtdrawnCurrent) / 72000.0f;   //72000 = 60 * 60 * 2 , 50ms
                batSox.batInstantaneousCapacity += instantCurrent;
                batSox.batInstantaneousCapacity = (batSox.batInstantaneousCapacity > batSox.dodCapacity) 
                                                  ? batSox.dodCapacity : batSox.batInstantaneousCapacity;

                batSox.voltage = CellUserAL.tableFindByCapacity(batSox.batInstantaneousCapacity, CellBaseClass.SystemStatus_e.SYSTEM_CHARGING).voltage;

                voltagePicture.Invoke(new Action(() =>
                {
                    voltagePicture.Height = 150 - (int)(batSox.voltage / batSox.maxVoltage * 150.0f);
                }));

                chartVoltCapacity.Invoke(new Action(() =>
                {
                    chartVoltCapacity.Series[0].Points.AddXY(batSox.batInstantaneousCapacity, batSox.voltage);
                }));

                socProg.Invoke(new Action(() =>
                {
                    socProg.Value = ((int)batSox.batInstantaneousCapacity >= batSox.dodCapacity) 
                                    ? (int)batSox.dodCapacity : (int)batSox.batInstantaneousCapacity;
                }));

                socLabel.Invoke(new Action(() =>
                {
                    socLabel.Text = $"SOC : {(batSox.batInstantaneousCapacity / batSox.dodCapacity * 100.0f)}";
                }));

                voltLabel.Invoke(new Action(() =>
                {
                    voltLabel.Text = $"V : {(batSox.voltage)}/{(batSox.maxVoltage)}";
                }));


                currentTransmit(instantCurrent, batSox.voltage, port, 1);

                dateTime = DateTime.Now;
                milisecond2 = dateTime.Millisecond;

                if (milisecond2 > milisecond1)
                {
                    delay = 50 - (milisecond2 - milisecond1);
                }
                else
                {
                    delay = 50 - (1000 - milisecond1 + milisecond1);
                }

                delay = (delay > 50) ? 1 : delay;
                delay = (delay < 0) ? 1 : delay;

                Thread.Sleep(delay);

                if(batSox.voltage == batSox.maxVoltage)
                    break;
            }

            MessageBox.Show("Charge Completed");

            thredStatus = ThredStatus.IDLE_THREAD_RUNNING;
            idleThread = new Thread(idleThreadFunc);
            idleThread.Start(); 
        }

        private void idleThreadFunc()
        {
            ProgressBar socProg = (ProgressBar)groBoxSimulation.Controls[progSocName];
            Chart chartVoltCapacity = (Chart)groBoxSimulation.Controls[chartvoltCapacityName];
            Label socLabel = (Label)groBoxSimulation.Controls[labelSocName];
            Label voltLabel = (Label)groBoxSimulation.Controls[labelVoltName];
            PictureBox voltagePicture = (PictureBox)groBoxSimulation.Controls[pctBoxVoltageName];
            DateTime dateTime = new System.DateTime(1999, 1, 13, 3, 57, 32, 11);
            int milisecond1;
            int milisecond2;
            int delay;
            Random rnd = new Random();

            while (true)
            {
                dateTime = DateTime.Now;
                milisecond1 = dateTime.Millisecond;

                batSox.voltage = CellUserAL.tableFindByCapacity(batSox.batInstantaneousCapacity, CellBaseClass.SystemStatus_e.SYSTEM_IDLE).voltage;

                voltagePicture.Invoke(new Action(() =>
                {
                    voltagePicture.Height = 150 - (int)(batSox.voltage / batSox.maxVoltage * 150.0f);
                }));

                chartVoltCapacity.Invoke(new Action(() =>
                {
                    chartVoltCapacity.Series[0].Points.AddXY(batSox.batInstantaneousCapacity, batSox.voltage);
                }));

                socProg.Invoke(new Action(() =>
                {
                    socProg.Value = ((int)batSox.batInstantaneousCapacity >= batSox.dodCapacity)
                                    ? (int)batSox.dodCapacity : (int)batSox.batInstantaneousCapacity;
                }));

                socLabel.Invoke(new Action(() =>
                {
                    socLabel.Text = $"SOC : {(batSox.batInstantaneousCapacity / batSox.dodCapacity * 100.0f)}";
                }));

                voltLabel.Invoke(new Action(() =>
                {
                    voltLabel.Text = $"V : {(batSox.voltage)}/{(batSox.maxVoltage)}";
                }));

                currentTransmit(0, batSox.voltage, port, 0);

                dateTime = DateTime.Now;
                milisecond2 = dateTime.Millisecond;

                if (milisecond2 > milisecond1)
                {
                    delay = 50 - (milisecond2 - milisecond1);
                }
                else
                {
                    delay = 50 - (1000 - milisecond1 + milisecond1);
                }

                delay = (delay > 50) ? 1 : delay;
                delay = (delay < 0) ? 1 : delay;

                Thread.Sleep(delay);
            }
        }

        private void dischargeThreadFunc()
        {
            ProgressBar socProg = (ProgressBar)groBoxSimulation.Controls[progSocName];
            Chart chartVoltCapacity = (Chart)groBoxSimulation.Controls[chartvoltCapacityName];
            Label socLabel = (Label)groBoxSimulation.Controls[labelSocName];
            Label voltLabel = (Label)groBoxSimulation.Controls[labelVoltName];
            PictureBox voltagePicture = (PictureBox)groBoxSimulation.Controls[pctBoxVoltageName];
            DateTime dateTime = new System.DateTime(1999, 1, 13, 3, 57, 32, 11);
            int milisecond1;
            int milisecond2;
            int delay;
            Random rnd = new Random();

            if (thredStatus != ThredStatus.DISCHARGE_THREAD_RUNNING)
                resetChart();

            while (true)
            {
                dateTime = DateTime.Now;
                milisecond1 = dateTime.Millisecond;

                float instantCurrent = rnd.Next(0, batSox.maxWidtdrawnCurrent) / 72000.0f;   //72000 = 60 * 60 * 2 , 50ms
                batSox.batInstantaneousCapacity -= instantCurrent;
                batSox.batInstantaneousCapacity = (batSox.batInstantaneousCapacity < 0)
                                                  ? 0 : batSox.batInstantaneousCapacity;

                batSox.voltage = CellUserAL.tableFindByCapacity(batSox.batInstantaneousCapacity, CellBaseClass.SystemStatus_e.SYSTEM_DISCHAGING).voltage;

                voltagePicture.Invoke(new Action(() =>
                {
                    voltagePicture.Height = 150 - (int)(batSox.voltage / batSox.maxVoltage * 150.0f);
                }));

                chartVoltCapacity.Invoke(new Action(() =>
                {
                    chartVoltCapacity.Series[0].Points.AddXY(batSox.batInstantaneousCapacity, batSox.voltage);
                }));

                socProg.Invoke(new Action(() =>
                {
                    socProg.Value = ((int)batSox.batInstantaneousCapacity >= batSox.dodCapacity)
                                    ? (int)batSox.dodCapacity : (int)batSox.batInstantaneousCapacity;
                }));

                socLabel.Invoke(new Action(() =>
                {
                    socLabel.Text = $"SOC : {(batSox.batInstantaneousCapacity / batSox.dodCapacity * 100.0f)}";
                }));

                voltLabel.Invoke(new Action(() =>
                {
                    voltLabel.Text = $"V : {(batSox.voltage)}/{(batSox.maxVoltage)}";
                }));


                currentTransmit(instantCurrent, batSox.voltage, port, -1);

                dateTime = DateTime.Now;
                milisecond2 = dateTime.Millisecond;

                if (milisecond2 > milisecond1)
                {
                    delay = 50 - (milisecond2 - milisecond1);
                }
                else
                {
                    delay = 50 - (1000 - milisecond1 + milisecond1);
                }

                delay = (delay > 50) ? 1 : delay;
                delay = (delay < 0) ? 1 : delay;

                Thread.Sleep(delay);

                if (batSox.voltage == batSox.minVoltage)
                    break;
            }

            MessageBox.Show("Discharge Completed");
            thredStatus = ThredStatus.IDLE_THREAD_RUNNING;
            idleThread = new Thread(idleThreadFunc);
            idleThread.Start();
        }

        private void resetChart()
        {
            Chart chartVoltCapacity = (Chart)groBoxSimulation.Controls[chartvoltCapacityName];

            //set the chart boundaries
            chartVoltCapacity.Invoke(new Action(() =>
            {
                chartVoltCapacity.Series[0].Points.Clear();
                chartVoltCapacity.ChartAreas[0].AxisX.Minimum = 0;
                chartVoltCapacity.ChartAreas[0].AxisX.Maximum = (int)batSox.dodCapacity;//Math.Round((batInf.currentNum + batInf.maxCurrent / 3500.0f), 3);

                chartVoltCapacity.ChartAreas[0].AxisY.Minimum = (int)batSox.minVoltage;
                chartVoltCapacity.ChartAreas[0].AxisY.Maximum = (int)batSox.maxVoltage + 1;//Math.Round((batInf.currentNum + batInf.maxCurrent / 3500.0f), 3);
            }));
        }

        private void currentTransmit(float current, float voltage, SerialPort port, int chargeDischarge)
        {
            current *= chargeDischarge;
            int intValue = BitConverter.ToInt32(BitConverter.GetBytes(current), 0);

            //Array.Reverse(curretHex);

            byte[] txCurrent = new byte[10];
            byte[] floatToHex = new byte[4];

            floatToHex = BitConverter.GetBytes(intValue);

            txCurrent[0] = (byte)floatToHex[3];
            txCurrent[1] = (byte)floatToHex[2];
            txCurrent[2] = (byte)floatToHex[1];
            txCurrent[3] = (byte)floatToHex[0];

            intValue = BitConverter.ToInt32(BitConverter.GetBytes(voltage), 0);
            floatToHex = BitConverter.GetBytes(intValue);

            txCurrent[4] = (byte)floatToHex[3];
            txCurrent[5] = (byte)floatToHex[2];
            txCurrent[6] = (byte)floatToHex[1];
            txCurrent[7] = (byte)floatToHex[0];
            txCurrent[8] = (byte)'\r';
            txCurrent[9] = (byte)'\n';

            port.Write(txCurrent, 0, txCurrent.Length);
        }
    }
}
