namespace EmployeesManagement
{
    partial class FormManager
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
            panel4 = new Panel();
            notifyBtn = new FontAwesome.Sharp.IconButton();
            accountBtn = new FontAwesome.Sharp.IconButton();
            createAccountBtn = new FontAwesome.Sharp.IconButton();
            projectsBtn = new FontAwesome.Sharp.IconButton();
            departmentBtn = new FontAwesome.Sharp.IconButton();
            employeesBtn = new FontAwesome.Sharp.IconButton();
            informationBtn = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            returnBtn = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            lbName = new Label();
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 710);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(notifyBtn);
            panel4.Controls.Add(accountBtn);
            panel4.Controls.Add(createAccountBtn);
            panel4.Controls.Add(projectsBtn);
            panel4.Controls.Add(departmentBtn);
            panel4.Controls.Add(employeesBtn);
            panel4.Controls.Add(informationBtn);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(0, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 492);
            panel4.TabIndex = 2;
            // 
            // notifyBtn
            // 
            notifyBtn.BackColor = Color.Teal;
            notifyBtn.Dock = DockStyle.Top;
            notifyBtn.FlatAppearance.BorderColor = Color.Teal;
            notifyBtn.FlatStyle = FlatStyle.Flat;
            notifyBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            notifyBtn.ForeColor = SystemColors.ControlLightLight;
            notifyBtn.IconChar = FontAwesome.Sharp.IconChar.Bell;
            notifyBtn.IconColor = Color.White;
            notifyBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            notifyBtn.ImageAlign = ContentAlignment.MiddleLeft;
            notifyBtn.Location = new Point(0, 295);
            notifyBtn.Name = "notifyBtn";
            notifyBtn.Size = new Size(258, 59);
            notifyBtn.TabIndex = 10;
            notifyBtn.Text = "Notify";
            notifyBtn.TextAlign = ContentAlignment.MiddleLeft;
            notifyBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            notifyBtn.UseVisualStyleBackColor = false;
            notifyBtn.Click += notifyBtn_Click;
            // 
            // accountBtn
            // 
            accountBtn.BackColor = Color.Teal;
            accountBtn.Dock = DockStyle.Top;
            accountBtn.FlatAppearance.BorderColor = Color.Teal;
            accountBtn.FlatStyle = FlatStyle.Flat;
            accountBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            accountBtn.ForeColor = SystemColors.ControlLightLight;
            accountBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            accountBtn.IconColor = Color.White;
            accountBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            accountBtn.ImageAlign = ContentAlignment.MiddleLeft;
            accountBtn.Location = new Point(0, 236);
            accountBtn.Name = "accountBtn";
            accountBtn.Size = new Size(258, 59);
            accountBtn.TabIndex = 9;
            accountBtn.Text = "Account";
            accountBtn.TextAlign = ContentAlignment.MiddleLeft;
            accountBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            accountBtn.UseVisualStyleBackColor = false;
            accountBtn.Click += accountBtn_Click;
            // 
            // createAccountBtn
            // 
            createAccountBtn.BackColor = Color.Teal;
            createAccountBtn.FlatAppearance.BorderColor = Color.Teal;
            createAccountBtn.FlatStyle = FlatStyle.Flat;
            createAccountBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            createAccountBtn.ForeColor = SystemColors.ControlLightLight;
            createAccountBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            createAccountBtn.IconColor = Color.White;
            createAccountBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createAccountBtn.IconSize = 24;
            createAccountBtn.Location = new Point(3, 420);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(249, 69);
            createAccountBtn.TabIndex = 8;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.TextAlign = ContentAlignment.MiddleLeft;
            createAccountBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            createAccountBtn.UseVisualStyleBackColor = false;
            createAccountBtn.Click += createAccountBtn_Click;
            // 
            // projectsBtn
            // 
            projectsBtn.BackColor = Color.Teal;
            projectsBtn.Dock = DockStyle.Top;
            projectsBtn.FlatAppearance.BorderColor = Color.Teal;
            projectsBtn.FlatStyle = FlatStyle.Flat;
            projectsBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            projectsBtn.ForeColor = SystemColors.ControlLightLight;
            projectsBtn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            projectsBtn.IconColor = Color.White;
            projectsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            projectsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            projectsBtn.Location = new Point(0, 177);
            projectsBtn.Name = "projectsBtn";
            projectsBtn.Size = new Size(258, 59);
            projectsBtn.TabIndex = 6;
            projectsBtn.Text = "Projects";
            projectsBtn.TextAlign = ContentAlignment.MiddleLeft;
            projectsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            projectsBtn.UseVisualStyleBackColor = false;
            projectsBtn.Click += projectsBtn_Click;
            // 
            // departmentBtn
            // 
            departmentBtn.BackColor = Color.Teal;
            departmentBtn.Dock = DockStyle.Top;
            departmentBtn.FlatAppearance.BorderColor = Color.Teal;
            departmentBtn.FlatStyle = FlatStyle.Flat;
            departmentBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            departmentBtn.ForeColor = SystemColors.ControlLightLight;
            departmentBtn.IconChar = FontAwesome.Sharp.IconChar.Building;
            departmentBtn.IconColor = Color.White;
            departmentBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            departmentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            departmentBtn.Location = new Point(0, 118);
            departmentBtn.Name = "departmentBtn";
            departmentBtn.Size = new Size(258, 59);
            departmentBtn.TabIndex = 5;
            departmentBtn.Text = "Department";
            departmentBtn.TextAlign = ContentAlignment.MiddleLeft;
            departmentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            departmentBtn.UseVisualStyleBackColor = false;
            departmentBtn.Click += departmentBtn_Click;
            // 
            // employeesBtn
            // 
            employeesBtn.BackColor = Color.Teal;
            employeesBtn.Dock = DockStyle.Top;
            employeesBtn.FlatAppearance.BorderColor = Color.Teal;
            employeesBtn.FlatStyle = FlatStyle.Flat;
            employeesBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            employeesBtn.ForeColor = SystemColors.ControlLightLight;
            employeesBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            employeesBtn.IconColor = Color.White;
            employeesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            employeesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            employeesBtn.Location = new Point(0, 59);
            employeesBtn.Name = "employeesBtn";
            employeesBtn.Size = new Size(258, 59);
            employeesBtn.TabIndex = 4;
            employeesBtn.Text = "Employees";
            employeesBtn.TextAlign = ContentAlignment.MiddleLeft;
            employeesBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            employeesBtn.UseVisualStyleBackColor = false;
            employeesBtn.Click += employeesBtn_Click;
            // 
            // informationBtn
            // 
            informationBtn.BackColor = Color.Teal;
            informationBtn.Dock = DockStyle.Top;
            informationBtn.FlatAppearance.BorderColor = Color.Teal;
            informationBtn.FlatStyle = FlatStyle.Flat;
            informationBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            informationBtn.ForeColor = SystemColors.ControlLightLight;
            informationBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            informationBtn.IconColor = Color.White;
            informationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            informationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            informationBtn.Location = new Point(0, 0);
            informationBtn.Name = "informationBtn";
            informationBtn.Size = new Size(258, 59);
            informationBtn.TabIndex = 3;
            informationBtn.Text = "Information";
            informationBtn.TextAlign = ContentAlignment.MiddleLeft;
            informationBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            informationBtn.UseVisualStyleBackColor = false;
            informationBtn.Click += informationBtn_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(returnBtn);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 635);
            panel5.Name = "panel5";
            panel5.Size = new Size(258, 75);
            panel5.TabIndex = 3;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.Teal;
            returnBtn.FlatAppearance.BorderColor = Color.Teal;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.ForeColor = SystemColors.ControlLightLight;
            returnBtn.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            returnBtn.IconColor = Color.White;
            returnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            returnBtn.IconSize = 22;
            returnBtn.Location = new Point(18, 14);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(117, 49);
            returnBtn.TabIndex = 0;
            returnBtn.Text = "Sign out";
            returnBtn.TextAlign = ContentAlignment.MiddleLeft;
            returnBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            returnBtn.UseVisualStyleBackColor = false;
            returnBtn.Click += returnBtn_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbName);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(iconPictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 143);
            panel3.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.ForeColor = SystemColors.ControlLightLight;
            lbName.Location = new Point(118, 76);
            lbName.Name = "lbName";
            lbName.Size = new Size(64, 28);
            lbName.TabIndex = 2;
            lbName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(29, 120);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 1;
            label1.Text = "________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(118, 33);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Welcome";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Teal;
            iconPictureBox1.ForeColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlLightLight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 100;
            iconPictureBox1.Location = new Point(12, 21);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(100, 107);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(258, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(903, 710);
            mainPanel.TabIndex = 1;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 710);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Name = "FormManager";
            Text = "Manager";
            Load += FormManager_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel mainPanel;
        private Label lbName;
        private Label label2;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton returnBtn;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton employeesBtn;
        private FontAwesome.Sharp.IconButton informationBtn;
        private FontAwesome.Sharp.IconButton departmentBtn;
        private FontAwesome.Sharp.IconButton projectsBtn;
        private FontAwesome.Sharp.IconButton createAccountBtn;
        private FontAwesome.Sharp.IconButton accountBtn;
        private FontAwesome.Sharp.IconButton notifyBtn;
    }
}