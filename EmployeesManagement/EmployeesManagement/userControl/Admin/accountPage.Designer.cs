namespace EmployeesManagement.userControl.Admin
{
    partial class accountPage
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
            btnFindAll = new Button();
            dgvAccount = new DataGridView();
            assignBtn = new Button();
            removeBtn = new Button();
            cbSearch = new ComboBox();
            btnSearch1 = new Button();
            tbSearch = new TextBox();
            btnSearch2 = new Button();
            cbSearchPosition = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            SuspendLayout();
            // 
            // btnFindAll
            // 
            btnFindAll.Location = new Point(421, 12);
            btnFindAll.Name = "btnFindAll";
            btnFindAll.Size = new Size(94, 29);
            btnFindAll.TabIndex = 31;
            btnFindAll.Text = "Find All";
            btnFindAll.UseVisualStyleBackColor = true;
            btnFindAll.Click += btnFindAll_Click;
            // 
            // dgvAccount
            // 
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Dock = DockStyle.Bottom;
            dgvAccount.Location = new Point(0, 163);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.ReadOnly = true;
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 29;
            dgvAccount.Size = new Size(903, 546);
            dgvAccount.TabIndex = 29;
            dgvAccount.CellContentClick += dgvAccount_CellContentClick;
            // 
            // assignBtn
            // 
            assignBtn.Location = new Point(31, 116);
            assignBtn.Name = "assignBtn";
            assignBtn.Size = new Size(169, 29);
            assignBtn.TabIndex = 32;
            assignBtn.Text = "Assign employee id";
            assignBtn.UseVisualStyleBackColor = true;
            assignBtn.Click += assignBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(270, 116);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(169, 29);
            removeBtn.TabIndex = 33;
            removeBtn.Text = "Remove employee id";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(31, 50);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(258, 28);
            cbSearch.TabIndex = 38;
            cbSearch.Text = "Select the item you want to search";
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // btnSearch1
            // 
            btnSearch1.Location = new Point(307, 12);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(94, 29);
            btnSearch1.TabIndex = 37;
            btnSearch1.Text = "Search";
            btnSearch1.UseVisualStyleBackColor = true;
            btnSearch1.Click += btnSearch1_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(31, 12);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(258, 27);
            tbSearch.TabIndex = 36;
            // 
            // btnSearch2
            // 
            btnSearch2.Location = new Point(307, 12);
            btnSearch2.Name = "btnSearch2";
            btnSearch2.Size = new Size(94, 29);
            btnSearch2.TabIndex = 39;
            btnSearch2.Text = "Search";
            btnSearch2.UseVisualStyleBackColor = true;
            btnSearch2.Visible = false;
            btnSearch2.Click += btnSearch2_Click;
            // 
            // cbSearchPosition
            // 
            cbSearchPosition.FormattingEnabled = true;
            cbSearchPosition.Location = new Point(31, 11);
            cbSearchPosition.Name = "cbSearchPosition";
            cbSearchPosition.Size = new Size(258, 28);
            cbSearchPosition.TabIndex = 40;
            cbSearchPosition.Text = "Select the item";
            cbSearchPosition.Visible = false;
            // 
            // accountPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbSearchPosition);
            Controls.Add(btnSearch2);
            Controls.Add(cbSearch);
            Controls.Add(btnSearch1);
            Controls.Add(tbSearch);
            Controls.Add(removeBtn);
            Controls.Add(assignBtn);
            Controls.Add(btnFindAll);
            Controls.Add(dgvAccount);
            Name = "accountPage";
            Size = new Size(903, 709);
            Load += accountPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFindAll;
        private DataGridView dgvAccount;
        private Button assignBtn;
        private Button removeBtn;
        private ComboBox cbSearch;
        private Button btnSearch1;
        private TextBox tbSearch;
        private Button btnSearch2;
        private ComboBox cbSearchPosition;
    }
}
