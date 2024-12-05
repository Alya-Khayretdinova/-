using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Практика
{
    public partial class Form1 : Form //Названия форм неинформативны. Лучше использовать более описательные имена, чтобы было понятно, за что отвечает каждая форма.
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); 
            form4.Show();             
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); 
            form5.Show();              
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static implicit operator Form1(Form4 v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Form1(Form5 v)
        {
            throw new NotImplementedException();
        }
    }
}
