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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.lbId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbCondition = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmploye = new System.Windows.Forms.Button();
            this.btnEndJob = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 206);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.Size = new System.Drawing.Size(805, 357);
            this.dgvEmployee.TabIndex = 0;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(21, 21);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(31, 20);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "ID: ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(21, 60);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name: ";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(21, 102);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(92, 20);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "Description: ";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(396, 21);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(83, 20);
            this.lbStartDate.TabIndex = 4;
            this.lbStartDate.Text = "Start Date: ";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(396, 60);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(77, 20);
            this.lbEndDate.TabIndex = 5;
            this.lbEndDate.Text = "End Date: ";
            // 
            // lbCondition
            // 
            this.lbCondition.AutoSize = true;
            this.lbCondition.Location = new System.Drawing.Point(396, 102);
            this.lbCondition.Name = "lbCondition";
            this.lbCondition.Size = new System.Drawing.Size(81, 20);
            this.lbCondition.TabIndex = 6;
            this.lbCondition.Text = "Condition: ";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(662, 171);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(131, 29);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // btnDeleteEmploye
            // 
            this.btnDeleteEmploye.Location = new System.Drawing.Point(525, 171);
            this.btnDeleteEmploye.Name = "btnDeleteEmploye";
            this.btnDeleteEmploye.Size = new System.Drawing.Size(131, 29);
            this.btnDeleteEmploye.TabIndex = 9;
            this.btnDeleteEmploye.Text = "Delete employee";
            this.btnDeleteEmploye.UseVisualStyleBackColor = true;
            this.btnDeleteEmploye.Click += new System.EventHandler(this.btnDeleteEmploye_Click);
            // 
            // btnEndJob
            // 
            this.btnEndJob.Location = new System.Drawing.Point(12, 171);
            this.btnEndJob.Name = "btnEndJob";
            this.btnEndJob.Size = new System.Drawing.Size(94, 29);
            this.btnEndJob.TabIndex = 10;
            this.btnEndJob.Text = "End job";
            this.btnEndJob.UseVisualStyleBackColor = true;
            this.btnEndJob.Click += new System.EventHandler(this.btnEndJob_Click);
            // 
            // projectDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 563);
            this.Controls.Add(this.btnEndJob);
            this.Controls.Add(this.btnDeleteEmploye);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lbCondition);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "projectDetail";
            this.Text = "projectDetail";
            this.Load += new System.EventHandler(this.projectDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnEndJob;
    }
}