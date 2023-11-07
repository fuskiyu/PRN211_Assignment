namespace Presentation.Management
{
    partial class DepartmentManagement
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
            txtDepNum = new TextBox();
            lbUserName = new Label();
            dgvInfo = new DataGridView();
            txtDepName = new TextBox();
            lbPassword = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtMgrID = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).BeginInit();
            SuspendLayout();
            // 
            // txtDepNum
            // 
            txtDepNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepNum.Location = new Point(139, 85);
            txtDepNum.Name = "txtDepNum";
            txtDepNum.Size = new Size(176, 34);
            txtDepNum.TabIndex = 3;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUserName.Location = new Point(42, 88);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(91, 28);
            lbUserName.TabIndex = 2;
            lbUserName.Text = "DepNum";
            // 
            // dgvInfo
            // 
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Location = new Point(372, 12);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.RowHeadersWidth = 51;
            dgvInfo.RowTemplate.Height = 29;
            dgvInfo.Size = new Size(416, 426);
            dgvInfo.TabIndex = 4;
            dgvInfo.CellDoubleClick += dgvInfo_CellDoubleClick;
            // 
            // txtDepName
            // 
            txtDepName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepName.Location = new Point(139, 145);
            txtDepName.Name = "txtDepName";
            txtDepName.Size = new Size(176, 34);
            txtDepName.TabIndex = 6;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(33, 148);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(100, 28);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "DepName";
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(108, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 34);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(224, 296);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 34);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtMgrID
            // 
            txtMgrID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMgrID.Location = new Point(139, 206);
            txtMgrID.Name = "txtMgrID";
            txtMgrID.Size = new Size(176, 34);
            txtMgrID.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 209);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 13;
            label1.Text = "Manager ID";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.HotTrack;
            btnCancel.Location = new Point(224, 353);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 35);
            btnCancel.TabIndex = 42;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DepartmentManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(txtMgrID);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtDepName);
            Controls.Add(lbPassword);
            Controls.Add(dgvInfo);
            Controls.Add(txtDepNum);
            Controls.Add(lbUserName);
            Name = "DepartmentManagement";
            Text = "DepartmentManagement";
            ((System.ComponentModel.ISupportInitialize)dgvInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDepNum;
        private Label lbUserName;
        private DataGridView dgvInfo;
        private TextBox txtDepName;
        private Label lbPassword;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtMgrID;
        private Label label1;
        private Button btnCancel;
    }
}