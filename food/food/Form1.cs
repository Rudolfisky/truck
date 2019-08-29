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

namespace food
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM eet_wagen.product", connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "product");
                dataGridView1.DataSource = ds.Tables["product"];
                connection.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("test");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM eet_wagen.product", connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "product");
                dataGridView1.DataSource = ds.Tables["product"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {

        }
    }
}
