namespace EmployeesManagement.userControl.UserControlManager.Detail.emailDetail
{
    partial class manageSendMail
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
            cbSearch = new ComboBox();
            btnFindAll = new Button();
            dgvEmployee = new DataGridView();
            btnSearch = new Button();
            cbSearchGender = new ComboBox();
            tbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(22, 41);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(258, 28);
            cbSearch.TabIndex = 39;
            cbSearch.Text = "Select the item you want to search";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // btnFindAll
            // 
            btnFindAll.Cursor = Cursors.Hand;
            btnFindAll.Location = new Point(411, 7);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 38;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Dock = DockStyle.Bottom;
            dgvEmployee.Location = new Point(0, 157);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.ReadOnly = true;
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 29;
            dgvEmployee.Size = new Size(885, 505);
            dgvEmployee.TabIndex = 36;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(298, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 35;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbSearchGender
            // 
            cbSearchGender.FormattingEnabled = true;
            cbSearchGender.Location = new Point(22, 6);
            cbSearchGender.Name = "cbSearchGender";
            cbSearchGender.Size = new Size(258, 28);
            cbSearchGender.TabIndex = 41;
            cbSearchGender.Text = "Select the geder";
            cbSearchGender.Visible = false;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(22, 6);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 40;
            // 
            // manageSendMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 662);
            Controls.Add(cbSearchGender);
            Controls.Add(tbSearch);
            Controls.Add(cbSearch);
            Controls.Add(btnFindAll);
            Controls.Add(dgvEmployee);
            Controls.Add(btnSearch);
            Name = "manageSendMail";
            Text = "manageSendMail";
            Load += manageSendMail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSearch;
        private Button btnFindAll;
        private DataGridView dgvEmployee;
        private Button btnSearch;
        private ComboBox cbSearchGender;
        private TextBox tbSearch;
    }
}