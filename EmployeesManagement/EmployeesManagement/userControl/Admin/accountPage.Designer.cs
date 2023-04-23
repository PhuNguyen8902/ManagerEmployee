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
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            SuspendLayout();
            // 
            // btnFindAll
            // 
            btnFindAll.Location = new Point(257, 116);
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
            // accountPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(assignBtn);
            Controls.Add(btnFindAll);
            Controls.Add(dgvAccount);
            Name = "accountPage";
            Size = new Size(903, 709);
            Load += accountPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFindAll;
        private DataGridView dgvAccount;
        private Button assignBtn;
    }
}
