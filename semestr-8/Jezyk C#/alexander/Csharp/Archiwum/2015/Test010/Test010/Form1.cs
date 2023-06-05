using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test010
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshData(long Id=0)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select Id,Name,Surname,Phones from tst";
            DataSet ds = new DataSet();
            (new MySqlDataAdapter(cmd)).Fill(ds);
            View.DataSource = ds.Tables[0];
            int cnt = View.Rows.Count;
            for (int i = 0; i < cnt; ++i)
            {
                if (View.Rows[i].Cells[0].Value.ToString() == Id.ToString())
                {
                    View.Rows[i].Selected = true;
                    View.CurrentCell = View.Rows[i].Cells[0];
                    View.FirstDisplayedScrollingRowIndex = i;
                    break;
                }
            }
            View.Refresh();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(@"server=direct.wsisiz.edu.pl;userid=alex;password="+Password.Text+";database=alex");
            conn.Open();
            RefreshData();
            BtnConnect.Enabled = false;
            AcceptButton = BtnInsert;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"insert into tst set Name=?FldName, Surname=?FldSurname, Phones=?FldPhones";
                cmd.Parameters.AddWithValue("?FldName", FldName.Text.Trim());
                cmd.Parameters.AddWithValue("?FldSurname", FldSurname.Text.Trim());
                cmd.Parameters.AddWithValue("?FldPhones", FldPhones.Text.Trim());
                cmd.ExecuteNonQuery();
                RefreshData(cmd.LastInsertedId);
            }
            catch(System.InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int cnt = View.SelectedRows.Count;
            for (int i = 0; i < cnt; ++i)
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"delete from tst where Id=?FldId";
                cmd.Parameters.AddWithValue("?FldId", View.SelectedRows[i].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            RefreshData();
        }
    }
}
