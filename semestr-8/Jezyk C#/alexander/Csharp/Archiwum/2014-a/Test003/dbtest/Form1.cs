using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dbtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MySqlConnection conn = new MySqlConnection("datasource=direct;port=3306;username=parkandride;password=EfucjMGat2nQJ4DH;database=parkandride");
            conn.Open();
            DataSet ds = new DataSet();
            new MySqlDataAdapter("show tables", conn).Fill(ds);
            LBox.DisplayMember = "Tables_in_parkandride";
            LBox.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
