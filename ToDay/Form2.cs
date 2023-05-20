﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDay {
    public partial class Form2 : Form {
        public Form2() {
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

        private void Form2_Load(object sender, EventArgs e) {

        }

        private void CreateNewNoteButton_Click(object sender, EventArgs e) {
            Form3 form = new Form3();
            form.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
