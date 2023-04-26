namespace EmployeesManagement.userControl.Admin.Detail.projectDetail
{
    partial class addEmployeeToProjectForm
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
            dgvAllEmployees = new DataGridView();
            btnComfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvAllEmployees
            // 
            dgvAllEmployees.AllowUserToAddRows = false;
            dgvAllEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllEmployees.Dock = DockStyle.Bottom;
            dgvAllEmployees.Location = new Point(0, 63);
            dgvAllEmployees.Name = "dgvAllEmployees";
            dgvAllEmployees.RowHeadersWidth = 51;
            dgvAllEmployees.RowTemplate.Height = 29;
            dgvAllEmployees.Size = new Size(800, 387);
            dgvAllEmployees.TabIndex = 0;
            // 
            // btnComfirm
            // 
            btnComfirm.Cursor = Cursors.Hand;
            btnComfirm.Location = new Point(694, 12);
            btnComfirm.Name = "btnComfirm";
            btnComfirm.Size = new Size(94, 29);
            btnComfirm.TabIndex = 1;
            btnComfirm.Text = "Comfirm";
            btnComfirm.UseVisualStyleBackColor = true;
            btnComfirm.Click += btnComfirm_Click;
            // 
            // addEmployeeToProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComfirm);
            Controls.Add(dgvAllEmployees);
            Name = "addEmployeeToProjectForm";
            Text = "addEmployeeToProjectForm";
            Load += addEmployeeToProjectForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAllEmployees;
        private Button btnComfirm;
    }
}