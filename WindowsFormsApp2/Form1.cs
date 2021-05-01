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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataSource, initCatalog, userId, passWord, connectionString;
            dataSource = "150-95-209-40";
            initCatalog = "master";
            userId = "SA";
            passWord = "Tatsuya0813";

            connectionString = @"Data Source="+ dataSource + ";Initial Catalog=" +
                initCatalog + ";User ID=" + userId + ";Password=" + passWord;
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            MessageBox.Show("DBコネクションを確立しました");
        }
    }
}
