using Server.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Server.BLL;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Server.socket_configure
{
    public class ServerManager
    {
        IPEndPoint iP;
        Socket socketServer;
        public List<InfoClient> arrClient;
        const int portCode = 1604;
        const int maxGetByte = 1024 * 5000;
        public static int refreshClient = -1;
        public const int change = -1;
        const int request = 0;
        const string wait = "WAITING";
        const string USING = "USING";
        public double totalMoney;
        public List<Socket> clientList;
        public double clientPrice;
        private ProcessMember ProcessMember = new ProcessMember();
        private ProcessClient ProcessClient = new ProcessClient();
        private ProcessGroupClient ProcessGroupClient = new ProcessGroupClient();
        public ServerManager()
        {
            arrClient = new List<InfoClient>();
            iP = new IPEndPoint(IPAddress.Any, portCode);
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socketServer.Bind(iP);
            Thread OkeFine = new Thread(StartAceptClient);
            OkeFine.IsBackground = true;
            OkeFine.Start();
            
        }
        public void StartAceptClient()
        {
            try
            {
                while (true)
                {
                    socketServer.Listen(100);
                    Socket newClient = socketServer.Accept();
                    Thread listenClient = new Thread(ReceiveDataFromClient);
                    listenClient.IsBackground = true;
                    listenClient.Start(newClient);
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void ReceiveDataFromClient(object obj)
        {
            Socket currentClient = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] messegeFromClient = new byte[1024 * 5000];
                    currentClient.Receive(messegeFromClient);
                    string messege = (string)CovertToMessege(messegeFromClient);
                    List<string> lstMessege = messege.Split('|').ToList();
                    IPEndPoint remoteEndPoint = (IPEndPoint)currentClient.RemoteEndPoint;
                    IPAddress clientIpAddress = remoteEndPoint.Address;
                    if (lstMessege[request].Equals("ConnectWithMePls!!"))
                    {
                        arrClient.Add(
                        new InfoClient()
                        {
                            clientIp = clientIpAddress.ToString(),
                            stateClient = wait,
                            client = currentClient,
                            
                        }) ;
                        refreshClient = change;
                    }
                    if (lstMessege[request].Equals("AllowToLogInPls!!"))
                    {
                        if (ProcessMember.checkLoginMember(lstMessege[1], lstMessege[2]))
                        {
                            totalMoney = ProcessMember.getTotalMoney(lstMessege[1]);
                            foreach (InfoClient cli in arrClient)
                            {
                                if (cli.client == currentClient)
                                {
                                    string groupClientName = ProcessClient.getGroupName(cli);
                                    this.clientPrice = ProcessGroupClient.getClientPrice(groupClientName);
                                }
                            }
                            currentClient.Send(ConvertToByte("OkePlayGo|" + lstMessege[1] + "|" + totalMoney + "|" + clientPrice + "|"));
                            ChangeStateClient(currentClient, "MEMBER USING", lstMessege[1]);

                        }
                        else
                        {
                            currentClient.Send(ConvertToByte("Account not exist !! Or Wrong Username, Password"));
                            ChangeStateClient(currentClient, "WAITING", lstMessege[1]);
                        }


                    }
                    if (lstMessege[request].Equals("UpdateMoney"))
                    {
                        ProcessMember.updateCurrentMoney(lstMessege[1], double.Parse(lstMessege[2]));
                    }
                    if (lstMessege[request].Equals("LogOutPls!!"))
                    {
                        currentClient.Send(ConvertToByte("OKLogout"));
                        ChangeStateClient(currentClient, "DISCONNECT", lstMessege[1]);
                    }
                    if (lstMessege[request].Equals("ChangePass"))
                    {
                        if (ProcessMember.checkLoginMember(lstMessege[1], lstMessege[2])){
                            if (ProcessMember.updateNewPass(lstMessege[1], lstMessege[3]))
                            {
                                currentClient.Send(ConvertToByte("ChangePassSuccess"));
                            }
                        }
                        else
                        {
                            currentClient.Send(ConvertToByte("WrongCurrentPassword"));
                        }
                    }
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void ChangeStateClient(Socket client, string state, string userName)
        {
            foreach (InfoClient cli in arrClient)
            {
                if (cli.client == client)
                {
                    cli.stateClient = state;
                    cli.memberName = userName;
                    ProcessClient.changeStateClient(cli);
                }
            }
        }
        byte[] ConvertToByte(object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }
        object CovertToMessege(byte[] messege)
        {
            MemoryStream memoryStream = new MemoryStream(messege);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(memoryStream);
        }

        public InfoClient GetInfoClient(string nameClient, string contraint)
        {
            foreach (InfoClient infoClient in arrClient)
            {
                if (infoClient.client.Equals(nameClient) && infoClient.stateClient.Equals(contraint))
                {
                    return infoClient;
                }

            }
            return null;
        }
    }
}
