using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace Практика
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Equals("")))
                MessageBox.Show("Вы не ввели все необходимые данные!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if ((textBox1.Text.Equals("434"))) //много повторяющихся строк кода при проверке значений textBox1. 
            Это можно оптимизировать с помощью коллекции (например, массива или списка), чтобы избежать дублирования.
            {
                Form9 form9 = new Form9();
                form9.Show();
                this.Hide();
            }
            if ((textBox1.Text.Equals("900")))
            {
                Form9 form9 = new Form9();
                form9.Show();
                this.Hide();
            }
            if ((textBox1.Text.Equals("987")))
            {
                Form9 form9 = new Form9();
                form9.Show();
                this.Hide();
            }
            if ((textBox1.Text.Equals("123")))
            {
                Form9 form9 = new Form9();
                form9.Show();
                this.Hide();
            }
            if ((textBox1.Text.Equals("567")))
            {
                Form9 form9 = new Form9 ();
                form9.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
}
    

