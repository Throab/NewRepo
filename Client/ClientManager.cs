using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{

    public class ClientManager
    {
        IPEndPoint Ip;
        public Socket client;
        int portCode = 1604;
        const int maxGetByte = 1024 * 4000;
        public static int refreshClient = -1;
        public const int change = -1;
        const int request = 0;
        public static int requestServer = -1;
        const int USECLIENT = 101;
        public const int MEMBERLOGIN = 102;
        public const int PAYMENT = 103;
        public LoginFormClient lockScreen;
        public string userName = "";
        public static string message;
        public double totalMoney;
        public double clientPrice;
        public ClientManager()
        {
            Ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portCode);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(Ip);
                client.Send(ConvertToByte("ConnectWithMePls!!|" + "May-1"));               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Thread listenSever = new Thread(ReceiveDataFromSever);
            listenSever.IsBackground = true;
            listenSever.Start();
            lockScreen = new LoginFormClient(this);
            lockScreen.Show();

        }
        
        public void ReceiveDataFromSever()
        {

            try
            {
                bool check = true;
                while (true)
                {
                    byte[] messageFromClient = new byte[maxGetByte];
                    client.Receive(messageFromClient);
                    string msg = CovertToMessage(messageFromClient).ToString();
                    List<string> lstMessage = msg.Split('|').ToList();
                    if (lstMessage[request].Equals("UseClient"))
                    {
                        userName = "Customer";
                        requestServer = USECLIENT;
                        lockScreen.Visible = false;
                    }
                    if (lstMessage[request].Equals("PAYMENT"))
                    {
                        lockScreen.Visible = true;
                        requestServer = PAYMENT;
                    }
                    if (lstMessage[request].Equals("LockClient!"))
                    {
                        lockScreen.Visible = true;
                    }
                    if (lstMessage[request].Equals("OkePlayGo"))
                    {
                        this.userName = lstMessage[1];
                        this.totalMoney = double.Parse(lstMessage[2]);
                        this.clientPrice = double.Parse(lstMessage[3]);
                        requestServer = MEMBERLOGIN;
                        message = "Login";
                        lockScreen.Visible = false;                        
                    }
                    if (lstMessage[request].Equals("Account not exist !! Or Wrong Username, Password"))
                    {
                        message = "Login wrong";
                    }
                    if (lstMessage[request].Equals("Your account is exhausted.Recharge to use it!!!"))
                    {
                        lockScreen.Visible = true;
                        message = "Your account is exhausted.Recharge to use it!!!";
                    }
                    if (lstMessage[request].Equals("OKLogout")){
                        lockScreen.Visible = true; 
                    }
                    if (lstMessage[request].Equals("ChangePassSuccess"))
                    {
                        message = "Change pass success";
                    }
                    if (lstMessage[request].Equals("WrongCurrentPassword"))
                    {
                        message = "Wrong password";
                    }
                }
            }
            catch
            {
                if(MessageBox.Show("Mất kết nối với máy chủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Application.Exit();
                }
                
            }
        }
        public void Login(string userName, string passWord)
        {
            client.Send(ConvertToByte("AllowToLogInPls!!|" + userName + "|" + passWord + "|"));
        }
        public void LogoutMember(string userName)
        {
            client.Send(ConvertToByte("LogOutPls!!|" + userName + "|"));
        }
        public void updateMoney(string userName, double totalMoney, TimeSpan usedTime)
        {
            client.Send(ConvertToByte("UpdateMoney|" + userName + "|" + totalMoney.ToString() + "|" + usedTime + "|"));
        }
        public void showInfo(string userName)
        {
            client.Send(ConvertToByte("ShowInfo|" + userName + "|"));
        }
        public void changePass(string userName, string currentPass, string newPass)
        {
            client.Send(ConvertToByte("ChangePass|" + userName + "|" + currentPass + "|" + newPass + "|"));
        }
        byte[] ConvertToByte(object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }
        object CovertToMessage(byte[] messege)
        {
            MemoryStream memoryStream = new MemoryStream(messege);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(memoryStream);
        }
        

    }
}
