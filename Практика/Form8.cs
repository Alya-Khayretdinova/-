using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Практика
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=agenstvo;User ID=Alechka;Password=Alfia.2006;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                MySqlCommand command1 = new MySqlCommand($"SELECT id, nomer, srok, svv FROM oplata WHERE nomer = '{textBox1.Text}' AND srok = '{textBox2.Text}' AND svv = '{textBox3.Text}'", connection);
                MySqlCommand command2 = new MySqlCommand($"INSERT INTO oplata (nomer, srok, svv) VALUES (@nomer, @srok, @svv)", connection);
                adapter.SelectCommand = command1;
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    command2.Parameters.Add("@nomer", MySqlDbType.Int64).Value = textBox1.Text;
                    command2.Parameters.Add("@srok", MySqlDbType.VarChar).Value = textBox2.Text;
                    command2.Parameters.Add("@svv", MySqlDbType.Int64).Value = textBox3.Text;


                    command2.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Оплата прошла успешно, электронный билет поступит в течении 1-2 минут на электронную почту. Хорошего отдыха!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

