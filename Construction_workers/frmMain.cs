using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_workers
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void جستجووحذفلیستکاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void مدیریتکاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListView userListview = new frmListView();
            userListview.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.ShowDialog();
        }

        private void ثبتکارگرجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmPerson frmpreson =new UI.frmPerson();
            frmpreson.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void لیستکارگرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void مدیریتکارمندانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Employees.frmEmployeesList list = new UI.Employees.frmEmployeesList();
            list.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("این متن برای کمک به شما نوشته خواهد شد.");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UI.frmPersonList personlist = new UI.frmPersonList();
            personlist.ShowDialog();
        }

    

        private void مدیریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmPersonList list = new UI.frmPersonList();
            list.ShowDialog();
        }

        private void مدیریتمعمارانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Architects.frmArchitectsList ArchitectsList =new UI.Architects.frmArchitectsList();
            ArchitectsList.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            UI.Architects.frmArchitectsList ArchitectsList = new UI.Architects.frmArchitectsList();
            ArchitectsList.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
