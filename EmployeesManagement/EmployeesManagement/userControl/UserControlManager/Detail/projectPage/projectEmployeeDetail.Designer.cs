namespace EmployeesManagement.userControl.UserControlManager.Detail.projectPage
{
    partial class projectEmployeeDetail
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
            lbCondition = new Label();
            lbEndDate = new Label();
            lbStartDate = new Label();
            lbDescription = new Label();
            lbName = new Label();
            lbId = new Label();
            dgvEmployee = new DataGridView();
            btnExportExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // lbCondition
            // 
            lbCondition.AutoSize = true;
            lbCondition.Location = new Point(396, 99);
            lbCondition.Name = "lbCondition";
            lbCondition.Size = new Size(81, 20);
            lbCondition.TabIndex = 12;
            lbCondition.Text = "Condition: ";
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(396, 57);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(77, 20);
            lbEndDate.TabIndex = 11;
            lbEndDate.Text = "End Date: ";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(396, 18);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(83, 20);
            lbStartDate.TabIndex = 10;
            lbStartDate.Text = "Start Date: ";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(21, 99);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(92, 20);
            lbDescription.TabIndex = 9;
            lbDescription.Text = "Description: ";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(21, 57);
            lbName.Name = "lbName";
            lbName.Size = new Size(56, 20);
            lbName.TabIndex = 8;
            lbName.Text = "Name: ";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(21, 18);
            lbId.Name = "lbId";
            lbId.Size = new Size(31, 20);
            lbId.TabIndex = 7;
            lbId.Text = "ID: ";
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Dock = DockStyle.Bottom;
            dgvEmployee.Location = new Point(0, 206);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(805, 357);
            dgvEmployee.TabIndex = 13;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.Location = new Point(675, 171);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(118, 29);
            btnExportExcel.TabIndex = 37;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // projectEmployeeDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 563);
            Controls.Add(btnExportExcel);
            Controls.Add(dgvEmployee);
            Controls.Add(lbCondition);
            Controls.Add(lbEndDate);
            Controls.Add(lbStartDate);
            Controls.Add(lbDescription);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Name = "projectEmployeeDetail";
            Text = "projectEmployeeDetail";
            Load += projectEmployeeDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCondition;
        private Label lbEndDate;
        private Label lbStartDate;
        private Label lbDescription;
        private Label lbName;
        private Label lbId;
        private DataGridView dgvEmployee;
        private Button btnExportExcel;
    }
}