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
    public partial class MySqlTestForm : Form
    {
        private MySqlConnection conn;
        public MySqlTestForm()
        {
            InitializeComponent();
        }

        private void RefreshView()
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select Id,Name,Surname,Phones from tst";
            DataSet ds = new DataSet();
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                da.Fill(ds);
            }
            View.DataSource = ds.Tables[0];
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (conn == null) 
            {
                string user = "alex";
                conn = new MySqlConnection
                (
                    @"server=direct.wsisiz.edu.pl;userid=" + user +
                    ";password=" + edPassword.Text.Trim() + 
                    ";database=" + user
                );
                conn.Open();
                RefreshView();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            string name = null, surname = null, phones = null;
            if(RecordEdit.Execute(ref name,ref surname,ref phones))
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"insert into tst set Name=@name, Surname=@surname, Phones=@phones";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@phones", phones);
                cmd.ExecuteNonQuery();
                RefreshView();
            }
            View.Focus();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            string rows="";
            int count = View.SelectedRows.Count;
            for (int i = 0; i < count; ++i)
            {
                rows += View.SelectedRows[i].Cells[0].Value.ToString() + '\t';
            }
            rows = rows.Trim().Replace('\t', ',');
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"delete from tst where id in ("+ rows + ")";
            cmd.ExecuteNonQuery();
            RefreshView();
            View.Focus();
        }
}
}
