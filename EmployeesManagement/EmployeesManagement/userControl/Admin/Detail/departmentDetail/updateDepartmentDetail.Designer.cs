namespace EmployeesManagement.userControl.Detail.departmentDetail
{
    partial class updateDepartmentDetail
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
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnComfirm = new Button();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(405, 55);
            label1.TabIndex = 10;
            label1.Text = "Update Department";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 322);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 17;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 228);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 16;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 15;
            label2.Text = "Name:";
            // 
            // btnComfirm
            // 
            btnComfirm.Cursor = Cursors.Hand;
            btnComfirm.Location = new Point(142, 396);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(94, 29);
            btnComfirm.TabIndex = 14;
            btnComfirm.Text = "Comfirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = SystemColors.InfoText;
            txtAddress.Location = new Point(121, 308);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(205, 34);
            txtAddress.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.ForeColor = SystemColors.InfoText;
            txtPhone.Location = new Point(121, 218);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(205, 34);
            txtPhone.TabIndex = 12;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InfoText;
            txtName.Location = new Point(121, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 34);
            txtName.TabIndex = 11;
            // 
            // updateDepartmentDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 486);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnComfirm);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Name = "updateDepartmentDetail";
            Text = "updateDepartmentDetail";
            Load += updateDepartmentDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnComfirm;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtName;
    }
}