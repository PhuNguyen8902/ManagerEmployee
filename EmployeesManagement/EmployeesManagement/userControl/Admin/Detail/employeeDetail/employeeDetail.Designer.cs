namespace EmployeesManagement.userControl.Admin.Detail.employeeDetail
{
    partial class employeeDetail
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
            dgvProject = new DataGridView();
            lbId = new Label();
            lbName = new Label();
            lbPhone = new Label();
            lbGender = new Label();
            lbHomeTown = new Label();
            lbDepartment = new Label();
            lbSalary = new Label();
            lbPosition = new Label();
            btnExportExcel = new Button();
            btnNow = new Button();
            btnPast = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProject).BeginInit();
            SuspendLayout();
            // 
            // dgvProject
            // 
            dgvProject.AllowUserToAddRows = false;
            dgvProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProject.Dock = DockStyle.Bottom;
            dgvProject.Location = new Point(0, 243);
            dgvProject.Name = "dgvProject";
            dgvProject.RowHeadersWidth = 51;
            dgvProject.RowTemplate.Height = 29;
            dgvProject.Size = new Size(801, 330);
            dgvProject.TabIndex = 0;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(31, 24);
            lbId.Name = "lbId";
            lbId.Size = new Size(25, 20);
            lbId.TabIndex = 1;
            lbId.Text = "Id:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(31, 70);
            lbName.Name = "lbName";
            lbName.Size = new Size(52, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Name:";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(31, 116);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(57, 20);
            lbPhone.TabIndex = 3;
            lbPhone.Text = "Phone: ";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(31, 166);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(60, 20);
            lbGender.TabIndex = 4;
            lbGender.Text = "Gender:";
            // 
            // lbHomeTown
            // 
            lbHomeTown.AutoSize = true;
            lbHomeTown.Location = new Point(380, 24);
            lbHomeTown.Name = "lbHomeTown";
            lbHomeTown.Size = new Size(92, 20);
            lbHomeTown.TabIndex = 5;
            lbHomeTown.Text = "Home Town:";
            // 
            // lbDepartment
            // 
            lbDepartment.AutoSize = true;
            lbDepartment.Location = new Point(380, 70);
            lbDepartment.Name = "lbDepartment";
            lbDepartment.Size = new Size(92, 20);
            lbDepartment.TabIndex = 6;
            lbDepartment.Text = "Department:";
            // 
            // lbSalary
            // 
            lbSalary.AutoSize = true;
            lbSalary.Location = new Point(380, 116);
            lbSalary.Name = "lbSalary";
            lbSalary.Size = new Size(52, 20);
            lbSalary.TabIndex = 7;
            lbSalary.Text = "Salary:";
            // 
            // lbPosition
            // 
            lbPosition.AutoSize = true;
            lbPosition.Location = new Point(380, 166);
            lbPosition.Name = "lbPosition";
            lbPosition.Size = new Size(64, 20);
            lbPosition.TabIndex = 8;
            lbPosition.Text = "Position:";
            // 
            // btnExportExcel
            // 
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.Location = new Point(691, 208);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(107, 29);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "Export excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnNow
            // 
            btnNow.Cursor = Cursors.Hand;
            btnNow.Location = new Point(12, 208);
            btnNow.Name = "btnNow";
            btnNow.Size = new Size(71, 29);
            btnNow.TabIndex = 10;
            btnNow.Text = "Now";
            btnNow.UseVisualStyleBackColor = true;
            btnNow.Click += btnNow_Click;
            // 
            // btnPast
            // 
            btnPast.Cursor = Cursors.Hand;
            btnPast.Location = new Point(89, 208);
            btnPast.Name = "btnPast";
            btnPast.Size = new Size(71, 29);
            btnPast.TabIndex = 11;
            btnPast.Text = "Past";
            btnPast.UseVisualStyleBackColor = true;
            btnPast.Click += btnPast_Click;
            // 
            // employeeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 573);
            Controls.Add(btnPast);
            Controls.Add(btnNow);
            Controls.Add(btnExportExcel);
            Controls.Add(lbPosition);
            Controls.Add(lbSalary);
            Controls.Add(lbDepartment);
            Controls.Add(lbHomeTown);
            Controls.Add(lbGender);
            Controls.Add(lbPhone);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Controls.Add(dgvProject);
            Name = "employeeDetail";
            Text = "employeeDetail";
            Load += employeeDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProject;
        private Label lbId;
        private Label lbName;
        private Label lbPhone;
        private Label lbGender;
        private Label lbHomeTown;
        private Label lbDepartment;
        private Label lbSalary;
        private Label lbPosition;
        private Button btnExportExcel;
        private Button btnNow;
        private Button btnPast;
    }
}