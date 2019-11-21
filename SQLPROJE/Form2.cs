using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
namespace SQLPROJE
{
    public partial class Form2 : Form
    {
        Xml x = new Xml();
        SqlConnection cn;
        SqlConnection cn2;
        SqlCommand cmd;
        SqlCommand cmd3;
        public Form2(Xml x)
        {
            InitializeComponent();
            this.x = x;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            x.connectionstring = x.XmlOku(2);
            cn = new SqlConnection(x.connectionstring);
            timer1.Interval = 1000;
            Thread.Sleep(100);
            timer1.Start();

        }
        private void CalisanSorguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSorgu formSorgu = new FormSorgu(x);
            formSorgu.Show();
            this.Opacity = 0;
        }
        private void GorevYoneticisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGorev formgorev = new FormGorev(x);
            formgorev.Show();
            this.Opacity = 0;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            cn.Open();
            cmd = new SqlCommand("sp_runsp", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIndex formindex = new FormIndex(x);
            formindex.Show();
            this.Opacity = 0;
        }
    }
}
