using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Практика
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            InitializeConnection();
        }
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private void InitializeConnection()
        {
            server = "localhost";
            database = "agenstvo";
            uid = "Alechka";
            password = "Alfia.2006";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
            LoadData1();
            LoadData2();
            LoadData3();
        }
        private void LoadData1()
        {
            string connectionString = "Server=localhost;Database=agenstvo;User ID=Alechka;Password=Alfia.2006;"; 
            //Создание соединения с базой данных повторяется в нескольких методах.
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                {
                    connection.Open();
                    string query = "SELECT * FROM klient";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Устанавливаем источник данных
                }


            }
        }
        private void LoadData2()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Height = 70;
            }
            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tour", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            finally
            {
                connection.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string name = textBox8.Text;
            string op = textBox7.Text;
            string money = textBox6.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(op) || string.IsNullOrWhiteSpace(money))
            {
                MessageBox.Show("Введите данные.");
                return;
            }
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tour (name, op, money) VALUES (@name, @op, @money)", connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@op", op);
                cmd.Parameters.AddWithValue("@money", money);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
                LoadData2();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int Id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ID"].Value);

                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM tour WHERE ID = @ID", connection);
                    cmd.Parameters.AddWithValue("@ID", Id);
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                    LoadData2();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для удаления.");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agenstvoDataSet4.oplata". При необходимости она может быть перемещена или удалена.
            this.oplataTableAdapter1.Fill(this.agenstvoDataSet4.oplata);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "agenstvoDataSet3.oplata". При необходимости она может быть перемещена или удалена.
            this.oplataTableAdapter.Fill(this.agenstvoDataSet3.oplata);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void LoadData3()
        {
            string connectionString = "Server=localhost;Database=agenstvo;User ID=Alechka;Password=Alfia.2006;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                {
                    connection.Open();
                    string query = "SELECT * FROM oplata";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView3.DataSource = dataTable; // Устанавливаем источник данных
                }


            }
        }
    } }
    
    







