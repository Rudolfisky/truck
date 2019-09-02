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
        DataSet LocalDS = new DataSet();

        public Form1()
        {
            InitializeComponent();
            Refresh();
        }

        private void contextMenuStrip1_Opening(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("test");
        }

        public void Refresh()
        {
            try
            {
                LocalDS = new DataSet();
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM eet_wagen.product", connection);

                connection.Open();

                adapter.Fill(LocalDS, "product");
                System.Diagnostics.Debug.WriteLine(LocalDS);
                dataGridView1.DataSource = LocalDS.Tables["product"];

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void del_Click(object sender, EventArgs e)
        {
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM eet_wagen.product", connection);

                connection.Open();

                //DataSet ds = new DataSet();
                //adapter.Fill(ds, "product");
                //dataGridView1.DataSource = ds.Tables["product"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
