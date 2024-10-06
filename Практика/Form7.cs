using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace Практика
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string connectionString = "Server=localhost;Database=agenstvo;User ID=Alechka;Password=Alfia.2006;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        DataTable table = new DataTable();
                        MySqlCommand command1 = new MySqlCommand($"SELECT id, name, data, pasport, email, number, zagran FROM klient WHERE name = '{textBox1.Text}' AND data = '{textBox2.Text}' AND pasport = '{textBox3.Text}' AND email = '{textBox4.Text}' AND number = '{textBox5.Text}' AND zagran = '{textBox6.Text}'", connection);
                        MySqlCommand command2 = new MySqlCommand($"INSERT INTO klient (name, data, pasport, email, number, zagran) VALUES (@name, @data, @pasport, @email, @number, @zagran)", connection);
                        adapter.SelectCommand = command1;
                        adapter.Fill(table);
                        if (table.Rows.Count == 0)
                        {
                            command2.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
                            command2.Parameters.Add("@data", MySqlDbType.VarChar).Value = textBox2.Text;
                            command2.Parameters.Add("@pasport", MySqlDbType.Int64).Value = textBox3.Text;
                            command2.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox4.Text;
                            command2.Parameters.Add("@number", MySqlDbType.Int64).Value = textBox5.Text;
                            command2.Parameters.Add("@zagran", MySqlDbType.Int64).Value = textBox6.Text;

                            command2.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Вы успешно зарегистрировались!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                    }
                }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
        }
    

