namespace EmployeesManagement.userControl.Admin.Detail.emailDetail
{
    partial class chooseSend
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
            label1 = new Label();
            label2 = new Label();
            cbType = new ComboBox();
            tbResult = new TextBox();
            btnSearch = new Button();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 71);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 0;
            label1.Text = "Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 176);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 1;
            label2.Text = "Search:";
            // 
            // cbType
            // 
            cbType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(190, 68);
            cbType.Name = "cbType";
            cbType.Size = new Size(290, 36);
            cbType.TabIndex = 2;
            cbType.Text = "Select type";
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // tbResult
            // 
            tbResult.Enabled = false;
            tbResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbResult.Location = new Point(190, 173);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(290, 34);
            tbResult.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(495, 173);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 37);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Enabled = false;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.Location = new Point(623, 261);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 37);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // chooseSend
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
            Name = "chooseSend";
            Text = "chooseSend";
            Load += chooseSend_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbType;
        private TextBox tbResult;
        private Button btnSearch;
        private Button btnConfirm;
    }
}