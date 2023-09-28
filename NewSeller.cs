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

namespace WindowsFormsApp1
{
    public partial class NewSeller : Form
    {
        public NewSeller()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=tesst;user=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string firstname = sname.Text;
            string lastname = aname.Text;
            string email = esname.Text;
            string SellerId = tname.Text;

            string query = "INSERT INTO newseller (FirstName, LastName, Email,SellerId) VALUES (@firstname, @lastname, @email,@SellerId)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@firstname", firstname);
            command.Parameters.AddWithValue("@lastname", lastname);
            command.Parameters.AddWithValue("@email", email);
            //command.Parameters.AddWithValue("@phonenumber", phoneNumber);
            command.Parameters.AddWithValue("@SellerId", SellerId);

            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Data inserted successfully.");
        }

        private void tname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void esname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
