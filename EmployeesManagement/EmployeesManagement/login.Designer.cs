namespace EmployeesManagement
{
    partial class login
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
            button1 = new Button();
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
            label1.Location = new Point(123, 195);
            label1.Name = "label1";
            label1.Size = new Size(178, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome to The";
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
            panel2.Controls.Add(button1);
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
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(155, 315);
            button1.Name = "button1";
            button1.Size = new Size(134, 47);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(iconPictureBox3);
            panel4.Location = new Point(28, 238);
            panel4.Name = "panel4";
            panel4.Size = new Size(386, 44);
            panel4.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(49, 14);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(304, 20);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
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
            panel.Location = new Point(28, 170);
            panel.Name = "panel";
            panel.Size = new Size(386, 43);
            panel.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(49, 13);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(304, 20);
            txtUsername.TabIndex = 1;
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
            label5.Location = new Point(28, 86);
            label5.Name = "label5";
            label5.Size = new Size(236, 31);
            label5.TabIndex = 4;
            label5.Text = "Login to your account";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "login";
            Text = "Login";
            Load += login_Load;
            KeyDown += login_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button button1;
    }
}