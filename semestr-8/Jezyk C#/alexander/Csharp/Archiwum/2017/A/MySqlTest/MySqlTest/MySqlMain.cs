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

namespace MySqlTest
{
    public partial class MySqlMain : Form
    {
        private MySqlConnection conn;
        public MySqlMain()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                string user = "alex";
                string connstr
                =
                  @"server=direct.wsisiz.edu.pl;userid=" + user +
                  ";password=" + edPassword.Text +
                  ";database=" + user
                ;
                conn = new MySqlConnection(connstr);
                conn.Open();
                RefreshGrid();
                View.Focus();
                BtnConnect.Text = "Disconnect";
                AcceptButton = null;
                CancelButton = BtnConnect;
            }
            else
            {
                conn.Close();
                conn = null;
                View.DataSource = null;
                edPassword.Focus();
                BtnConnect.Text = "Connect";
                AcceptButton = BtnConnect;
                CancelButton = null;
            }
        }

        private void RefreshGrid()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select Id, name, surname, phones from tst";
            DataSet ds = new DataSet();
            (new MySqlDataAdapter(cmd)).Fill(ds);
            View.DataSource = ds.Tables[0];
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name, surname, phones;
            name = surname = phones = null;
            if (RecordForm.Execute(ref name, ref surname, ref phones))
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"insert into tst set name=@name, surname=@surname, phones=@phones";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@phones", phones);
                cmd.ExecuteNonQuery();
            }
            RefreshGrid();
            View.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int count = View.SelectedRows.Count;
            for (int i = 0; i < count; ++i)
            {
                string id = View.SelectedRows[i].Cells[0].Value.ToString();
                string name = View.SelectedRows[i].Cells[1].Value.ToString();
                string surname = View.SelectedRows[i].Cells[2].Value.ToString();
                string phones = View.SelectedRows[i].Cells[3].Value.ToString();
                if (RecordForm.Execute(ref name, ref surname, ref phones))
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = @"update tst set name=@name, surname=@surname, phones=@phones where id=@id";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@phones", phones);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            RefreshGrid();
            View.Focus();
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int count = View.SelectedRows.Count;
            for (int i = 0; i < count; ++i)
            {
                string id = View.SelectedRows[i].Cells[0].Value.ToString();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"delete from tst where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            RefreshGrid();
            View.Focus();
        }

    }
}
