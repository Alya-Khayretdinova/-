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
    public partial class Form12 : Form
    {
        // Занятые даты (пример)
        private List<DateTime> bookedDates = new List<DateTime>
        {
            new DateTime(2024, 10, 15),
            new DateTime(2024, 10, 20),
            new DateTime(2024, 10, 17),
            new DateTime(2024, 10, 26),
            new DateTime(2024, 10, 29),
            new DateTime(2024, 11, 01),
            new DateTime(2024, 11, 08),
            new DateTime(2024, 11, 11),
            new DateTime(2024, 11, 13),
            new DateTime(2024, 11, 1),
            new DateTime(2024, 12, 15),
            new DateTime(2024, 12, 17),
            new DateTime(2024, 12, 19),
            new DateTime(2024, 12, 26),
            new DateTime(2024, 12, 28),
            new DateTime(2024, 1, 1),

        };
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;

            if (IsDateAvailable(selectedDate))
            {
                Form7 form7 = new Form7();
                form7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Дата {selectedDate.ToShortDateString()} уже занята.", "Недоступно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool IsDateAvailable(DateTime date)
        {
            return !bookedDates.Contains(date.Date);
        }
    

        private void button1_Click(object sender, EventArgs e)
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
