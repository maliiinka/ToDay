﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ToDay {
    public partial class Form2 : Form {

        public static Color GlobalColor { get; set; }

        public Form2() {
            InitializeComponent();
            SelectedColor();
        }

        private void button1_Click_2(object sender, EventArgs e) {
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



        private void CreateNewNoteButton_Click(object sender, EventArgs e) {
            if (GlobalColor == ThemeSettings.Purple) {
                GlobalColor = Color.FromArgb(128, 128, 255);
                Form3 form3 = new Form3(GlobalColor);
                form3.ShowDialog();
                if (form3.flag == true && form3.name != "" && form3.about != "") {
                    string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
                    NpgsqlConnection nc = new NpgsqlConnection(con);
                    nc.Open();
                    NpgsqlDataAdapter add_new_task = new NpgsqlDataAdapter($"INSERT INTO public.\"Task\"  (\"name\", \"description\", \"created_at\",  \"is_active\", \"is_priority\" , \"done_date\", \"done_time\") VALUES (\' {form3.name} \', \' {form3.about}\', \'{form3.create}\', false , {form3.prioritet}, \'{form3.done_date}\', \'{form3.done_time}\') ", nc);
                    DataSet dt_add = new DataSet();
                    add_new_task.Fill(dt_add);

                    NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=false ", nc);
                    DataSet dt = new DataSet();
                    sql_tasks.Fill(dt);
                    NotesDataGridView.DataSource = dt.Tables[0];
                    nc.Close();
                }

            }
            else {
                Form3 form3 = new Form3(GlobalColor);
                form3.ShowDialog();
                if (form3.flag == true && form3.name != "" && form3.about != "") {
                    string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
                    NpgsqlConnection nc = new NpgsqlConnection(con);
                    nc.Open();
                    NpgsqlDataAdapter add_new_task = new NpgsqlDataAdapter($"INSERT INTO public.\"Task\"  (\"name\", \"description\", \"created_at\",  \"is_active\", \"is_priority\" , \"done_date\", \"done_time\") VALUES (\' {form3.name} \', \' {form3.about}\', \'{form3.create}\', false , {form3.prioritet}, \'{form3.done_date}\', \'{form3.done_time}\') ", nc);
                    DataSet dt_add = new DataSet();
                    add_new_task.Fill(dt_add);

                    NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=false ", nc);
                    DataSet dt = new DataSet();
                    sql_tasks.Fill(dt);
                    NotesDataGridView.DataSource = dt.Tables[0];
                    nc.Close();
                }
            }


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

            var timer = new System.Timers.Timer();

            // Устанавливаем интервал таймера в миллисекундах (например, каждые 5 минут)
            timer.Interval = 10 * 1000;


            // Устанавливаем обработчик события Elapsed (срабатывает каждый раз по истечении интервала)
            timer.Elapsed += OnTimerElapsed;

            // Запускаем таймер
            timer.Start();
        }

        private void button3_Click_1(object sender, EventArgs e) {
            if (NotesDataGridView.SelectedRows.Count > 0) {
                string id = NotesDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
                NpgsqlConnection nc = new NpgsqlConnection(con);


                nc.Open();
                NpgsqlDataAdapter sql_done = new NpgsqlDataAdapter($"UPDATE public.\"Task\" SET \"is_active\"= true WHERE public.\"Task\".\"task_id\"={id}; ", nc);
                DataSet dt = new DataSet();
                sql_done.Fill(dt);
                NpgsqlCommand sql_search_date = new NpgsqlCommand($"SELECT \"Task\".\"done_date\" FROM \"Task\" WHERE public.\"Task\".\"task_id\"='{id}'", nc);
                string date=(sql_search_date.ExecuteScalar()).ToString();
                try {
                    NpgsqlDataAdapter sql_effic = new NpgsqlDataAdapter($"UPDATE public.\"Efficiency\" SET \"completed_tasks\"=\"completed_tasks\"+1  WHERE public.\"Efficiency\".\"day\"=\'{date}\'; ", nc);
                    DataSet dt1 = new DataSet();
                    sql_effic.Fill(dt1);
                }
                catch (Exception ex) {
                    NpgsqlDataAdapter sql_new_effic = new NpgsqlDataAdapter($"INSERT INTO public.\"Efficiency\" VALUES (\'{date}\', 1; ", nc);


                }




                NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=false ", nc);


                DataSet dt_ = new DataSet();
                sql_tasks.Fill(dt_);
                NotesDataGridView.DataSource = dt_.Tables[0];
                nc.Close();


            }
        }

        private void button5_Click_1(object sender, EventArgs e) {

            string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
            NpgsqlConnection nc = new NpgsqlConnection(con);
            nc.Open();
            NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=true ", nc);
            DataSet dt = new DataSet();
            sql_tasks.Fill(dt);
            NotesDataGridView.DataSource = dt.Tables[0];
            nc.Close();

        }

        private void button6_Click_1(object sender, EventArgs e) {
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
            /*            Form3 form3 = new Form3(GlobalColor);
                        form3.ShowDialog();
                        if (form3.flag == true && form3.name != "" && form3.about != "")
                        {
                            string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
                            NpgsqlConnection nc = new NpgsqlConnection(con);
                            nc.Open();
                            NpgsqlDataAdapter add_new_task = new NpgsqlDataAdapter($"INSERT INTO public.\"Task\"  (\"name\", \"description\", \"created_at\",  \"is_active\", \"is_priority\" , \"done_date\", \"done_time\") VALUES (\' {form3.name} \', \' {form3.about}\', \'{form3.create}\', false , {form3.prioritet}, \'{form3.done_date}\', \'{form3.done_time}\') ", nc);
                            DataSet dt_add = new DataSet();
                            add_new_task.Fill(dt_add);

                            NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"is_active\"=false ", nc);
                            DataSet dt = new DataSet();
                            sql_tasks.Fill(dt);
                            NotesDataGridView.DataSource = dt.Tables[0];
                            nc.Close();
                        }*/
        }

        private void button7_Click(object sender, EventArgs e) {
            /*if (NotesDataGridView.CurrentRow != null)
            {
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

            }*/
        }

        private void button2_Click_1(object sender, EventArgs e) {

            string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
            NpgsqlConnection nc = new NpgsqlConnection(con);
            NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"done_date\"='{monthCalendar1.SelectionRange.Start}' ", nc);
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
        // Создаем таймер

        private void timer1_Tick(object sender, EventArgs e) {

        }
        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
            NpgsqlConnection nc = new NpgsqlConnection(con);
            nc.Open();
            int time = DateTime.Now.Hour;

            NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT \"Task\".\"name\"  FROM \"Task\" WHERE \"is_active\" = false AND \"is_priority\" = true AND \"done_time\" =\'{DateTime.Now.Hour}:{DateTime.Now.Minute}:00\' AND \"done_date\" ='{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day}'", nc);

            try {
                DataTable dt = new DataTable();
                sql_tasks.Fill(dt);

                List<string> list = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++) {
                    foreach (var item in dt.Rows[i].ItemArray) {
                        list.Add(item.ToString());
                    }
                }

                list.ToArray();


                for (int i = 0; i < list.Count; i++) {
                    notifyIcon1.Icon = SystemIcons.Information;
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipTitle = "Время выполнять задачу";
                    notifyIcon1.BalloonTipText = list[i];  //---ячейка заголовка заметки---;
                    notifyIcon1.ShowBalloonTip(100);
                }



            }
            catch (Exception ex) {
                Console.WriteLine("Произошло исключение: " + ex.Message);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Color otherColor = Color.FromArgb(192, 192, 255); // -- цвет для отличающихся элементов
            Color foreColor = Color.Black; // -- цвет шрифта 

            if (radioButton1.Checked) {
                this.BackColor = ThemeSettings.Purple;
                GlobalColor = this.BackColor;

                SetTheme(this, GlobalColor);

                button1.BackColor = otherColor;
                button2.BackColor = otherColor;
                button3.BackColor = otherColor;
                button5.BackColor = otherColor;
                button6.BackColor = otherColor;
                button7.BackColor = otherColor;
                CreateNewNoteButton.BackColor = otherColor;
                button4.BackColor = otherColor;
                label1.ForeColor = foreColor;
                radioButton1.ForeColor = foreColor;
                radioButton1.ForeColor = foreColor;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Color otherColor = Color.FromArgb(100, 120, 255); // -- цвет для отличающихся элементов
            Color foreColor = Color.White; // -- цвет шрифта 


            if (radioButton2.Checked) {
                this.BackColor = ThemeSettings.ModerateRed;
                GlobalColor = this.BackColor;

                SetTheme(this, GlobalColor);

                button1.BackColor = otherColor;
                button2.BackColor = otherColor;
                button3.BackColor = otherColor;
                button5.BackColor = otherColor;
                button6.BackColor = otherColor;
                button7.BackColor = otherColor;
                CreateNewNoteButton.BackColor = otherColor;
                button4.BackColor = otherColor;
                label1.ForeColor = foreColor;
                radioButton1.ForeColor = foreColor;
                radioButton1.ForeColor = foreColor;
            }
        }

        public void SetTheme(Control control, Color backColor) {
            control.BackColor = backColor;

            foreach (Control childControl in control.Controls) {
                SetTheme(childControl, backColor);
            }
        }

        public void SelectedColor() {
            Color color = this.BackColor;

            if (color == ThemeSettings.Purple) {
                radioButton1.Checked = true;
            }
            else {
                radioButton2.Checked = true;
            }
        }

        private void button7_Click_1(object sender, EventArgs e) {
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

        private void Form2_Load_2(object sender, EventArgs e) {
            string con = "Host=localhost;Username=toDay;Password=toDay;Database=toDay";
            NpgsqlConnection nc = new NpgsqlConnection(con);
            nc.Open();
            NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT \"Task\".\"task_id\", \"Task\".\"name\", \"Task\".\"description\", \"Task\".\"is_active\",\"Task\".\"is_priority\", \"Task\".\"done_date\",\"Task\".\"done_time\" FROM \"Task\" WHERE public.\"Task\".\"is_active\"=false ", nc);
            DataSet dt = new DataSet();
            sql_tasks.Fill(dt);
            NotesDataGridView.DataSource = dt.Tables[0];
            NotesDataGridView.Columns[0].Width = 0;
            NotesDataGridView.Columns[1].Width = 200;
            NotesDataGridView.Columns[2].Width = 300;
            NotesDataGridView.Columns[1].HeaderText = "Название";
            NotesDataGridView.Columns[2].HeaderText = "Комментарий";
            NotesDataGridView.Columns[3].HeaderText = "Выполнено";
            NotesDataGridView.Columns[4].HeaderText = "Уведом.";
            NotesDataGridView.Columns[5].HeaderText = "Дата";
            NotesDataGridView.Columns[6].HeaderText = "Время";

            nc.Close();

            var timer = new System.Timers.Timer();

            // Устанавливаем интервал таймера в миллисекундах (например, каждые 5 минут)
            timer.Interval = 10 * 1000;


            // Устанавливаем обработчик события Elapsed (срабатывает каждый раз по истечении интервала)
            timer.Elapsed += OnTimerElapsed;

            // Запускаем таймер
            timer.Start();
        }





        private void NotesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }





    }
}
