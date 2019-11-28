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
        string kontrol = null;
        private Thread th1;
        private Thread th2;
        private Thread th3;
        private Thread th4;

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
            kontrol = x.XmlOku(4);
            if (kontrol=="true") {
            x.connectionstring = x.XmlOku(2);
            cn = new SqlConnection(x.connectionstring);
            this.th1 =new Thread(new ThreadStart(this.calistir));
            this.th2 = new Thread(new ThreadStart(this.calistir));

                th1.Start();
                timer1.Start();
            }
        }
        private void CalisanSorguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSorgu formSorgu = new FormSorgu(x);
            formSorgu.Show();
            this.Opacity = 0;
        }
        private void GorevYoneticisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(kontrol=="true")
            {
                    FormGorev formgorev = new FormGorev(x);
                    formgorev.Show();
                    this.Opacity = 0;
            }
            else
            {
                MessageBox.Show("Görev Yöneticisi Kapalı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }   
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
          //  Thread.Sleep(100);
            calistir();
        }

        public void calistir()
        {   
            try
            {
                cn.Open();
                cmd = new SqlCommand("sp_runsp", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch { }
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
        private void veritaabnıboyutkucultmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBoyut frmboyut = new FormBoyut(x);
            frmboyut.Show();
            this.Opacity = 0;
        }

        private void veritabaniyedeklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYedekleme formYedekleme = new FormYedekleme(x);
            formYedekleme.Show();
            this.Opacity = 0;
            //OpenFileDialog file = new OpenFileDialog();
           // file.ShowDialog();





        }
    }
}
