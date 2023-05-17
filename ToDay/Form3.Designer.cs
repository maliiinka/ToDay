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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 41);
            label1.TabIndex = 5;
            label1.Text = "ToDay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(117, 134);
            label2.Name = "label2";
            label2.Size = new Size(190, 22);
            label2.TabIndex = 6;
            label2.Text = "Добавление заметки";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(37, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 406);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.BackgroundImage = Properties.Resources.calendar__2_;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(113, 241);
            button1.Name = "button1";
            button1.Size = new Size(44, 35);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(45, 247);
            label5.Name = "label5";
            label5.Size = new Size(48, 18);
            label5.TabIndex = 5;
            label5.Text = "Дата:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(95, 96);
            label4.Name = "label4";
            label4.Size = new Size(176, 18);
            label4.TabIndex = 4;
            label4.Text = "Введите текст заметки";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.Thistle;
            monthCalendar1.Location = new Point(185, 244);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            monthCalendar1.Visible = false;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Thistle;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(3, 120);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 87);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Thistle;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(152, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 37);
            label3.Name = "label3";
            label3.Size = new Size(152, 18);
            label3.TabIndex = 0;
            label3.Text = "Введите заголовок:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 314);
            label6.Name = "label6";
            label6.Size = new Size(120, 18);
            label6.TabIndex = 7;
            label6.Text = "Напомнить за: ";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Thistle;
            comboBox1.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Час", "Неделю", "Месяц" });
            comboBox1.Location = new Point(145, 315);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 21);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "нет";
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(37, 626);
            button2.Name = "button2";
            button2.Size = new Size(159, 39);
            button2.TabIndex = 8;
            button2.Text = "Создать";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(306, 639);
            button3.Name = "button3";
            button3.Size = new Size(80, 26);
            button3.TabIndex = 9;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(424, 699);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private MonthCalendar monthCalendar1;
        private ComboBox comboBox1;
        private Label label6;
        private Button button2;
        private Button button3;
    }
}