namespace EmployeesManagement.userControl
{
    partial class projectsPage
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
            dgvProject = new DataGridView();
            addBtn = new Button();
            updateBtn = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cbSearch = new ComboBox();
            DTPSearch = new DateTimePicker();
            cbSearchActive = new ComboBox();
            btnFindAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProject).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(787, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 21;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dgvProject
            // 
            dgvProject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProject.Dock = DockStyle.Bottom;
            dgvProject.Location = new Point(0, 163);
            dgvProject.Name = "dgvProject";
            dgvProject.ReadOnly = true;
            dgvProject.RowHeadersWidth = 51;
            dgvProject.RowTemplate.Height = 29;
            dgvProject.Size = new Size(903, 546);
            dgvProject.TabIndex = 20;
            // 
            // addBtn
            // 
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
            updateBtn.Location = new Point(677, 6);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 18;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(298, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(22, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(258, 27);
            txtSearch.TabIndex = 16;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(22, 51);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(253, 28);
            cbSearch.TabIndex = 22;
            cbSearch.Text = "Chọn mục muốn tìm kiếm";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // DTPSearch
            // 
            DTPSearch.Location = new Point(22, 6);
            DTPSearch.Name = "DTPSearch";
            DTPSearch.Size = new Size(258, 27);
            DTPSearch.TabIndex = 23;
            DTPSearch.Visible = false;
            // 
            // cbSearchActive
            // 
            cbSearchActive.FormattingEnabled = true;
            cbSearchActive.Location = new Point(22, 5);
            cbSearchActive.Name = "cbSearchActive";
            cbSearchActive.Size = new Size(258, 28);
            cbSearchActive.TabIndex = 24;
            cbSearchActive.Visible = false;
            // 
            // btnFindAll
            // 
            btnFindAll.Location = new Point(415, 7);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 25;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // projectsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnFindAll);
            Controls.Add(cbSearchActive);
            Controls.Add(DTPSearch);
            Controls.Add(cbSearch);
            Controls.Add(deleteBtn);
            Controls.Add(dgvProject);
            Controls.Add(addBtn);
            Controls.Add(updateBtn);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "projectsPage";
            Size = new Size(903, 709);
            Load += projectsPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteBtn;
        private DataGridView dgvProject;
        private Button addBtn;
        private Button updateBtn;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cbSearch;
        private DateTimePicker DTPSearch;
        private ComboBox cbSearchActive;
        private Button btnFindAll;
    }
}
