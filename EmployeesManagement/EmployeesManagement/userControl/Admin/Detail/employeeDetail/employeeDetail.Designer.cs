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
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.lbId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbHomeTown = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnNow = new System.Windows.Forms.Button();
            this.btnPast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProject
            // 
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProject.Location = new System.Drawing.Point(0, 243);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersWidth = 51;
            this.dgvProject.RowTemplate.Height = 29;
            this.dgvProject.Size = new System.Drawing.Size(801, 330);
            this.dgvProject.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(31, 24);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(25, 20);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Id:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(31, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(31, 116);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(57, 20);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Phone: ";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(31, 166);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(60, 20);
            this.lbGender.TabIndex = 4;
            this.lbGender.Text = "Gender:";
            // 
            // lbHomeTown
            // 
            this.lbHomeTown.AutoSize = true;
            this.lbHomeTown.Location = new System.Drawing.Point(380, 24);
            this.lbHomeTown.Name = "lbHomeTown";
            this.lbHomeTown.Size = new System.Drawing.Size(92, 20);
            this.lbHomeTown.TabIndex = 5;
            this.lbHomeTown.Text = "Home Town:";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(380, 70);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(92, 20);
            this.lbDepartment.TabIndex = 6;
            this.lbDepartment.Text = "Department:";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(380, 116);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(52, 20);
            this.lbSalary.TabIndex = 7;
            this.lbSalary.Text = "Salary:";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(380, 166);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(64, 20);
            this.lbPosition.TabIndex = 8;
            this.lbPosition.Text = "Position:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(691, 208);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(107, 29);
            this.btnExportExcel.TabIndex = 9;
            this.btnExportExcel.Text = "Export excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(12, 208);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(71, 29);
            this.btnNow.TabIndex = 10;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnPast
            // 
            this.btnPast.Location = new System.Drawing.Point(89, 208);
            this.btnPast.Name = "btnPast";
            this.btnPast.Size = new System.Drawing.Size(71, 29);
            this.btnPast.TabIndex = 11;
            this.btnPast.Text = "Past";
            this.btnPast.UseVisualStyleBackColor = true;
            this.btnPast.Click += new System.EventHandler(this.btnPast_Click);
            // 
            // employeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 573);
            this.Controls.Add(this.btnPast);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbHomeTown);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.dgvProject);
            this.Name = "employeeDetail";
            this.Text = "employeeDetail";
            this.Load += new System.EventHandler(this.employeeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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