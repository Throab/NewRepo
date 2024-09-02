﻿using System;
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
        public string message = "message";
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
                    string message = CovertToMessage(messageFromClient).ToString();
                    List<string> lstMessage = message.Split('|').ToList();
                    this.message = "";
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
                        this.message = "Login";
                        lockScreen.Visible = false;                        
                    }
                    if (lstMessage[request].Equals("Account not exist !! Or Wrong Username, Password"))
                    {
                        this.message = "Account not exist !! Or Wrong Username, Password";
                    }
                    if (lstMessage[request].Equals("Your account is exhausted.Recharge to use it!!!"))
                    {
                        lockScreen.Visible = true;
                        this.message = "Your account is exhausted.Recharge to use it!!!";
                    }
                    if (lstMessage[request].Equals("OKLogout")){
                        lockScreen.Visible = true; 
                    }
                }
            }
            catch
            {

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
        public void updateMoney(string userName, double totalMoney)
        {
            client.Send(ConvertToByte("UpdateMoney|" + userName + "|" + totalMoney.ToString() + "|"));
        }
        public void showInfo(string userName)
        {
            client.Send(ConvertToByte("ShowInfo|" + userName + "|"));
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
