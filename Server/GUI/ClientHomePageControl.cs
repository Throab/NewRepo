using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.BLL;
using Server.DTO;

namespace Server.GUI
{
    public partial class ClientHomePageControl: UserControl
    {
        ProcessClient ProcessClient = new ProcessClient();
        List<Client> clientList;
        public ClientHomePageControl()
        {
            InitializeComponent();
        }

        public void loadClientData()
        {
            clientList = ProcessClient.getAllClient();
            dgvClient.Controls.Clear();
            foreach (Client client in clientList)
            {
                ClientHomePageUserControl clientControl = new ClientHomePageUserControl();
                clientControl.Client = client;
                dgvClient.Controls.Add(clientControl);
            }
        }
        private void ClientHomePageControl_Load(object sender, EventArgs e)
        {
            loadClientData();   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadClientData();
        }
    }
}
