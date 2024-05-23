using _001_cellSimulatorV1._1.SerialPortOperation;
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
        public Form1()
        {
            InitializeComponent();

            //give the serial port related object and container
            serialPortOperations = new PortProcess(comboBoxPortName.Name, comboBoxBaudRate.Name,
                                                   comboBoxParity.Name  , comboBoxStopBit.Name,
                                                   comboBoxDataBits.Name, buttonConnect.Name,
                                                   buttonDisconnect.Name, groupBoxSerialCom);

            timerUpdateUart.Start();
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
    }
}
