namespace EmployeesManagement
{
    partial class createAccount
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            backBtn = new Button();
            panel6 = new Panel();
            cbType = new ComboBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            panel5 = new Panel();
            txtEmail = new TextBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            txtFullName = new TextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            createAccountBtn = new Button();
            panel4 = new Panel();
            txtPassword = new TextBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            panel = new Panel();
            txtUsername = new TextBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 450);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(101, 398);
            label4.Name = "label4";
            label4.Size = new Size(235, 28);
            label4.TabIndex = 3;
            label4.Text = "Develop By Phan and Phu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(215, 279);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 2;
            label3.Text = "System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(34, 238);
            label2.Name = "label2";
            label2.Size = new Size(267, 31);
            label2.TabIndex = 1;
            label2.Text = "Employees Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(50, 197);
            label1.Name = "label1";
            label1.Size = new Size(251, 31);
            label1.TabIndex = 0;
            label1.Text = "Create Account For The";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Teal;
            iconPictureBox1.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            iconPictureBox1.IconColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 139;
            iconPictureBox1.Location = new Point(93, 34);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(157, 139);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(backBtn);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(createAccountBtn);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(342, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 450);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Teal;
            backBtn.Cursor = Cursors.Hand;
            backBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backBtn.ForeColor = SystemColors.ControlLightLight;
            backBtn.Location = new Point(375, 391);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(71, 47);
            backBtn.TabIndex = 7;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += button1_Click_1;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(cbType);
            panel6.Controls.Add(iconPictureBox6);
            panel6.Location = new Point(29, 331);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 43);
            panel6.TabIndex = 5;
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(49, 10);
            cbType.Name = "cbType";
            cbType.Size = new Size(336, 31);
            cbType.TabIndex = 5;
            cbType.Text = "Select type";
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = SystemColors.ControlLightLight;
            iconPictureBox6.ForeColor = Color.Teal;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Tools;
            iconPictureBox6.IconColor = Color.Teal;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 40;
            iconPictureBox6.Location = new Point(3, 4);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(40, 40);
            iconPictureBox6.TabIndex = 0;
            iconPictureBox6.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(txtEmail);
            panel5.Controls.Add(iconPictureBox5);
            panel5.Location = new Point(29, 273);
            panel5.Name = "panel5";
            panel5.Size = new Size(386, 43);
            panel5.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(49, 13);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 23);
            txtEmail.TabIndex = 4;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = SystemColors.ControlLightLight;
            iconPictureBox5.ForeColor = Color.Teal;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            iconPictureBox5.IconColor = Color.Teal;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 40;
            iconPictureBox5.Location = new Point(3, 4);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(40, 40);
            iconPictureBox5.TabIndex = 0;
            iconPictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(txtFullName);
            panel3.Controls.Add(iconPictureBox4);
            panel3.Location = new Point(28, 212);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 43);
            panel3.TabIndex = 3;
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(49, 13);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(304, 23);
            txtFullName.TabIndex = 3;
            txtFullName.Enter += txtFullName_Enter;
            txtFullName.Leave += txtFullName_Leave;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = SystemColors.ControlLightLight;
            iconPictureBox4.ForeColor = Color.Teal;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            iconPictureBox4.IconColor = Color.Teal;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 40;
            iconPictureBox4.Location = new Point(3, 4);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(40, 40);
            iconPictureBox4.TabIndex = 0;
            iconPictureBox4.TabStop = false;
            // 
            // createAccountBtn
            // 
            createAccountBtn.BackColor = Color.Teal;
            createAccountBtn.Cursor = Cursors.Hand;
            createAccountBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createAccountBtn.ForeColor = SystemColors.ControlLightLight;
            createAccountBtn.Location = new Point(154, 391);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(169, 47);
            createAccountBtn.TabIndex = 6;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.UseVisualStyleBackColor = false;
            createAccountBtn.Click += createAccountBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(iconPictureBox3);
            panel4.Location = new Point(28, 151);
            panel4.Name = "panel4";
            panel4.Size = new Size(386, 44);
            panel4.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(49, 14);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(304, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = SystemColors.ControlLightLight;
            iconPictureBox3.ForeColor = Color.Teal;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox3.IconColor = Color.Teal;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 40;
            iconPictureBox3.Location = new Point(3, 4);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(40, 40);
            iconPictureBox3.TabIndex = 1;
            iconPictureBox3.TabStop = false;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ControlLightLight;
            panel.Controls.Add(txtUsername);
            panel.Controls.Add(iconPictureBox2);
            panel.Location = new Point(28, 83);
            panel.Name = "panel";
            panel.Size = new Size(386, 43);
            panel.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(49, 13);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(304, 23);
            txtUsername.TabIndex = 1;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.ControlLightLight;
            iconPictureBox2.ForeColor = Color.Teal;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox2.IconColor = Color.Teal;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 40;
            iconPictureBox2.Location = new Point(3, 4);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(40, 40);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(28, 23);
            label5.Name = "label5";
            label5.Size = new Size(167, 31);
            label5.TabIndex = 4;
            label5.Text = "Create account";
            // 
            // createAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "createAccount";
            Text = "Create Account";
            Load += login_Load;
            KeyDown += login_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private Label label4;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Panel panel;
        private TextBox txtUsername;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label5;
        private TextBox txtPassword;
        private Button createAccountBtn;
        private Panel panel6;
        private ComboBox cbType;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Panel panel5;
        private TextBox txtEmail;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Panel panel3;
        private TextBox txtFullName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Button backBtn;
    }
}