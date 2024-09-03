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
    public partial class MemberControl : UserControl
    {
        public MemberControl()
        {
            InitializeComponent();
        }
        Member member = new Member();
        bool addMember = false;
        ProcessMember pcMember = new ProcessMember();   
      
        public void getDataMember()
        {
            member.AccountName = txtAccountName.Text;
            member.Password = txtPassword.Text;
            member.GroupUser = cbGroupUser.SelectedValue.ToString();
            member.CurrentMoney = float.Parse(nbMoney.Value.ToString());
            member.StatusAccount = cbStatus.SelectedItem.ToString();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MemberControl_Load(object sender, EventArgs e)
        {
            cbGroupUser.DisplayMember = "GroupName";
            cbGroupUser.ValueMember = "GroupName";
            cbGroupUser.DataSource = pcMember.getGroupUser();
            

        }

        private void dtgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAccountName.DataBindings.Clear();
            txtAccountName.DataBindings.Add("Text", dtgvMember.DataSource, "AccountName");
            txtPassword.DataBindings.Clear();
            txtPassword.DataBindings.Add("Text", dtgvMember.DataSource, "Password");
            nbMoney.DataBindings.Clear();
            nbMoney.DataBindings.Add("Text", dtgvMember.DataSource, "CurrentMoney");
            string status = dtgvMember.CurrentRow.Cells["StatusAccount"].Value.ToString();
         
            if(status.Equals("Cho Phép")){
               cbStatus.SelectedIndex = 0;
            }else 
            {
                cbStatus.SelectedIndex = 1;
            }


        }

        private void cbGroupUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string groupName = cbGroupUser.SelectedValue.ToString();
            dtgvMember.DataSource = pcMember.getMemberByGroupUser(groupName);
            cbStatus.SelectedIndex = 0;

        }

        private void btnThemHV_Click(object sender, EventArgs e)
        {
            
            btnSuaHV.Enabled = false;
            btnXoaHV.Enabled = false;
            txtAccountName.Clear();
            txtPassword.Clear();
            cbStatus.SelectedIndex = 0;
            txtAccountName.Focus();           
            nbMoney.Value = 0;
            addMember = true;
        }

        private void btnLuuHV_Click(object sender, EventArgs e)
        {
            getDataMember();
            if (addMember)
            {
                if (pcMember.checkSave(member))
                {
                    pcMember.addMember(member);

               }
                addMember = false;
                btnSuaHV.Enabled = true;
                btnXoaHV.Enabled = true;
               
            }
            else
            {
                pcMember.updateMember(member);
                btnThemHV.Enabled = true;
                btnXoaHV.Enabled = true;
                txtAccountName.Enabled = true;
            }
            MemberControl_Load(sender, e);
        }

        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            txtAccountName.Enabled= false;
            txtPassword.Focus();
            btnThemHV.Enabled= false;
            btnXoaHV.Enabled= false;
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            getDataMember();
            pcMember.deleteMember(member);
            MemberControl_Load(sender, e);
        }

        private void nbMoney_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
