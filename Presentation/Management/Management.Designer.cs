namespace Presentation.Management
{
    partial class Management
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
            btnAccountMgt = new Button();
            btnEmployeeMgt = new Button();
            btnWorksOnMgt = new Button();
            btnDependentMgt = new Button();
            btnProjectMgt = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAccountMgt
            // 
            btnAccountMgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccountMgt.Location = new Point(79, 96);
            btnAccountMgt.Name = "btnAccountMgt";
            btnAccountMgt.Size = new Size(277, 43);
            btnAccountMgt.TabIndex = 6;
            btnAccountMgt.Text = "Account Management";
            btnAccountMgt.UseVisualStyleBackColor = true;
            btnAccountMgt.Click += btnAccountMgt_Click;
            // 
            // btnEmployeeMgt
            // 
            btnEmployeeMgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployeeMgt.Location = new Point(79, 198);
            btnEmployeeMgt.Name = "btnEmployeeMgt";
            btnEmployeeMgt.Size = new Size(277, 43);
            btnEmployeeMgt.TabIndex = 7;
            btnEmployeeMgt.Text = "Employee Management";
            btnEmployeeMgt.UseVisualStyleBackColor = true;
            btnEmployeeMgt.Click += btnEmployeeMgt_Click;
            // 
            // btnWorksOnMgt
            // 
            btnWorksOnMgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorksOnMgt.Location = new Point(447, 302);
            btnWorksOnMgt.Name = "btnWorksOnMgt";
            btnWorksOnMgt.Size = new Size(277, 43);
            btnWorksOnMgt.TabIndex = 8;
            btnWorksOnMgt.Text = "Works On Management";
            btnWorksOnMgt.UseVisualStyleBackColor = true;
            btnWorksOnMgt.Click += btnWorksOnMgt_Click;
            // 
            // btnDependentMgt
            // 
            btnDependentMgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDependentMgt.Location = new Point(79, 302);
            btnDependentMgt.Name = "btnDependentMgt";
            btnDependentMgt.Size = new Size(277, 43);
            btnDependentMgt.TabIndex = 9;
            btnDependentMgt.Text = "Dependent Management";
            btnDependentMgt.UseVisualStyleBackColor = true;
            btnDependentMgt.Click += btnDependentMgt_Click;
            // 
            // btnProjectMgt
            // 
            btnProjectMgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProjectMgt.Location = new Point(447, 198);
            btnProjectMgt.Name = "btnProjectMgt";
            btnProjectMgt.Size = new Size(277, 43);
            btnProjectMgt.TabIndex = 10;
            btnProjectMgt.Text = "Project Management";
            btnProjectMgt.UseVisualStyleBackColor = true;
            btnProjectMgt.Click += btnProjectMgt_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(447, 96);
            button1.Name = "button1";
            button1.Size = new Size(277, 43);
            button1.TabIndex = 11;
            button1.Text = "Department Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button1);
            Controls.Add(btnProjectMgt);
            Controls.Add(btnDependentMgt);
            Controls.Add(btnWorksOnMgt);
            Controls.Add(btnEmployeeMgt);
            Controls.Add(btnAccountMgt);
            Name = "Management";
            Text = "Management";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAccountMgt;
        private Button btnEmployeeMgt;
        private Button btnWorksOnMgt;
        private Button btnDependentMgt;
        private Button btnProjectMgt;
        private Button button1;
    }
}