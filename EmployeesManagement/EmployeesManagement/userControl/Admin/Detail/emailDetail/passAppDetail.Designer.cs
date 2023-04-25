namespace EmployeesManagement.userControl.Admin.Detail.emailDetail
{
    partial class passAppDetail
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
            btnConfirm = new Button();
            tbPassApp = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 56);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Pass App:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(367, 107);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbPassApp
            // 
            tbPassApp.Location = new Point(138, 53);
            tbPassApp.Name = "tbPassApp";
            tbPassApp.Size = new Size(261, 27);
            tbPassApp.TabIndex = 2;
            tbPassApp.UseSystemPasswordChar = true;
            tbPassApp.TextChanged += tbPassApp_TextChanged;
            // 
            // passAppDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 161);
            Controls.Add(tbPassApp);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Name = "passAppDetail";
            Text = "passAppDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConfirm;
        private TextBox tbPassApp;
    }
}