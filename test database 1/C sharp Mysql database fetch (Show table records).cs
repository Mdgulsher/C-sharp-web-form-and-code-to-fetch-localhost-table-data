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

namespace test_database_1
{
    public partial class Form1 : Form
    {
        //Connection string

        MySqlConnection con = new MySqlConnection("SERVER= LOCALHOST;DATABASE=news-site;UID=root;Password=");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM user",con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
