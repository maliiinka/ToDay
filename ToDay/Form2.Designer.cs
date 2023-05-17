namespace ToDay {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            NotesDataGridView = new DataGridView();
            CreateNewNoteButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tb_owner = new ComboBox();
            tb_end_work = new DateTimePicker();
            tableLayoutPanel2 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            comboBox2 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            tableLayoutPanel4 = new TableLayoutPanel();
            comboBox3 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            textBox16 = new TextBox();
            textBox15 = new TextBox();
            button15 = new Button();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            comboBox4 = new ComboBox();
            dateTimePicker4 = new DateTimePicker();
            tableLayoutPanel7 = new TableLayoutPanel();
            tb_start_work = new DateTimePicker();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)NotesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.BackgroundImage = Properties.Resources.calendar__2_;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(210, 9);
            button1.Name = "button1";
            button1.Size = new Size(37, 32);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, -2);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.Visible = false;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // NotesDataGridView
            // 
            NotesDataGridView.BackgroundColor = Color.Thistle;
            NotesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotesDataGridView.Location = new Point(-4, 166);
            NotesDataGridView.Name = "NotesDataGridView";
            NotesDataGridView.RowTemplate.Height = 25;
            NotesDataGridView.Size = new Size(605, 218);
            NotesDataGridView.TabIndex = 2;
            // 
            // CreateNewNoteButton
            // 
            CreateNewNoteButton.BackColor = Color.FromArgb(192, 192, 255);
            CreateNewNoteButton.FlatStyle = FlatStyle.Popup;
            CreateNewNoteButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateNewNoteButton.Image = Properties.Resources.Add1;
            CreateNewNoteButton.Location = new Point(512, 390);
            CreateNewNoteButton.Name = "CreateNewNoteButton";
            CreateNewNoteButton.Size = new Size(40, 40);
            CreateNewNoteButton.TabIndex = 3;
            CreateNewNoteButton.UseVisualStyleBackColor = false;
            CreateNewNoteButton.Click += CreateNewNoteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 23);
            label1.TabIndex = 4;
            label1.Text = "Сегодня тот самый день!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(-4, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 173F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tb_owner, 8, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_owner
            // 
            tb_owner.DropDownStyle = ComboBoxStyle.DropDownList;
            tb_owner.FormattingEnabled = true;
            tb_owner.Items.AddRange(new object[] { "" });
            tb_owner.Location = new Point(933, 3);
            tb_owner.Name = "tb_owner";
            tb_owner.Size = new Size(229, 23);
            tb_owner.TabIndex = 9;
            // 
            // tb_end_work
            // 
            tb_end_work.Format = DateTimePickerFormat.Time;
            tb_end_work.Location = new Point(596, 3);
            tb_end_work.Name = "tb_end_work";
            tb_end_work.Size = new Size(58, 23);
            tb_end_work.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 10;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 173F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(comboBox1, 8, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "" });
            comboBox1.Location = new Point(933, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(596, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(58, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 10;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 173F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(comboBox2, 8, 0);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "" });
            comboBox2.Location = new Point(933, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(229, 23);
            comboBox2.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(596, 3);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(58, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 10;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 173F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(comboBox3, 8, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "" });
            comboBox3.Location = new Point(933, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(229, 23);
            comboBox3.TabIndex = 9;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(596, 3);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(58, 23);
            dateTimePicker3.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 10;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 173F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 66F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 64F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Controls.Add(comboBox4, 8, 0);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel6.Controls.Add(textBox16, 4, 0);
            tableLayoutPanel6.Controls.Add(textBox15, 3, 0);
            tableLayoutPanel6.Controls.Add(button15, 0, 0);
            tableLayoutPanel6.Controls.Add(textBox13, 1, 0);
            tableLayoutPanel6.Controls.Add(textBox14, 2, 0);
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(60, 37);
            tableLayoutPanel6.TabIndex = 20;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(495, 3);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(46, 23);
            textBox16.TabIndex = 5;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(340, 3);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(149, 23);
            textBox15.TabIndex = 4;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(0, 192, 0);
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.Location = new Point(3, 3);
            button15.Name = "button15";
            button15.Size = new Size(43, 31);
            button15.TabIndex = 2;
            button15.UseVisualStyleBackColor = false;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(52, 3);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(145, 23);
            textBox13.TabIndex = 3;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(203, 3);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(131, 23);
            textBox14.TabIndex = 2;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "" });
            comboBox4.Location = new Point(933, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(229, 23);
            comboBox4.TabIndex = 9;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Time;
            dateTimePicker4.Location = new Point(596, 3);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(58, 23);
            dateTimePicker4.TabIndex = 10;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel7.Controls.Add(tb_start_work, 0, 0);
            tableLayoutPanel7.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel7.Location = new Point(280, 135);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(321, 27);
            tableLayoutPanel7.TabIndex = 20;
            // 
            // tb_start_work
            // 
            tb_start_work.Format = DateTimePickerFormat.Time;
            tb_start_work.Location = new Point(3, 3);
            tb_start_work.Name = "tb_start_work";
            tb_start_work.Size = new Size(87, 23);
            tb_start_work.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 22;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(210, 68);
            button2.Name = "button2";
            button2.Size = new Size(37, 32);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(192, 192, 255);
            button3.Image = Properties.Resources.free_icon_checkbox_107585611;
            button3.Location = new Point(558, 390);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 21;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 128, 255);
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.Transparent;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(210, 128);
            button4.Name = "button4";
            button4.Size = new Size(37, 32);
            button4.TabIndex = 22;
            button4.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(602, 435);
            Controls.Add(button4);
            Controls.Add(monthCalendar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tableLayoutPanel7);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(CreateNewNoteButton);
            Controls.Add(NotesDataGridView);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)NotesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MonthCalendar monthCalendar1;
        private DataGridView NotesDataGridView;
        private Button CreateNewNoteButton;
        private Label label1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox tb_owner;
        private DateTimePicker tb_end_work;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker2;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox textBox16;
        private TextBox textBox15;
        private Button button15;
        private TextBox textBox13;
        private TextBox textBox14;
        private ComboBox comboBox4;
        private DateTimePicker dateTimePicker4;
        private TableLayoutPanel tableLayoutPanel7;
        private Button button2;
        private DateTimePicker tb_start_work;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
    }
}