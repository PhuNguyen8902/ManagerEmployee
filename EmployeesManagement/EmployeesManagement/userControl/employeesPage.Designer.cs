namespace EmployeesManagement.userControl
{
    partial class employeesPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 27);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(677, 21);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(94, 29);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(567, 21);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 29);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataSource = typeof(EmployeesManagement.Models.Employee);
            // 
            // employeeBindingSource5
            // 
            this.employeeBindingSource5.DataSource = typeof(EmployeesManagement.Models.Employee);
            // 
            // employeeBindingSource3
            // 
            this.employeeBindingSource3.DataSource = typeof(EmployeesManagement.Models.Employee);
            // 
            // employeeBindingSource4
            // 
            this.employeeBindingSource4.DataSource = typeof(EmployeesManagement.Models.Employee);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 163);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.Size = new System.Drawing.Size(903, 546);
            this.dgvEmployee.TabIndex = 8;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(787, 19);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // employeesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "employeesPage";
            this.Size = new System.Drawing.Size(903, 709);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button updateBtn;
        private Button addBtn;
        private BindingSource employeeBindingSource;
        private BindingSource employeeBindingSource1;
        private BindingSource employeeBindingSource2;
        private BindingSource employeeBindingSource3;
        private BindingSource employeeBindingSource4;
        private BindingSource employeeBindingSource5;
        private DataGridView dgvEmployee;
        private Button deleteBtn;
    }
}
