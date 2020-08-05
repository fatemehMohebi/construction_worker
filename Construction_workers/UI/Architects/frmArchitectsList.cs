using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_workers.UI.Architects
{
    public partial class frmArchitectsList : Form
    {
        public frmArchitectsList()
        {
            InitializeComponent();
        }

        private void frmArchitectsList_Load(object sender, EventArgs e)
        {
            Business.Architects Architects = new Business.Architects();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Architects.read();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            UI.Architects.frmArchitectsAdd insert = new UI.Architects.frmArchitectsAdd();
            insert.ShowDialog();
            Business.Architects Architects = new Business.Architects();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Architects.read();
            MessageBox.Show("ثبت با موفقیت انجام شد", "اطلاع");
        }
    }
}
