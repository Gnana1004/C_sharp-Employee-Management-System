namespace Project
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1804, 93);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(397, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 63);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(592, 19);
            label1.Name = "label1";
            label1.Size = new Size(271, 54);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial Narrow", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(2, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1797, 419);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employees";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 0);
            button3.Font = new Font("Algerian", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1596, 341);
            button3.Name = "button3";
            button3.Size = new Size(180, 71);
            button3.TabIndex = 17;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 0);
            button2.Font = new Font("Algerian", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1398, 341);
            button2.Name = "button2";
            button2.Size = new Size(180, 71);
            button2.TabIndex = 16;
            button2.Text = "NEW";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 0);
            button1.Font = new Font("Algerian", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1184, 341);
            button1.Name = "button1";
            button1.Size = new Size(180, 71);
            button1.TabIndex = 15;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Icon_4;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1151, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(625, 301);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(820, 235);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(229, 40);
            textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(820, 171);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(229, 40);
            textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(820, 110);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(229, 40);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(820, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(229, 40);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(370, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 40);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(370, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 40);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(370, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 40);
            textBox1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(633, 242);
            label8.Name = "label8";
            label8.Size = new Size(94, 33);
            label8.TabIndex = 6;
            label8.Text = "Benefit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(648, 178);
            label7.Name = "label7";
            label7.Size = new Size(60, 33);
            label7.TabIndex = 5;
            label7.Text = "Dob";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(633, 119);
            label6.Name = "label6";
            label6.Size = new Size(84, 33);
            label6.TabIndex = 4;
            label6.Text = "Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(633, 55);
            label5.Name = "label5";
            label5.Size = new Size(75, 33);
            label5.TabIndex = 3;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 174);
            label4.Name = "label4";
            label4.Size = new Size(65, 33);
            label4.TabIndex = 2;
            label4.Text = "Age ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 119);
            label3.Name = "label3";
            label3.Size = new Size(192, 33);
            label3.TabIndex = 1;
            label3.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 59);
            label2.Name = "label2";
            label2.Size = new Size(38, 33);
            label2.TabIndex = 0;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(486, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 150);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 525);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1833, 315);
            dataGridView1.TabIndex = 2;
           
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1811, 675);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
    }
}