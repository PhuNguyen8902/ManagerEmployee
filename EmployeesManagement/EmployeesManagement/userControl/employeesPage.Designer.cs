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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            button1 = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            employeeBindingSource1 = new BindingSource(components);
            employeeBindingSource = new BindingSource(components);
            employeeBindingSource2 = new BindingSource(components);
            employeeBindingSource5 = new BindingSource(components);
            employeeBindingSource3 = new BindingSource(components);
            employeeBindingSource4 = new BindingSource(components);
            dgvEmployee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 16);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(261, 16);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(690, 16);
            updateBtn.Margin = new Padding(3, 2, 3, 2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(82, 22);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(589, 16);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(82, 22);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // employeeBindingSource1
            // 
            employeeBindingSource1.DataSource = typeof(Models.Employee);
            // 
            // employeeBindingSource5
            // 
            employeeBindingSource5.DataSource = typeof(Models.Employee);
            // 
            // employeeBindingSource3
            // 
            employeeBindingSource3.DataSource = typeof(Models.Employee);
            // 
            // employeeBindingSource4
            // 
            employeeBindingSource4.DataSource = typeof(Models.Employee);
            // 
            // dgvEmployee
            // 
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(0, 56);
            dgvEmployee.Margin = new Padding(3, 2, 3, 2);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(785, 169);
            dgvEmployee.TabIndex = 8;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // employeesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvEmployee);
            Controls.Add(addBtn);
            Controls.Add(updateBtn);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "employeesPage";
            Size = new Size(790, 532);
            Load += employeesPage_Load;
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
