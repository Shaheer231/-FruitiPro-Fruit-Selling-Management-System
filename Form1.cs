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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MySqlConnection con = new MySqlConnection();

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"server= localhost;database=tesst;userid=root;password=;";
            LoadCustomersId();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //test connection

            con.Open();

            if(con.State ==ConnectionState.Open)
            {
                MessageBox.Show("Sucessfull DataBase Connection Established");

                con.Close();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Apple");
            comboBox1.Items.Add("Grapes");
            comboBox1.Items.Add("Lemon");
            comboBox1.Items.Add("Orange");

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.BlueViolet;
            radioButton2.ForeColor = System.Drawing.Color.RosyBrown;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("--------");
            comboBox1.Items.Add("Mango");
            comboBox1.Items.Add("Kiwi");
            comboBox1.Items.Add("Guava");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Apple")
            {
                textBox1.Text = "50";
            }

            else if (comboBox1.SelectedItem.ToString() == "Grapes")
            {
                textBox1.Text = "100";
            }

            else if (comboBox1.SelectedItem.ToString() == "Lemon")
            {
                textBox1.Text = "150";
            }

            else if(comboBox1.SelectedItem.ToString() == "Orange")
            {
                textBox1.Text = "200";
            }

            else if (comboBox1.SelectedItem.ToString() == "------")
            {
                textBox1.Text = "000";
            }

            else if (comboBox1.SelectedItem.ToString() == "Mango")
            {
                textBox1.Text = "250";
            }

            else if (comboBox1.SelectedItem.ToString() == "Kiwi")
            {
                textBox1.Text = "300";
            }

            else if (comboBox1.SelectedItem.ToString() == "Guava")
            {
                textBox1.Text = "350";
            }

            else
            {
                textBox1.Text = "0";
            }
            textBox3.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                textBox3.Text = (Convert.ToInt64(textBox1.Text) * Convert.ToInt64(textBox2.Text)).ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text,comboBox3.Text);

            if (int.TryParse(textBox3.Text, out int parseResult))
            {
                if (!string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    int result = Convert.ToInt32(textBox4.Text) + parseResult;
                    textBox4.Text = result.ToString();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            if (dataGridView1.Rows[i].IsNewRow)
            {
                dataGridView1.Rows.RemoveAt(i);
            }
            else
            {
                textBox4.Text = (Convert.ToInt16(textBox4.Text) - Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value)).ToString();
                dataGridView1.EndEdit();
                dataGridView1.Rows.RemoveAt(i);
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //int num1, num2;
            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrEmpty(textBox5.Text) &&
            Int16.TryParse(textBox4.Text, out short num1) && Int16.TryParse(textBox5.Text, out short num2))
            {
                textBox6.Text = (num1 - num2).ToString();
            }
            else
            {
                //Show error message or clear the textbox6
                
                textBox6.Text = "";
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<dataGridView1.Rows.Count-1;i++)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO itemtable( ItemName, Price, Quantity, Total, RegisterDate, UserId)  VALUES (" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "', '" + dataGridView1.Rows[i].Cells[5].Value + "')", con);
                con.Open();

                //cmd.ExecuteNonQuery();

                MessageBox.Show("SuccesFully Insert Data");

                con.Close();
            }

            dataGridView1.Rows.Clear();
            textBox4.Text = "0";
            textBox5.Text = " ";
            textBox6.Text = " ";
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadData LDform = new LoadData();
            LDform.ShowDialog();
            LDform = null;
            this.Show();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser LDform = new NewUser();
            LDform.ShowDialog();
            LDform = null;
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewSeller LDform = new NewSeller();
            LDform.ShowDialog();
            LDform = null;
            this.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LoadCustomersId()
        {
            var connectionString = "server= localhost;database=tesst;userid=root;password=;";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT userID, Concat(FirstName, ' ',LastName) as cName FROM newuser ORDER BY userID;";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        //Iterate through the rows and add it to the combobox's items
                        while (reader.Read())
                        {
                            comboBox3.Items.Add(reader.GetString("userID"));
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadCustomersId();
        }
    }
}
