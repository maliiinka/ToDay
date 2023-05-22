﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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

        private void button4_Click(object sender, EventArgs e) {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void Form2_Load_1(object sender, EventArgs e) {
            string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
            NpgsqlConnection nc = new NpgsqlConnection(con);
            nc.Open();
            NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=false ", nc);
            DataSet dt = new DataSet();
            sql_tasks.Fill(dt);
            NotesDataGridView.DataSource = dt.Tables[0];
            nc.Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (NotesDataGridView.SelectedRows.Count > 0) {
                string id = NotesDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
                NpgsqlConnection nc = new NpgsqlConnection(con);


                nc.Open();
                NpgsqlDataAdapter sql_done = new NpgsqlDataAdapter($"UPDATE public.\"Task\" SET \"is_active\"= true WHERE public.\"Task\".\"task_id\"='{id}'; ", nc);
                DataSet dt = new DataSet();
                sql_done.Fill(dt);

                NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=false ", nc);


                DataSet dt_ = new DataSet();
                sql_tasks.Fill(dt_);
                NotesDataGridView.DataSource = dt_.Tables[0];
                nc.Close();


            }
        }

        private void button5_Click(object sender, EventArgs e) {

            string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
            NpgsqlConnection nc = new NpgsqlConnection(con);
            nc.Open();
            NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=true ", nc);
            DataSet dt = new DataSet();
            sql_tasks.Fill(dt);
            NotesDataGridView.DataSource = dt.Tables[0];
            nc.Close();

        }

        private void button6_Click(object sender, EventArgs e) {
            string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
            NpgsqlConnection nc = new NpgsqlConnection(con);
            nc.Open();
            NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=false ", nc);
            DataSet dt = new DataSet();
            sql_tasks.Fill(dt);
            NotesDataGridView.DataSource = dt.Tables[0];
            nc.Close();

        }

        private void CreateNewNoteButton_Click_1(object sender, EventArgs e) {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            if (form3.flag == true && form3.name != "" && form3.about != "") {
                string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
                NpgsqlConnection nc = new NpgsqlConnection(con);
                nc.Open();
                NpgsqlDataAdapter add_new_task = new NpgsqlDataAdapter($"INSERT INTO public.\"Task\"  (\"name\", \"description\", \"created_at\", \"shedule_for\", \"is_active\", \"is_priority\") VALUES (\' {form3.name} \', \' {form3.about}\', \'{form3.create}\', \'{form3.done}\',false , {form3.prioritet}) ", nc);
                DataSet dt_add = new DataSet();
                add_new_task.Fill(dt_add);

                NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=false ", nc);
                DataSet dt = new DataSet();
                sql_tasks.Fill(dt);
                NotesDataGridView.DataSource = dt.Tables[0];
                nc.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e) {
            if (NotesDataGridView.CurrentRow != null) {
                string id = NotesDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
                NpgsqlConnection nc = new NpgsqlConnection(con);
                nc.Open();
                NpgsqlDataAdapter delete_task = new NpgsqlDataAdapter($" DELETE FROM \"Task\" WHERE \"Task\".\"task_id\"={id}", nc);
                DataSet dt1 = new DataSet();
                delete_task.Fill(dt1);
                nc.Close();

                NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=false ", nc);
                DataSet dt = new DataSet();
                sql_tasks.Fill(dt);
                NotesDataGridView.DataSource = dt.Tables[0];
                nc.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e) {

           
                string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
                NpgsqlConnection nc = new NpgsqlConnection(con);
                NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"sheduled_for\"='{monthCalendar1.SelectionRange.Start}' ", nc);
                DataSet dt = new DataSet();
                sql_tasks.Fill(dt);
                NotesDataGridView.DataSource = dt.Tables[0];
                nc.Close();
          

        }

        private void button1_Click_1(object sender, EventArgs e) {
            if (monthCalendar1.Visible == true) {
                button1.BackColor = Color.FromArgb(192, 255, 192);
                monthCalendar1.Visible = false;
            }
            else {
                monthCalendar1.Visible = true;
                button1.BackColor = Color.FromArgb(255, 192, 192);
            }

        }
    }
}
