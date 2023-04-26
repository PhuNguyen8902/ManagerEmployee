namespace EmployeesManagement.userControl
{
    partial class salaryPage
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
            dgvSalary = new DataGridView();
            addBtn = new Button();
            updateBtn = new Button();
            cbSearch = new ComboBox();
            btnSearch = new Button();
            tbSearch = new TextBox();
            btnFindAll = new Button();
            cbSearchLevel = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSalary).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.Location = new Point(787, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 21;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dgvSalary
            // 
            dgvSalary.AllowUserToAddRows = false;
            dgvSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalary.Dock = DockStyle.Bottom;
            dgvSalary.Location = new Point(0, 163);
            dgvSalary.Name = "dgvSalary";
            dgvSalary.ReadOnly = true;
            dgvSalary.RowHeadersWidth = 51;
            dgvSalary.RowTemplate.Height = 29;
            dgvSalary.Size = new Size(903, 546);
            dgvSalary.TabIndex = 20;
            // 
            // addBtn
            // 
            addBtn.Cursor = Cursors.Hand;
            addBtn.Location = new Point(567, 6);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 19;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Cursor = Cursors.Hand;
            updateBtn.Location = new Point(677, 6);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 18;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(36, 47);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(253, 28);
            cbSearch.TabIndex = 24;
            cbSearch.Text = "Chọn mục muốn tìm kiếm";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(307, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(31, 8);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 22;
            // 
            // btnFindAll
            // 
            btnFindAll.Cursor = Cursors.Hand;
            btnFindAll.Location = new Point(426, 8);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 26;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // cbSearchLevel
            // 
            cbSearchLevel.FormattingEnabled = true;
            cbSearchLevel.Location = new Point(31, 8);
            cbSearchLevel.Name = "cbSearchLevel";
            cbSearchLevel.Size = new Size(253, 28);
            cbSearchLevel.TabIndex = 27;
            cbSearchLevel.Visible = false;
            // 
            // salaryPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbSearchLevel);
            Controls.Add(btnFindAll);
            Controls.Add(cbSearch);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(deleteBtn);
            Controls.Add(dgvSalary);
            Controls.Add(addBtn);
            Controls.Add(updateBtn);
            Name = "salaryPage";
            Size = new Size(903, 709);
            Load += salaryPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteBtn;
        private DataGridView dgvSalary;
        private Button addBtn;
        private Button updateBtn;
        private ComboBox cbSearch;
        private Button btnSearch;
        private TextBox tbSearch;
        private Button btnFindAll;
        private ComboBox cbSearchLevel;
    }
}
