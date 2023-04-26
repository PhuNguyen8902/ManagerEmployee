namespace EmployeesManagement.userControl.Admin.Detail.projectDetail
{
    partial class projectDetail
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
            dgvEmployee = new DataGridView();
            lbId = new Label();
            lbName = new Label();
            lbDescription = new Label();
            lbStartDate = new Label();
            lbEndDate = new Label();
            lbCondition = new Label();
            btnAddEmployee = new Button();
            btnDeleteEmploye = new Button();
            btnUpdateEmployee = new Button();
            btnExportExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
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
            dgvEmployee.TabIndex = 0;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(21, 21);
            lbId.Name = "lbId";
            lbId.Size = new Size(31, 20);
            lbId.TabIndex = 1;
            lbId.Text = "ID: ";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(21, 60);
            lbName.Name = "lbName";
            lbName.Size = new Size(56, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Name: ";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(21, 102);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(92, 20);
            lbDescription.TabIndex = 3;
            lbDescription.Text = "Description: ";
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(396, 21);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(83, 20);
            lbStartDate.TabIndex = 4;
            lbStartDate.Text = "Start Date: ";
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(396, 60);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(77, 20);
            lbEndDate.TabIndex = 5;
            lbEndDate.Text = "End Date: ";
            // 
            // lbCondition
            // 
            lbCondition.AutoSize = true;
            lbCondition.Location = new Point(396, 102);
            lbCondition.Name = "lbCondition";
            lbCondition.Size = new Size(81, 20);
            lbCondition.TabIndex = 6;
            lbCondition.Text = "Condition: ";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Cursor = Cursors.Hand;
            btnAddEmployee.Location = new Point(662, 171);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(131, 29);
            btnAddEmployee.TabIndex = 8;
            btnAddEmployee.Text = "Add employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += addEmployee_Click;
            // 
            // btnDeleteEmploye
            // 
            btnDeleteEmploye.Cursor = Cursors.Hand;
            btnDeleteEmploye.Location = new Point(525, 171);
            btnDeleteEmploye.Name = "btnDeleteEmploye";
            btnDeleteEmploye.Size = new Size(131, 29);
            btnDeleteEmploye.TabIndex = 9;
            btnDeleteEmploye.Text = "Delete employee";
            btnDeleteEmploye.UseVisualStyleBackColor = true;
            btnDeleteEmploye.Click += btnDeleteEmploye_Click;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Cursor = Cursors.Hand;
            btnUpdateEmployee.Location = new Point(380, 171);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(139, 29);
            btnUpdateEmployee.TabIndex = 10;
            btnUpdateEmployee.Text = "Update employee";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.Location = new Point(12, 171);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(106, 29);
            btnExportExcel.TabIndex = 11;
            btnExportExcel.Text = "Export excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // projectDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 563);
            Controls.Add(btnExportExcel);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(btnDeleteEmploye);
            Controls.Add(btnAddEmployee);
            Controls.Add(lbCondition);
            Controls.Add(lbEndDate);
            Controls.Add(lbStartDate);
            Controls.Add(lbDescription);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Controls.Add(dgvEmployee);
            Name = "projectDetail";
            Text = "projectDetail";
            Load += projectDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private Label lbId;
        private Label lbName;
        private Label lbDescription;
        private Label lbStartDate;
        private Label lbEndDate;
        private Label lbCondition;
        private Button btnAddEmployee;
        private Button btnDeleteEmploye;
        private Button btnUpdateEmployee;
        private Button btnExportExcel;
    }
}