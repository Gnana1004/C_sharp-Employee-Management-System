namespace Project
{
    partial class EmployeeInfo
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1755, 99);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 23);
            label1.Name = "label1";
            label1.Size = new Size(598, 54);
            label1.TabIndex = 0;
            label1.Text = "Employee Information";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Calibri", 22F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(2, 96);
            button1.Name = "button1";
            button1.Size = new Size(1259, 61);
            button1.TabIndex = 1;
            button1.Text = "Show Employees";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-9, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1270, 522);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EmployeeInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 688);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "EmployeeInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
    }
}