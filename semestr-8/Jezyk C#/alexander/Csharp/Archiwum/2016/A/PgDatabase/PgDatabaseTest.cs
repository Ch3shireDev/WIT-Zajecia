using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PgDatabase
{
    public partial class PgDatabaseTest : Form
    {
        //private DataSet ds;
        public PgDatabaseTest()
        {
            InitializeComponent();
            //ds = new DataSet();
        }

        private NpgsqlConnection Connect()
        {
            string connstr = String.Format
            (
                "Server={0};Port={1};User Id={2};Password={3};Database={4}",
                txtHost.Text, txtPort.Text, txtUser.Text, txtPass.Text, txtDatabase.Text
            );
            NpgsqlConnection conn = new NpgsqlConnection(connstr);
            conn.Open();
            return conn;
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = Connect();
                DataSet ds = new DataSet();
                //ds.Reset();
                new NpgsqlDataAdapter("select osobaid,nazwisko,imie,pesel,adres from osoba", conn).Fill(ds);
                //ds.Tables[0].Columns[0].
                Viewer.DataSource = ds.Tables[0];
                conn.Close();
                //Viewer.SelectedRows[0].Cells["osobaid"]
            }
            catch(Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string surname = "",name = "",PESEL = "",adres = "";
            if (PersonEdit.Execute(ref surname, ref name, ref PESEL, ref adres))
            {
                NpgsqlConnection conn = Connect();
                string sql = string.Format
                (
                    "insert into osoba (nazwisko,imie,pesel,adres) values ('{0}','{1}','{2}','{3}')",
                    surname, name, PESEL, adres
                );
                new NpgsqlCommand(sql, conn).ExecuteNonQuery();
                btnConnect.PerformClick();
            }
        }
    }
}
