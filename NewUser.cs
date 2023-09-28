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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=tesst;user=root;password=;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string firstname = fname.Text;
            string lastname = lname.Text;
            string email = ename.Text;

            string UserId = uname.Text;


            string query = "INSERT INTO newuser (FirstName, LastName, Email, UserId) VALUES (@firstname, @lastname, @email,@UserId)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@firstname", firstname);
            command.Parameters.AddWithValue("@lastname", lastname);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@UserId", UserId);

            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Data inserted successfully.");
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void phname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
