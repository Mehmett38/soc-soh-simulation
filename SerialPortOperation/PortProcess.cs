using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_cellSimulatorV1._1.SerialPortOperation
{
    public class PortProcess
    {
        /*This variable used to reac the control of serial port groupbox*/
        private string cmbPortName;
        private string cmbBaudrateName;
        private string cmbParityName;
        private string cmbStopBitName;
        private string cmbDataBitName;
        private string buttonConnectName;
        private string buttonDisconnectName;

        static public SerialPortConnection_e serialPortStatus;
        SerialPortFileProcess serialPortFileSaver;  //save the setting in a txt file and initialize when program restart
        int portNumber;

        public PortProcess(string cmbPortName, string cmbBaudrateName, string cmbParityName, string cmbStopBitName,
                           string cmbDataBitName, string buttonConnectName, string buttonDisconnectName, Control control)
        {
            this.cmbPortName = cmbPortName;
            this.cmbBaudrateName = cmbBaudrateName;
            this.cmbParityName = cmbParityName;
            this.cmbStopBitName = cmbStopBitName;
            this.cmbDataBitName = cmbDataBitName;
            this.buttonConnectName = buttonConnectName;
            this.buttonDisconnectName = buttonDisconnectName;

            serialPortFileSaver = new SerialPortFileProcess(cmbPortName, cmbBaudrateName, cmbParityName,cmbStopBitName,
                                                            cmbDataBitName, buttonConnectName, buttonDisconnectName);

            updatePort(control);
            serialPortFileSaver.readUartConfigurationFromFile(control);
        }
        /*Internal Functions*/
        private void updatePort(Control control)
        {
            string[] portNames = SerialPort.GetPortNames();
            portNumber = portNames.Length;

            Array.Sort(portNames);

            foreach (string item in portNames)
            {
                ((ComboBox)control.Controls[cmbPortName]).Items.Add(item);
            }
        }

        /*External Functions*/
        public void portConnect(Control control, SerialPort port)
        {
            try
            {
                port.PortName = (string)((ComboBox)control.Controls[cmbPortName]).Text;
                port.BaudRate = int.Parse((string)((ComboBox)control.Controls[cmbBaudrateName]).SelectedItem);
                port.Parity = (Parity)((ComboBox)control.Controls[cmbParityName]).SelectedIndex;
                port.StopBits = (StopBits)(((ComboBox)control.Controls[cmbStopBitName]).SelectedIndex + 1);
                port.DataBits = int.Parse((string)((ComboBox)control.Controls[cmbDataBitName]).SelectedItem);

                port.Open();

                ((Button)control.Controls[buttonConnectName]).Enabled = false;

                ((Button)control.Controls[buttonConnectName]).BackColor = Color.Green;

                serialPortFileSaver.saveUartConfiguration(control);

                serialPortStatus = SerialPortConnection_e.PORT_CONNECTED;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                serialPortStatus = SerialPortConnection_e.PORT_CONNECTION_ERROR;
            }
        }

        public void portDisconnet(Control control, SerialPort port)
        {
            if(serialPortStatus == SerialPortConnection_e.PORT_CONNECTED)
            {
                try
                {
                    port.Close();
                    ((Button)control.Controls[buttonConnectName]).Enabled = true;
                    ((Button)control.Controls[buttonConnectName]).BackColor = Color.FromArgb(225, 225, 225);

                    serialPortStatus = SerialPortConnection_e.PORT_DISCONNECTED;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void chechSerialPortConnection(Control control, SerialPort port)
        {
            bool portStatus = port.IsOpen;
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            int currentPortNumber = ports.Length;

            if(!portStatus)
            {
                if (portNumber != currentPortNumber)
                {
                    ((ComboBox)control.Controls[cmbPortName]).Items.Clear();
                    foreach (string portName in ports)
                    {
                        ((ComboBox)control.Controls[cmbPortName]).Items.Add(portName);
                    }
                }
            }

            if((portStatus == false) && (serialPortStatus == SerialPortConnection_e.PORT_CONNECTED))
            {
                serialPortStatus = SerialPortConnection_e.PORT_DISCONNECTED;

                port.Close();
                ((Button)control.Controls[buttonConnectName]).Enabled = true;
                ((Button)control.Controls[buttonConnectName]).BackColor = Color.FromArgb(225, 225, 225);  //Button defalt color
                MessageBox.Show("Bağlantı hatası", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            portNumber = currentPortNumber;
        }

    }
    }
