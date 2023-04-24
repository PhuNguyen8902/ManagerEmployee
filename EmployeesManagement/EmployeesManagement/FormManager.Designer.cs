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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.projectsBtn = new FontAwesome.Sharp.IconButton();
            this.departmentBtn = new FontAwesome.Sharp.IconButton();
            this.employeesBtn = new FontAwesome.Sharp.IconButton();
            this.informationBtn = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.returnBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbNameManager = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 710);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.projectsBtn);
            this.panel4.Controls.Add(this.departmentBtn);
            this.panel4.Controls.Add(this.employeesBtn);
            this.panel4.Controls.Add(this.informationBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(0, 143);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 492);
            this.panel4.TabIndex = 2;
            // 
            // projectsBtn
            // 
            this.projectsBtn.BackColor = System.Drawing.Color.Teal;
            this.projectsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.projectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.projectsBtn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.projectsBtn.IconColor = System.Drawing.Color.White;
            this.projectsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.projectsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectsBtn.Location = new System.Drawing.Point(0, 177);
            this.projectsBtn.Name = "projectsBtn";
            this.projectsBtn.Size = new System.Drawing.Size(258, 59);
            this.projectsBtn.TabIndex = 6;
            this.projectsBtn.Text = "Projects";
            this.projectsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.projectsBtn.UseVisualStyleBackColor = false;
            this.projectsBtn.Click += new System.EventHandler(this.projectsBtn_Click);
            // 
            // departmentBtn
            // 
            this.departmentBtn.BackColor = System.Drawing.Color.Teal;
            this.departmentBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.departmentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.departmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.departmentBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.departmentBtn.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.departmentBtn.IconColor = System.Drawing.Color.White;
            this.departmentBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.departmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.departmentBtn.Location = new System.Drawing.Point(0, 118);
            this.departmentBtn.Name = "departmentBtn";
            this.departmentBtn.Size = new System.Drawing.Size(258, 59);
            this.departmentBtn.TabIndex = 5;
            this.departmentBtn.Text = "Department";
            this.departmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.departmentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.departmentBtn.UseVisualStyleBackColor = false;
            this.departmentBtn.Click += new System.EventHandler(this.departmentBtn_Click);
            // 
            // employeesBtn
            // 
            this.employeesBtn.BackColor = System.Drawing.Color.Teal;
            this.employeesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.employeesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeesBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.employeesBtn.IconColor = System.Drawing.Color.White;
            this.employeesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.employeesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesBtn.Location = new System.Drawing.Point(0, 59);
            this.employeesBtn.Name = "employeesBtn";
            this.employeesBtn.Size = new System.Drawing.Size(258, 59);
            this.employeesBtn.TabIndex = 4;
            this.employeesBtn.Text = "Employees";
            this.employeesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.employeesBtn.UseVisualStyleBackColor = false;
            this.employeesBtn.Click += new System.EventHandler(this.employeesBtn_Click);
            // 
            // informationBtn
            // 
            this.informationBtn.BackColor = System.Drawing.Color.Teal;
            this.informationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.informationBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.informationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.informationBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.informationBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.informationBtn.IconColor = System.Drawing.Color.White;
            this.informationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.informationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informationBtn.Location = new System.Drawing.Point(0, 0);
            this.informationBtn.Name = "informationBtn";
            this.informationBtn.Size = new System.Drawing.Size(258, 59);
            this.informationBtn.TabIndex = 3;
            this.informationBtn.Text = "Information";
            this.informationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.informationBtn.UseVisualStyleBackColor = false;
            this.informationBtn.Click += new System.EventHandler(this.informationBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.returnBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 635);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 75);
            this.panel5.TabIndex = 3;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.Teal;
            this.returnBtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnBtn.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.returnBtn.IconColor = System.Drawing.Color.White;
            this.returnBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.returnBtn.IconSize = 22;
            this.returnBtn.Location = new System.Drawing.Point(18, 14);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(117, 49);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "Sign out";
            this.returnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbNameManager);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 143);
            this.panel3.TabIndex = 0;
            // 
            // lbNameManager
            // 
            this.lbNameManager.AutoSize = true;
            this.lbNameManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNameManager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNameManager.Location = new System.Drawing.Point(118, 76);
            this.lbNameManager.Name = "lbNameManager";
            this.lbNameManager.Size = new System.Drawing.Size(64, 28);
            this.lbNameManager.TabIndex = 2;
            this.lbNameManager.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(118, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Teal;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 100;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 21);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(100, 107);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(258, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(903, 710);
            this.mainPanel.TabIndex = 1;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 710);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "FormManager";
            this.Text = "Manager";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel mainPanel;
        private Label lbNameManager;
        private Label label2;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton returnBtn;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton employeesBtn;
        private FontAwesome.Sharp.IconButton informationBtn;
        private FontAwesome.Sharp.IconButton departmentBtn;
        private FontAwesome.Sharp.IconButton projectsBtn;
    }
}