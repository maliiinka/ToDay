using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"В процессе\"=true ", nc);
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
                NpgsqlDataAdapter sql_done = new NpgsqlDataAdapter($"UPDATE public.\"Task\" SET \"Выполнена\"= true WHERE public.\"Task\".\"Код задачи\"='{id}'; ", nc);
                DataSet dt = new DataSet();
                sql_done.Fill(dt);

                NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"Выполнена\"=false ", nc);
                

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
            NpgsqlDataAdapter sql_tasks = new NpgsqlDataAdapter($"SELECT * FROM \"Task\" WHERE public.\"Task\".\"Выполнена\"=true ", nc);
            DataSet dt = new DataSet();
            sql_tasks.Fill(dt);
            NotesDataGridView.DataSource = dt.Tables[0];
            nc.Close();

        }
    }
}
