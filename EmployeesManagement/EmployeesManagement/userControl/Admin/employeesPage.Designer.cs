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
            tbSearch = new TextBox();
            btnSearch = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            btnExportExcel = new Button();
            employeeBindingSource1 = new BindingSource(components);
            employeeBindingSource = new BindingSource(components);
            employeeBindingSource2 = new BindingSource(components);
            employeeBindingSource5 = new BindingSource(components);
            employeeBindingSource3 = new BindingSource(components);
            employeeBindingSource4 = new BindingSource(components);
            dgvEmployee = new DataGridView();
            deleteBtn = new Button();
            cbSearch = new ComboBox();
            cbSearchGender = new ComboBox();
            cbSearchPosition = new ComboBox();
            btnFindAll = new Button();
            btnEmail = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(22, 21);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(298, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(677, 21);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(567, 21);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(10, 120);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(120, 29);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
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
            dgvEmployee.Dock = DockStyle.Bottom;
            dgvEmployee.Location = new Point(0, 163);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(903, 546);
            dgvEmployee.TabIndex = 8;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(787, 19);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(22, 64);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(258, 28);
            cbSearch.TabIndex = 10;
            cbSearch.Text = "Select the item you want to search";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // cbSearchGender
            // 
            cbSearchGender.FormattingEnabled = true;
            cbSearchGender.Location = new Point(22, 20);
            cbSearchGender.Name = "cbSearchGender";
            cbSearchGender.Size = new Size(258, 28);
            cbSearchGender.TabIndex = 11;
            cbSearchGender.Text = "Select the geder";
            cbSearchGender.Visible = false;
            // 
            // cbSearchPosition
            // 
            cbSearchPosition.FormattingEnabled = true;
            cbSearchPosition.Location = new Point(22, 20);
            cbSearchPosition.Name = "cbSearchPosition";
            cbSearchPosition.Size = new Size(258, 28);
            cbSearchPosition.TabIndex = 12;
            cbSearchPosition.Text = "Select the position";
            cbSearchPosition.Visible = false;
            // 
            // btnFindAll
            // 
            btnFindAll.Location = new Point(411, 22);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 27;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(151, 120);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(120, 29);
            btnEmail.TabIndex = 28;
            btnEmail.Text = "Send Email";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // employeesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEmail);
            Controls.Add(btnFindAll);
            Controls.Add(cbSearchPosition);
            Controls.Add(cbSearchGender);
            Controls.Add(cbSearch);
            Controls.Add(btnExportExcel);
            Controls.Add(deleteBtn);
            Controls.Add(dgvEmployee);
            Controls.Add(addBtn);
            Controls.Add(updateBtn);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Name = "employeesPage";
            Size = new Size(903, 709);
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

        private TextBox tbSearch;
        private Button btnSearch;
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
        private Button btnExportExcel;
        private ComboBox cbSearch;
        private ComboBox cbSearchGender;
        private ComboBox cbSearchPosition;
        private Button btnFindAll;
        private Button btnEmail;
    }
}
