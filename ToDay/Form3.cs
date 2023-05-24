﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDay
{
    public partial class Form3 : Form
    {
        public string name;
        public string about;
        public DateTime create;
        public DateTime done_time;
        public DateTime done_date;
        public bool prioritet;
        public bool flag;

        public static Color GlobalColor { get; set; }


        public Form3(Color color)
        {
            InitializeComponent();
            GlobalColor = color;
            this.BackColor = GlobalColor;
            SelectedColor();
        }

        private void SelectedColor()
        {
            if (GlobalColor == ThemeSettings.ModerateRed)
            {
                radioButton1.ForeColor = Color.White;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == true)
            {
                button1.BackColor = Color.FromArgb(192, 255, 192);
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
                button1.BackColor = Color.FromArgb(255, 192, 192);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            about = textBox2.Text;
            create = DateTime.Now;
            done_date = monthCalendar1.SelectionRange.Start;
            prioritet = radioButton1.Checked;
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ничего не происходит
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            name = textBox1.Text;
            about = textBox2.Text;
            create = DateTime.Now;
            done_date = monthCalendar1.SelectionRange.Start;
            done_time = dateTimePicker1.Value;
            prioritet = radioButton1.Checked;
            flag = true;
            this.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            flag = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == true)
            {
                button1.BackColor = Color.FromArgb(192, 255, 192);
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
                button1.BackColor = Color.FromArgb(255, 192, 192);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
