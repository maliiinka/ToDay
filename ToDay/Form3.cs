using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDay {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (monthCalendar1.Visible == true) {
                button1.BackColor = Color.FromArgb(192, 255, 192);
                monthCalendar1.Visible = false;
            }
            else {
                monthCalendar1.Visible = true;
                button1.BackColor = Color.FromArgb(255, 192, 192);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            //добавляем заметку в БД
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e) {
            //ничего не происходит
            this.Close();
        }
    }
}
