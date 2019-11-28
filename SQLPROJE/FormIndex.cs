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

namespace SQLPROJE
{
    public partial class FormIndex : Form
    {
        Xml x = new Xml();
        SqlConnection cn;
        SqlCommand cmd;
        public FormIndex(Xml x)
        {
            this.x = x;
            InitializeComponent();
        }
        public void getFragmentation()
        {
            try
            {
                cn.Open();

                string isletilecekquery = "use " + cmbBoxVeriTabanı.SelectedItem + " " + "SELECT OBJECT_NAME(ips.OBJECT_ID),i.NAME ,ips.index_id,avg_fragmentation_in_percent,page_count FROM sys.dm_db_index_physical_stats(DB_ID(), NULL, NULL, NULL, 'SAMPLED') ips INNER JOIN sys.indexes i ON(ips.object_id = i.object_id) AND(ips.index_id = i.index_id) AND index_type_desc IN('CLUSTERED INDEX', 'NONCLUSTERED INDEX', 'UNIQUE INDEX') AND avg_fragmentation_in_percent>" + cmbBoxBozulma.SelectedItem + " " + "ORDER BY avg_fragmentation_in_percent DESC";
                cmd.CommandText = isletilecekquery;
                cmd.ExecuteNonQuery();
                cn.Close();

                cn.Open();

                SqlDataAdapter dr = new SqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                dr.Fill(ds2, "SqlTask_Clients");

                dataGridView1.DataSource = ds2.Tables["SqlTask_Clients"];
                cn.Close();

            }
            catch
            {
                MessageBox.Show("VeriTabanı Seçimi Yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            getFragmentation();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormIndex_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(x.XmlOku(3));
            FindDb();
        }
        public void FindDb()
        {
                string query = "SELECT name FROM master.sys.databases where name<>'Program' and name<>'DB_Task_Manager' and name<>'master' and name<>'model'and name<>'msdb' and name<>'tempdb'";
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = query;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbBoxVeriTabanı.Items.Add(dr["name"]);
                }
                cn.Close();
            cmbBoxBozulma.Items.Add("5");
            cmbBoxBozulma.Items.Add("10");
            cmbBoxBozulma.Items.Add("20");
            cmbBoxBozulma.Items.Add("40");
            cmbBoxBozulma.Items.Add("60");
            cmbBoxBozulma.Items.Add("70");
            cmbBoxBozulma.Items.Add("80");
            cmbBoxBozulma.Items.Add("90");
        }

        private void pictureBoxcikis_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch {}
        }

        private void pictureBoxgeri_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 frm2 = new Form2(x);
                frm2.Show();
                this.Close();
            }
            catch { }




        }

        private void btnRebuild_Click(object sender, EventArgs e)
        {
            cn.Open();
            string script = "DECLARE @Database NVARCHAR(255)  DECLARE @Table NVARCHAR(255) DECLARE @cmd NVARCHAR(1000) DECLARE DatabaseCursor CURSOR READ_ONLY FOR   SELECT name FROM master.sys.databases WHERE name IN ('"+ cmbBoxVeriTabanı.SelectedItem + " ') AND state = 0 AND is_in_standby = 0 ORDER BY 1 OPEN DatabaseCursor  FETCH NEXT FROM DatabaseCursor INTO @Database  WHILE @@FETCH_STATUS = 0  BEGIN   SET @cmd = 'DECLARE TableCursor CURSOR READ_ONLY FOR SELECT ''['' + table_catalog + ''].['' + table_schema + ''].['' +  table_name + '']'' as tableName FROM[' + @Database + '].INFORMATION_SCHEMA.TABLES WHERE table_type = ''BASE TABLE'''  EXEC (@cmd)  OPEN TableCursor    FETCH NEXT FROM TableCursor INTO @Table     WHILE @@FETCH_STATUS = 0 BEGIN BEGIN TRY SET @cmd = 'ALTER INDEX ALL ON ' + @Table + ' REBUILD' EXEC (@cmd)  END TRY  BEGIN CATCH PRINT '---' PRINT @cmd PRINT ERROR_MESSAGE() PRINT '---' END CATCH FETCH NEXT FROM TableCursor INTO @Table END    CLOSE TableCursor    DEALLOCATE TableCursor  FETCH NEXT FROM DatabaseCursor INTO @Database END CLOSE DatabaseCursor DEALLOCATE DatabaseCursor";
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = script;
            cmd.ExecuteNonQuery();
            cn.Close();

            getFragmentation();

        }

        private void btnReorganize_Click(object sender, EventArgs e)
        {
            cn.Open();
            string script = "DECLARE @Database NVARCHAR(255)  DECLARE @Table NVARCHAR(255) DECLARE @cmd NVARCHAR(1000) DECLARE DatabaseCursor CURSOR READ_ONLY FOR   SELECT name FROM master.sys.databases WHERE name IN ('" + cmbBoxVeriTabanı.SelectedItem + " ') AND state = 0 AND is_in_standby = 0 ORDER BY 1 OPEN DatabaseCursor  FETCH NEXT FROM DatabaseCursor INTO @Database  WHILE @@FETCH_STATUS = 0  BEGIN   SET @cmd = 'DECLARE TableCursor CURSOR READ_ONLY FOR SELECT ''['' + table_catalog + ''].['' + table_schema + ''].['' +  table_name + '']'' as tableName FROM[' + @Database + '].INFORMATION_SCHEMA.TABLES WHERE table_type = ''BASE TABLE'''  EXEC (@cmd)  OPEN TableCursor    FETCH NEXT FROM TableCursor INTO @Table     WHILE @@FETCH_STATUS = 0 BEGIN BEGIN TRY SET @cmd = 'ALTER INDEX ALL ON ' + @Table + ' REORGANIZE' EXEC (@cmd)  END TRY  BEGIN CATCH PRINT '---' PRINT @cmd PRINT ERROR_MESSAGE() PRINT '---' END CATCH FETCH NEXT FROM TableCursor INTO @Table END    CLOSE TableCursor    DEALLOCATE TableCursor  FETCH NEXT FROM DatabaseCursor INTO @Database END CLOSE DatabaseCursor DEALLOCATE DatabaseCursor";
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = script;
            cmd.ExecuteNonQuery();


            cn.Close();

            getFragmentation();
        }
    }
}
