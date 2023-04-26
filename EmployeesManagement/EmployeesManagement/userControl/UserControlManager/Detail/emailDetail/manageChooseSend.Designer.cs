namespace EmployeesManagement.userControl.UserControlManager.Detail.emailDetail
{
    partial class manageChooseSend
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
            btnConfirm = new Button();
            btnSearch = new Button();
            tbResult = new TextBox();
            cbType = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Enabled = false;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.Location = new Point(621, 243);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 37);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(493, 155);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 37);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbResult
            // 
            tbResult.Enabled = false;
            tbResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbResult.Location = new Point(188, 155);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(290, 34);
            tbResult.TabIndex = 9;
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(188, 50);
            cbType.Name = "cbType";
            cbType.Size = new Size(290, 36);
            cbType.TabIndex = 8;
            cbType.Text = "Select type";
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(94, 158);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 7;
            label2.Text = "Search:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(111, 53);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 6;
            label1.Text = "Type:";
            // 
            // manageChooseSend
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 310);
            Controls.Add(btnConfirm);
            Controls.Add(btnSearch);
            Controls.Add(tbResult);
            Controls.Add(cbType);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "manageChooseSend";
            Text = "manageChooseSend";
            Load += manageChooseSend_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private Button btnSearch;
        private TextBox tbResult;
        private ComboBox cbType;
        private Label label2;
        private Label label1;
    }
}