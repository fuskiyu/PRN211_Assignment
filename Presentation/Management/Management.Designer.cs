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
            SuspendLayout();
            // 
            // btnAccountMgt
            // 
            btnAccountMgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccountMgt.Location = new Point(240, 42);
            btnAccountMgt.Margin = new Padding(3, 2, 3, 2);
            btnAccountMgt.Name = "btnAccountMgt";
            btnAccountMgt.Size = new Size(242, 32);
            btnAccountMgt.TabIndex = 6;
            btnAccountMgt.Text = "Account Management";
            btnAccountMgt.UseVisualStyleBackColor = true;
            btnAccountMgt.Click += btnAccountMgt_Click;
            // 
            // btnEmployeeMgt
            // 
            btnEmployeeMgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployeeMgt.Location = new Point(240, 96);
            btnEmployeeMgt.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeMgt.Name = "btnEmployeeMgt";
            btnEmployeeMgt.Size = new Size(242, 32);
            btnEmployeeMgt.TabIndex = 7;
            btnEmployeeMgt.Text = "Employee Management";
            btnEmployeeMgt.UseVisualStyleBackColor = true;
            btnEmployeeMgt.Click += btnEmployeeMgt_Click;
            // 
            // btnWorksOnMgt
            // 
            btnWorksOnMgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorksOnMgt.Location = new Point(240, 258);
            btnWorksOnMgt.Margin = new Padding(3, 2, 3, 2);
            btnWorksOnMgt.Name = "btnWorksOnMgt";
            btnWorksOnMgt.Size = new Size(242, 32);
            btnWorksOnMgt.TabIndex = 8;
            btnWorksOnMgt.Text = "Works On Management";
            btnWorksOnMgt.UseVisualStyleBackColor = true;
            // 
            // btnDependentMgt
            // 
            btnDependentMgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDependentMgt.Location = new Point(240, 150);
            btnDependentMgt.Margin = new Padding(3, 2, 3, 2);
            btnDependentMgt.Name = "btnDependentMgt";
            btnDependentMgt.Size = new Size(242, 32);
            btnDependentMgt.TabIndex = 9;
            btnDependentMgt.Text = "Dependent Management";
            btnDependentMgt.UseVisualStyleBackColor = true;
            // 
            // btnProjectMgt
            // 
            btnProjectMgt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProjectMgt.Location = new Point(240, 204);
            btnProjectMgt.Margin = new Padding(3, 2, 3, 2);
            btnProjectMgt.Name = "btnProjectMgt";
            btnProjectMgt.Size = new Size(242, 32);
            btnProjectMgt.TabIndex = 10;
            btnProjectMgt.Text = "Project Management";
            btnProjectMgt.UseVisualStyleBackColor = true;
            btnProjectMgt.Click += btnProjectMgt_Click;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnProjectMgt);
            Controls.Add(btnDependentMgt);
            Controls.Add(btnWorksOnMgt);
            Controls.Add(btnEmployeeMgt);
            Controls.Add(btnAccountMgt);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}