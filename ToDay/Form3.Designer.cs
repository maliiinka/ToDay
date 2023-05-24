namespace ToDay
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            monthCalendar1 = new MonthCalendar();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Lavender;
            label2.Location = new Point(192, 21);
            label2.Name = "label2";
            label2.Size = new Size(290, 22);
            label2.TabIndex = 6;
            label2.Text = "Время добавить новую задачу!";
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = Properties.Resources.cancel;
            button3.Location = new Point(456, 192);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.BackgroundImage = Properties.Resources.calendar__2_;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(68, 189);
            button1.Name = "button1";
            button1.Size = new Size(44, 35);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Lavender;
            label5.Location = new Point(14, 200);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 5;
            label5.Text = "Дата:";
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.Add;
            button2.Location = new Point(415, 192);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.FromArgb(192, 192, 255);
            monthCalendar1.Location = new Point(18, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            monthCalendar1.TitleForeColor = Color.White;
            monthCalendar1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 192, 255);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(192, 93);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Комментарии";
            textBox2.Size = new Size(299, 90);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(192, 192, 255);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(192, 64);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Название";
            textBox1.Size = new Size(299, 23);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(14, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(299, 201);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Напоминть?";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(192, 199);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(70, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(134, 200);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 13;
            label1.Text = "Время:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(494, 234);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton1);
            Controls.Add(monthCalendar1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button1;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}