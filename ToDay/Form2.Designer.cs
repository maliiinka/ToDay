namespace ToDay
{
    partial class Form2
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
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            NotesDataGridView = new DataGridView();
            CreateNewNoteButton = new Button();
            label1 = new Label();
            ViewCompletedNotesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)NotesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.BackgroundImage = Properties.Resources.calendar__2_;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(22, 12);
            button1.Name = "button1";
            button1.Size = new Size(37, 36);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 49);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.Visible = false;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // NotesDataGridView
            // 
            NotesDataGridView.BackgroundColor = Color.Thistle;
            NotesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotesDataGridView.Location = new Point(22, 210);
            NotesDataGridView.Name = "NotesDataGridView";
            NotesDataGridView.RowTemplate.Height = 25;
            NotesDataGridView.Size = new Size(379, 368);
            NotesDataGridView.TabIndex = 2;
            // 
            // CreateNewNoteButton
            // 
            CreateNewNoteButton.BackColor = Color.FromArgb(192, 255, 192);
            CreateNewNoteButton.FlatStyle = FlatStyle.Popup;
            CreateNewNoteButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CreateNewNoteButton.Location = new Point(100, 645);
            CreateNewNoteButton.Name = "CreateNewNoteButton";
            CreateNewNoteButton.Size = new Size(230, 33);
            CreateNewNoteButton.TabIndex = 3;
            CreateNewNoteButton.Text = "Создать заметку";
            CreateNewNoteButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 12);
            label1.Name = "label1";
            label1.Size = new Size(131, 41);
            label1.TabIndex = 4;
            label1.Text = "ToDay";
            // 
            // ViewCompletedNotesButton
            // 
            ViewCompletedNotesButton.BackColor = Color.RosyBrown;
            ViewCompletedNotesButton.FlatStyle = FlatStyle.Popup;
            ViewCompletedNotesButton.Location = new Point(228, 584);
            ViewCompletedNotesButton.Name = "ViewCompletedNotesButton";
            ViewCompletedNotesButton.Size = new Size(173, 23);
            ViewCompletedNotesButton.TabIndex = 5;
            ViewCompletedNotesButton.Text = "просмотреть завершённые";
            ViewCompletedNotesButton.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(424, 699);
            Controls.Add(ViewCompletedNotesButton);
            Controls.Add(label1);
            Controls.Add(CreateNewNoteButton);
            Controls.Add(NotesDataGridView);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)NotesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MonthCalendar monthCalendar1;
        private DataGridView NotesDataGridView;
        private Button CreateNewNoteButton;
        private Label label1;
        private Button ViewCompletedNotesButton;
    }
}