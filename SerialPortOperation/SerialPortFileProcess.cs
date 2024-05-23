using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_cellSimulatorV1._1.SerialPortOperation
{
    public class SerialPortFileProcess
    {
        /*This variable used to reac the control of serial port groupbox*/
        private string cmbPortName;
        private string cmbBaudrateName;
        private string cmbParityName;
        private string cmbStopBitName;
        private string cmbDataBitName;
        private string buttonConnect;
        private string buttonDisconnect;

        public SerialPortFileProcess(string cmbPortName, string cmbBaudrateName, string cmbParityName, string cmbStopBitName,
                           string cmbDataBitName, string buttonConnect, string buttonDisconnect)
        {
            this.cmbPortName = cmbBaudrateName;
            this.cmbBaudrateName = cmbBaudrateName;
            this.cmbParityName = cmbParityName;
            this.cmbStopBitName = cmbStopBitName;
            this.cmbDataBitName = cmbDataBitName;
            this.buttonConnect = buttonConnect;
            this.buttonDisconnect = buttonDisconnect;
        }

        public void saveUartConfiguration(Control uartGroupBox)
        {
            string filePath = @"C:\yModem\yModem.txt";
            StreamWriter sw = new StreamWriter(filePath);

            sw.WriteLine(((ComboBox)uartGroupBox.Controls["comboBoxPortName"]).Text);
            sw.WriteLine(((ComboBox)uartGroupBox.Controls["comboBoxBaudRate"]).SelectedIndex);
            sw.WriteLine(((ComboBox)uartGroupBox.Controls["comboBoxDataBits"]).SelectedIndex);
            sw.WriteLine(((ComboBox)uartGroupBox.Controls["comboBoxParity"]).SelectedIndex);
            sw.WriteLine(((ComboBox)uartGroupBox.Controls["comboBoxStopBit"]).SelectedIndex);

            sw.Close();
        }

        public void readUartConfigurationFromFile(Control control)
        {
            string directoryPath = @"C:\yModem";
            string filePath = @"C:\yModem\yModem.txt";
            string[] txtLine = new string[5];

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath);

                ((ComboBox)control.Controls["comboBoxPortName"]).SelectedIndex = 0;
                ((ComboBox)control.Controls["comboBoxBaudRate"]).SelectedIndex = 6; //9600 baudrate
                ((ComboBox)control.Controls["comboBoxDataBits"]).SelectedIndex = 1; // 8 bit data
                ((ComboBox)control.Controls["comboBoxParity"]).SelectedIndex = 0;
                ((ComboBox)control.Controls["comboBoxStopBit"]).SelectedIndex = 0;

                return;
            }

            StreamReader sr = new StreamReader(filePath);

            for (int i = 0; i < 5; i++)
            {
                txtLine[i] = sr.ReadLine();
            }

            foreach (string item in SerialPort.GetPortNames())
            {
                if (txtLine[0].ToUpper() == item.ToString())
                {
                    ((ComboBox)control.Controls["comboBoxPortName"]).Text = item;
                    break;
                }
                else
                {

                    ((ComboBox)control.Controls["comboBoxPortName"]).SelectedIndex = 0;
                }
            }

            ((ComboBox)control.Controls["comboBoxBaudRate"]).SelectedIndex = int.Parse(txtLine[1]);
            ((ComboBox)control.Controls["comboBoxDataBits"]).SelectedIndex = int.Parse(txtLine[2]);
            ((ComboBox)control.Controls["comboBoxParity"]).SelectedIndex = int.Parse(txtLine[3]);
            ((ComboBox)control.Controls["comboBoxStopBit"]).SelectedIndex = (int.Parse(txtLine[4]));

            sr.Close();
        }
    }
}
