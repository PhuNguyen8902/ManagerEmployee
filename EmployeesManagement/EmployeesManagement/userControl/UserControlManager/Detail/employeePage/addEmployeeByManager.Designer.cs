namespace EmployeesManagement.userControl.UserControlManager.Detail.employeePage
{
    partial class addEmployeeByManager
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
            cbSalary = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnComfirm = new Button();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtHometown = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbSalary);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnComfirm);
            panel1.Controls.Add(rbFemale);
            panel1.Controls.Add(rbMale);
            panel1.Controls.Add(txtHometown);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 375);
            panel1.TabIndex = 4;
            // 
            // cbSalary
            // 
            cbSalary.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbSalary.FormattingEnabled = true;
            cbSalary.Location = new Point(121, 230);
            cbSalary.Name = "cbSalary";
            cbSalary.Size = new Size(205, 31);
            cbSalary.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 235);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 12;
            label7.Text = "Salary:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 123);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 178);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 9;
            label4.Text = "Hometown:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 81);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 31);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 7;
            label2.Text = "Name:";
            // 
            // btnComfirm
            // 
            btnComfirm.Cursor = Cursors.Hand;
            btnComfirm.Location = new Point(151, 314);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(94, 29);
            btnComfirm.TabIndex = 6;
            btnComfirm.Text = "Comfirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(248, 121);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 5;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Location = new Point(121, 121);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 4;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtHometown
            // 
            txtHometown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHometown.ForeColor = SystemColors.InfoText;
            txtHometown.Location = new Point(121, 168);
            txtHometown.Name = "txtHometown";
            txtHometown.Size = new Size(205, 34);
            txtHometown.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.ForeColor = SystemColors.InfoText;
            txtPhone.Location = new Point(121, 71);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(205, 34);
            txtPhone.TabIndex = 2;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.InfoText;
            txtName.Location = new Point(121, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 34);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(406, 55);
            label1.TabIndex = 3;
            label1.Text = "Add Employee to Department";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addEmployeeByManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 430);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "addEmployeeByManager";
            Text = "addEmployeeByManager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbSalary;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnComfirm;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtHometown;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label label1;
    }
}