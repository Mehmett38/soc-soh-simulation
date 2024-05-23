using _001_cellSimulatorV1._1.CellClasses;
using _001_cellSimulatorV1._1.formSizeClasses;
using _001_cellSimulatorV1._1.SerialPortOperation;
using _001_cellSimulatorV1._1.Simulation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_cellSimulatorV1._1
{
    public partial class Form1 : Form
    {
        PortProcess serialPortOperations;
        CellUserAL cell = new CellUserAL();
        BatterySoxInf batSox;
        CellSimulate cellSimulater;
        public Form1()
        {
            InitializeComponent();

            //give the serial port related object and container
            serialPortOperations = new PortProcess(comboBoxPortName.Name, comboBoxBaudRate.Name,
                                                   comboBoxParity.Name  , comboBoxStopBit.Name,
                                                   comboBoxDataBits.Name, buttonConnect.Name,
                                                   buttonDisconnect.Name, groupBoxSerialCom);

            timerUpdateUart.Start();
            cell = new CellUserAL();
            batSox = new BatterySoxInf();
            cellSimulater = new CellSimulate(progressBarSOC.Name, pictureBoxProgVoltage.Name, labelSOC.Name, labelVolt.Name);
        }

        private void serialPortButtonClick(object sender, EventArgs e)
        {
            if(sender == buttonConnect)
            {
                serialPortOperations.portConnect(groupBoxSerialCom, serialPortTI);
            }
            else if(sender == buttonDisconnect)
            {
                serialPortOperations.portDisconnet(groupBoxSerialCom, serialPortTI);
            }
        }

        private void timerUpdateUart_Tick(object sender, EventArgs e)
        {
            serialPortOperations.chechSerialPortConnection(groupBoxSerialCom, serialPortTI);
        }

        private void formSizeIconClick(object sender, EventArgs e)
        {
            if(sender == pictureBoxCloseForm)
            {
                FormSizeOperation.formCloseClick(this);
            }
            else if(sender == pictureBoxResizeForm)
            {
                FormSizeOperation.formResizeClick(this);
            }
            else if(sender == pictureBoxMinimizeForm)
            {
                FormSizeOperation.formMinimize(this);
            }
        }
        private void mauseHoverEvent(object sender, EventArgs e)
        {
            if (sender == pictureBoxCloseForm)
            {
                pictureBoxCloseForm.BackColor = Color.Red;
            }
            else if (sender == pictureBoxResizeForm)
            {
                pictureBoxResizeForm.BackColor = Color.Blue;
            }
            else if (sender == pictureBoxMinimizeForm)
            {
                pictureBoxMinimizeForm.BackColor = Color.Green;
            }
        }

        private void mauseLeaveEvent(object sender, EventArgs e)
        {
            if (sender == pictureBoxCloseForm)
            {
                pictureBoxCloseForm.BackColor = Color.Black;
            }
            else if (sender == pictureBoxResizeForm)
            {
                pictureBoxResizeForm.BackColor = Color.Black;
            }
            else if (sender == pictureBoxMinimizeForm)
            {
                pictureBoxMinimizeForm.BackColor = Color.Black;
            }
        }

        private void cellSimulationMauseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void pictureBoxBattery_Click(object sender, EventArgs e)
        {
            BatteryConfig batCfg = new BatteryConfig(batSox);
            batCfg.ShowDialog();

            batSox = batCfg.getBattery();
            cellSimulater.batConfigProgressBar(groupBoxBattery, batSox);
        }

        private void pictureBoxStart_Click(object sender, EventArgs e)
        {

        }
    }
}
