namespace HotelApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txt_guestPassword = new TextBox();
            txt_guestPhone_Number = new TextBox();
            txt_guestEmail = new TextBox();
            txt_guestName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(816, 11);
            button1.Name = "button1";
            button1.Size = new Size(110, 37);
            button1.TabIndex = 0;
            button1.Text = "Load Guests";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(816, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(671, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(1367, 11);
            button2.Name = "button2";
            button2.Size = new Size(120, 37);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(942, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://f.top4top.io/p_3410wcz891.png";
            pictureBox1.Location = new Point(66, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 533);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_guestPassword);
            groupBox1.Controls.Add(txt_guestPhone_Number);
            groupBox1.Controls.Add(txt_guestEmail);
            groupBox1.Controls.Add(txt_guestName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(476, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 231);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Guest";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDark;
            button3.Location = new Point(189, 181);
            button3.Name = "button3";
            button3.Size = new Size(123, 34);
            button3.TabIndex = 8;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txt_guestPassword
            // 
            txt_guestPassword.Location = new Point(139, 131);
            txt_guestPassword.Name = "txt_guestPassword";
            txt_guestPassword.Size = new Size(173, 27);
            txt_guestPassword.TabIndex = 7;
            // 
            // txt_guestPhone_Number
            // 
            txt_guestPhone_Number.Location = new Point(139, 97);
            txt_guestPhone_Number.Name = "txt_guestPhone_Number";
            txt_guestPhone_Number.Size = new Size(173, 27);
            txt_guestPhone_Number.TabIndex = 6;
            // 
            // txt_guestEmail
            // 
            txt_guestEmail.Location = new Point(139, 56);
            txt_guestEmail.Name = "txt_guestEmail";
            txt_guestEmail.Size = new Size(173, 27);
            txt_guestEmail.TabIndex = 5;
            // 
            // txt_guestName
            // 
            txt_guestName.Location = new Point(139, 23);
            txt_guestName.Name = "txt_guestName";
            txt_guestName.Size = new Size(173, 27);
            txt_guestName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Location = new Point(15, 131);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlDark;
            label3.Location = new Point(15, 97);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Location = new Point(15, 63);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(506, 298);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(818, 259);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 7;
            label5.Text = "Bookings";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(820, 298);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(661, 247);
            dataGridView2.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(1038, 259);
            button4.Name = "button4";
            button4.Size = new Size(262, 29);
            button4.TabIndex = 9;
            button4.Text = "Delete Selected Booking";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 570);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(monthCalendar1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Default";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private TextBox txt_guestPassword;
        private TextBox txt_guestPhone_Number;
        private TextBox txt_guestEmail;
        private TextBox txt_guestName;
        private Button button3;
        private Label label5;
        private DataGridView dataGridView2;
        private Button button4;
    }
}
