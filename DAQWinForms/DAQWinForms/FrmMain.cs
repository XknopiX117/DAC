using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace DAQWinForms
{
    public partial class FrmMain : Form
    {
        int intAddress = 0;
        int intCommand = 0;
        int intChannel = 0;
        int intCRC = 1;

        SerialPort spDMK;

        public FrmMain()
        {
            InitializeComponent();
        }

        public void ConfigurePort(string portName)
        {
            spDMK.PortName = portName;
            spDMK.BaudRate = 9600;

            //Establece el canal de comunicacion con el epever
            spDMK.Open();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            spDMK = new SerialPort("COM4", 9600);
            //spDMK.DataReceived += SpArduino_DataReceived;
            spDMK.Open();
        }

        private void SpArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            intCRC += int.Parse(txtAddress.Text) ;
            txtCRC.Text = intCRC.ToString("00");
        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            intCRC += int.Parse(txtCommand.Text);
            txtCRC.Text = intCRC.ToString("00");
        }

        private void txtChannel_TextChanged(object sender, EventArgs e)
        {
            intCRC += int.Parse(txtChannel.Text);
            txtCRC.Text = intCRC.ToString("00");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ReadRegister(1, 4, 0x0001, 2, 1);
            ReadRegister(1, 4, 0x0047, 2, 10);
            ReadRegister(1, 4, 0x0041, 2, 1);
            ReadRegister(1, 4, 0x0011, 2, 100);
        }

        private void ReadRegister(byte slaveAdd, byte funcCode, ushort startAdd, uint numPoints, int div)
        {
            try
            {
                byte slaveAddress = slaveAdd;
                byte functionCode = funcCode;
                ushort startAddress = startAdd;
                uint numberOfPoints = numPoints;

                if (spDMK.IsOpen)
                {
                    byte[] frame = ReadHoldingRegistersMsg(slaveAddress, startAddress, functionCode, numberOfPoints);
                    //txtSendMsg.Text = Display(frame);
                    spDMK.Write(frame, 0, frame.Length);
                    Thread.Sleep(100); // Delay 100ms
                    if (spDMK.BytesToRead >= 5)
                    {
                        byte[] bufferReceiver = new byte[this.spDMK.BytesToRead];
                        spDMK.Read(bufferReceiver, 0, spDMK.BytesToRead);
                        spDMK.DiscardInBuffer();
                        //txtReceiMsg.Text = Display(bufferReceiver);

                        // Process data.
                        byte[] data = new byte[bufferReceiver.Length - 5];
                        Array.Copy(bufferReceiver, 3, data, 0, data.Length);
                        UInt16[] temp = Word.ByteToUInt16(data);
                        string result = string.Empty;
                        foreach (var item in temp)
                        {
                            result += string.Format("{0}", item);
                        }
                        //txtResult.Text = result;

                        switch (startAdd)
                        {
                            case 0x0001:
                                txtL1Volts.Text = (int.Parse(result)).ToString();
                                break;
                            case 0x0047:
                                txtFrequency.Text = (int.Parse(result) / div).ToString();
                                break;
                            case 0x0041:
                                txtOFaseL1.Text = (int.Parse(result)).ToString();
                                break;
                            case 0x0011:
                                txtAmpsL1.Text = (int.Parse(result) / div).ToString();
                                break;
                            //case 0x3110:
                            //    txtBatteryTemp.Text = (int.Parse(result) / 100.00f).ToString();
                            //    break;


                            default:
                                break;
                        }
                        //

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private byte[] ReadHoldingRegistersMsg(byte slaveAddress, ushort startAddress, byte function, uint numberOfPoints)
        {
            byte[] frame = new byte[8];
            frame[0] = slaveAddress;			    // Slave Address
            frame[1] = function;				    // Function             
            frame[2] = (byte)(startAddress >> 8);	// Starting Address High
            frame[3] = (byte)startAddress;		    // Starting Address Low            
            frame[4] = (byte)(numberOfPoints >> 8);	// Quantity of Registers High
            frame[5] = (byte)numberOfPoints;		// Quantity of Registers Low
            byte[] crc = this.CalculateCRC(frame);  // Calculate CRC.
            frame[frame.Length - 2] = crc[0];       // Error Check Low
            frame[frame.Length - 1] = crc[1];       // Error Check High
            return frame;
        }

        private byte[] CalculateCRC(byte[] data)
        {
            ushort CRCFull = 0xFFFF; // Set the 16-bit register (CRC register) = FFFFH.
            byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;
            byte[] CRC = new byte[2];
            for (int i = 0; i < (data.Length) - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ data[i]); // 

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
            return CRC;
        }

        private void txtL1Volts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmpsL1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOFaseL1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
