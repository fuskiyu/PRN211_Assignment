namespace Presentation.Management
{
    partial class ProjectManagement
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProName = new TextBox();
            txtProDepa = new TextBox();
            txtProLoc = new TextBox();
            button1 = new Button();
            label4 = new Label();
            txtProNum = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(462, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(655, 570);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 120);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 1;
            label1.Text = "Project Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 197);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 2;
            label2.Text = "Project Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 269);
            label3.Name = "label3";
            label3.Size = new Size(153, 28);
            label3.TabIndex = 3;
            label3.Text = "Project Location";
            // 
            // txtProName
            // 
            txtProName.Location = new Point(253, 120);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(153, 23);
            txtProName.TabIndex = 4;
            // 
            // txtProDepa
            // 
            txtProDepa.Location = new Point(253, 197);
            txtProDepa.Name = "txtProDepa";
            txtProDepa.Size = new Size(153, 23);
            txtProDepa.TabIndex = 5;
            // 
            // txtProLoc
            // 
            txtProLoc.Location = new Point(253, 269);
            txtProLoc.Name = "txtProLoc";
            txtProLoc.Size = new Size(153, 23);
            txtProLoc.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(36, 391);
            button1.Name = "button1";
            button1.Size = new Size(87, 39);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddProject;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 51);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 8;
            label4.Text = "Project Number";
            // 
            // txtProNum
            // 
            txtProNum.Location = new Point(253, 51);
            txtProNum.Name = "txtProNum";
            txtProNum.Size = new Size(153, 23);
            txtProNum.TabIndex = 9;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(178, 391);
            button2.Name = "button2";
            button2.Size = new Size(87, 39);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += UpdateProject;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(319, 391);
            button3.Name = "button3";
            button3.Size = new Size(87, 39);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DeleteProject;
            // 
            // ProjectManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 594);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtProNum);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtProLoc);
            Controls.Add(txtProDepa);
            Controls.Add(txtProName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ProjectManagement";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProName;
        private TextBox txtProDepa;
        private TextBox txtProLoc;
        private Button button1;
        private Label label4;
        private TextBox txtProNum;
        private Button button2;
        private Button button3;
    }
}