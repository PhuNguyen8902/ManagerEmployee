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
            this.dgvAllEmployees = new System.Windows.Forms.DataGridView();
            this.btnComfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllEmployees
            // 
            this.dgvAllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllEmployees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAllEmployees.Location = new System.Drawing.Point(0, 63);
            this.dgvAllEmployees.Name = "dgvAllEmployees";
            this.dgvAllEmployees.RowHeadersWidth = 51;
            this.dgvAllEmployees.RowTemplate.Height = 29;
            this.dgvAllEmployees.Size = new System.Drawing.Size(800, 387);
            this.dgvAllEmployees.TabIndex = 0;
            // 
            // btnComfirm
            // 
            this.btnComfirm.Location = new System.Drawing.Point(694, 12);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(94, 29);
            this.btnComfirm.TabIndex = 1;
            this.btnComfirm.Text = "Comfirm";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // addEmployeeToProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.dgvAllEmployees);
            this.Name = "addEmployeeToProjectForm";
            this.Text = "addEmployeeToProjectForm";
            this.Load += new System.EventHandler(this.addEmployeeToProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvAllEmployees;
        private Button btnComfirm;
    }
}