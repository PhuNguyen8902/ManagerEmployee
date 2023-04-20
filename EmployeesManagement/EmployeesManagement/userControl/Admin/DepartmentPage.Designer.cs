namespace EmployeesManagement.userControl
{
    partial class DepartmentPage
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
            deleteBtn = new Button();
            dgvDepartment = new DataGridView();
            addBtn = new Button();
            updateBtn = new Button();
            btnSearch = new Button();
            tbSearch = new TextBox();
            cbSearch = new ComboBox();
            btnFindAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(787, 9);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 15;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dgvDepartment
            // 
            dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Dock = DockStyle.Bottom;
            dgvDepartment.Location = new Point(0, 163);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.ReadOnly = true;
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.RowTemplate.Height = 29;
            dgvDepartment.Size = new Size(903, 546);
            dgvDepartment.TabIndex = 14;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(567, 11);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 13;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(677, 11);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 12;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(298, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(22, 11);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 10;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(27, 50);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(253, 28);
            cbSearch.TabIndex = 16;
            cbSearch.Text = "Chọn mục muốn tìm kiếm";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // btnFindAll
            // 
            btnFindAll.Location = new Point(416, 11);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 26;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // DepartmentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnFindAll);
            Controls.Add(cbSearch);
            Controls.Add(deleteBtn);
            Controls.Add(dgvDepartment);
            Controls.Add(addBtn);
            Controls.Add(updateBtn);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Name = "DepartmentPage";
            Size = new Size(903, 709);
            Load += DepartmentPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteBtn;
        private DataGridView dgvDepartment;
        private Button addBtn;
        private Button updateBtn;
        private Button btnSearch;
        private TextBox tbSearch;
        private ComboBox cbSearch;
        private Button btnFindAll;
    }
}
