using Server.BLL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.GUI
{
    public partial class MemberHomePageControl : UserControl
    {
        ProcessMember ProcessMember = new ProcessMember();
        public MemberHomePageControl()
        {
            InitializeComponent();
        }

        private void MemberHomePageControl_Load(object sender, EventArgs e)
        {
            loadDataMember();
        }
        private void loadDataMember()
        {
            dgvMember.DataSource = ProcessMember.getMember();
        }
    }
}
