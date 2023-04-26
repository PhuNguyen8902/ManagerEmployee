namespace EmployeesManagement.userControl.UserControlManager
{
    partial class employeePage
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
            tbSearch = new TextBox();
            btnSearch = new Button();
            deleteBtn = new Button();
            addBtn = new Button();
            updateBtn = new Button();
            btnExportExcel = new Button();
            dgvEmployee = new DataGridView();
            btnDetail = new Button();
            btnEmail = new Button();
            btnFindAll = new Button();
            cbSearchGender = new ComboBox();
            cbSearch = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(21, 19);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(297, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(793, 17);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(573, 19);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 11;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(683, 19);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 10;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(10, 120);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(120, 29);
            btnExportExcel.TabIndex = 10;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
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
            dgvEmployee.TabIndex = 13;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(793, 128);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(94, 29);
            btnDetail.TabIndex = 14;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(174, 120);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(120, 29);
            btnEmail.TabIndex = 29;
            btnEmail.Text = "Send Email";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // btnFindAll
            // 
            btnFindAll.Location = new Point(411, 19);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 33;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // cbSearchGender
            // 
            cbSearchGender.FormattingEnabled = true;
            cbSearchGender.Location = new Point(21, 17);
            cbSearchGender.Name = "cbSearchGender";
            cbSearchGender.Size = new Size(258, 28);
            cbSearchGender.TabIndex = 31;
            cbSearchGender.Text = "Select the geder";
            cbSearchGender.Visible = false;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(21, 54);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(258, 28);
            cbSearch.TabIndex = 30;
            cbSearch.Text = "Select the item you want to search";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // employeePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnFindAll);
            Controls.Add(cbSearchGender);
            Controls.Add(cbSearch);
            Controls.Add(btnEmail);
            Controls.Add(btnDetail);
            Controls.Add(btnExportExcel);
            Controls.Add(dgvEmployee);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(updateBtn);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Name = "employeePage";
            Size = new Size(903, 709);
            Load += employeePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSearch;
        private Button btnSearch;
        private Button deleteBtn;
        private Button addBtn;
        private Button updateBtn;
        private Button btnExportExcel;
        private DataGridView dgvEmployee;
        private Button btnDetail;
        private Button btnEmail;
        private Button btnFindAll;
        private ComboBox cbSearchGender;
        private ComboBox cbSearch;
    }
}
