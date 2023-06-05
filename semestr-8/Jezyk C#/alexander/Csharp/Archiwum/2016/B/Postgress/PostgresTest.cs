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

namespace Postgress
{
    public partial class PostgresTest : Form
    {
        private static string confmt="Server={0};Port={1};User Id={2};Password={3};Database={4}";
        public PostgresTest()
        {
            InitializeComponent();
        }
        private NpgsqlConnection Connect()
        {
            string constr = string.Format(confmt, txtHost.Text, txtPort.Text, txtUser.Text, txtPass.Text, txtDatabase.Text);
            NpgsqlConnection conn = new NpgsqlConnection(constr);
            conn.Open();
            return conn;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conn = Connect();
                DataSet ds = new DataSet();
                string query = "select osobaid,nazwisko,imie,pesel,adres from osoba";
                new NpgsqlDataAdapter(query, conn).Fill(ds);
                Viewer.DataSource = ds.Tables[0];
                conn.Close();
                Viewer.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void InsertData(string nazwisko, string imie, string pesel, string adres)
        {
            NpgsqlConnection conn = Connect();
            string strfmt = "insert into osoba (nazwisko,imie,pesel,adres) values ('{0}','{1}','{2}','{3}')";
            string query = string.Format(strfmt, nazwisko, imie, pesel, adres);
            new NpgsqlCommand(query, conn).ExecuteNonQuery();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PostgresEdit.Execute(new InsertProc(InsertData));
            btnConnect.PerformClick();
        }
    }
}
