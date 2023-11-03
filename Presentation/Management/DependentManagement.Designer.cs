namespace Presentation.Management
{
    partial class DependentManagement
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
            txtdepName = new TextBox();
            lbdepName = new Label();
            dgvInfor = new DataGridView();
            btnAdd = new Button();
            txtempSSN = new TextBox();
            lbempSSN = new Label();
            lbdepSex = new Label();
            lbdepBirthDate = new Label();
            label5 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            cbdepSex = new ComboBox();
            dtpBirthDate = new DateTimePicker();
            cbdepRelationship = new ComboBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInfor).BeginInit();
            SuspendLayout();
            // 
            // txtdepName
            // 
            txtdepName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdepName.Location = new Point(256, 113);
            txtdepName.Name = "txtdepName";
            txtdepName.Size = new Size(269, 39);
            txtdepName.TabIndex = 0;
            // 
            // lbdepName
            // 
            lbdepName.AutoSize = true;
            lbdepName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbdepName.Location = new Point(28, 113);
            lbdepName.Name = "lbdepName";
            lbdepName.Size = new Size(205, 32);
            lbdepName.TabIndex = 1;
            lbdepName.Text = "Dependent Name";
            // 
            // dgvInfor
            // 
            dgvInfor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfor.Location = new Point(566, 21);
            dgvInfor.Name = "dgvInfor";
            dgvInfor.RowHeadersWidth = 62;
            dgvInfor.RowTemplate.Height = 33;
            dgvInfor.Size = new Size(814, 506);
            dgvInfor.TabIndex = 2;
            dgvInfor.CellContentClick += dgvInfor_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(119, 385);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(157, 50);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtempSSN
            // 
            txtempSSN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtempSSN.Location = new Point(256, 53);
            txtempSSN.Name = "txtempSSN";
            txtempSSN.Size = new Size(269, 39);
            txtempSSN.TabIndex = 4;
            // 
            // lbempSSN
            // 
            lbempSSN.AutoSize = true;
            lbempSSN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbempSSN.Location = new Point(84, 53);
            lbempSSN.Name = "lbempSSN";
            lbempSSN.Size = new Size(149, 32);
            lbempSSN.TabIndex = 8;
            lbempSSN.Text = "Employee ID";
            // 
            // lbdepSex
            // 
            lbdepSex.AutoSize = true;
            lbdepSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbdepSex.Location = new Point(141, 181);
            lbdepSex.Name = "lbdepSex";
            lbdepSex.Size = new Size(92, 32);
            lbdepSex.TabIndex = 9;
            lbdepSex.Text = "Gender";
            // 
            // lbdepBirthDate
            // 
            lbdepBirthDate.AutoSize = true;
            lbdepBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbdepBirthDate.Location = new Point(119, 244);
            lbdepBirthDate.Name = "lbdepBirthDate";
            lbdepBirthDate.Size = new Size(114, 32);
            lbdepBirthDate.TabIndex = 10;
            lbdepBirthDate.Text = "BirthDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(89, 308);
            label5.Name = "label5";
            label5.Size = new Size(144, 32);
            label5.TabIndex = 11;
            label5.Text = "Relationship";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(368, 385);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 50);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(119, 477);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(157, 50);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbdepSex
            // 
            cbdepSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbdepSex.FormattingEnabled = true;
            cbdepSex.Location = new Point(256, 178);
            cbdepSex.Name = "cbdepSex";
            cbdepSex.Size = new Size(269, 40);
            cbdepSex.TabIndex = 15;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "yyyy/MM/dd";
            dtpBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(256, 244);
            dtpBirthDate.Margin = new Padding(4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(269, 39);
            dtpBirthDate.TabIndex = 32;
            // 
            // cbdepRelationship
            // 
            cbdepRelationship.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbdepRelationship.FormattingEnabled = true;
            cbdepRelationship.Location = new Point(256, 305);
            cbdepRelationship.Name = "cbdepRelationship";
            cbdepRelationship.Size = new Size(269, 40);
            cbdepRelationship.TabIndex = 33;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(368, 477);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(157, 50);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DependentManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 573);
            Controls.Add(btnCancel);
            Controls.Add(cbdepRelationship);
            Controls.Add(dtpBirthDate);
            Controls.Add(cbdepSex);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(lbdepBirthDate);
            Controls.Add(lbdepSex);
            Controls.Add(lbempSSN);
            Controls.Add(txtempSSN);
            Controls.Add(btnAdd);
            Controls.Add(dgvInfor);
            Controls.Add(lbdepName);
            Controls.Add(txtdepName);
            Name = "DependentManagement";
            Text = "DependentManagement";
            ((System.ComponentModel.ISupportInitialize)dgvInfor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtdepName;
        private Label lbdepName;
        private DataGridView dgvInfor;
        private Button btnAdd;
        private TextBox txtempSSN;
        private TextBox textBox3;
        private Label lbempSSN;
        private Label lbdepSex;
        private Label lbdepBirthDate;
        private Label label5;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cbdepSex;
        private DateTimePicker dtpBirthDate;
        private ComboBox cbdepRelationship;
        private Button btnCancel;
    }
}