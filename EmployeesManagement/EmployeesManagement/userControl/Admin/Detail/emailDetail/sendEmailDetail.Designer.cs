namespace EmployeesManagement.userControl.Admin.Detail.emailDetail
{
    partial class sendEmailDetail
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
            button1 = new Button();
            tbSubject = new TextBox();
            tbBody = new TextBox();
            btnSelectFile = new Button();
            tbResultFile = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(262, 22);
            label1.Name = "label1";
            label1.Size = new Size(220, 41);
            label1.TabIndex = 0;
            label1.Text = "Send An Email";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(633, 395);
            button1.Name = "button1";
            button1.Size = new Size(114, 43);
            button1.TabIndex = 2;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tbSubject
            // 
            tbSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSubject.Location = new Point(37, 78);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(710, 34);
            tbSubject.TabIndex = 3;
            tbSubject.Enter += tbSubject_Enter;
            tbSubject.Leave += tbSubject_Leave;
            // 
            // tbBody
            // 
            tbBody.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbBody.Location = new Point(37, 135);
            tbBody.Multiline = true;
            tbBody.Name = "tbBody";
            tbBody.Size = new Size(710, 245);
            tbBody.TabIndex = 4;
            tbBody.Enter += tbBody_Enter;
            tbBody.Leave += tbBody_Leave;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Cursor = Cursors.Hand;
            btnSelectFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectFile.Location = new Point(37, 395);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(134, 43);
            btnSelectFile.TabIndex = 5;
            btnSelectFile.Text = "Select file";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // tbResultFile
            // 
            tbResultFile.Enabled = false;
            tbResultFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbResultFile.Location = new Point(177, 404);
            tbResultFile.Name = "tbResultFile";
            tbResultFile.Size = new Size(420, 30);
            tbResultFile.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // sendEmailDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbResultFile);
            Controls.Add(btnSelectFile);
            Controls.Add(tbBody);
            Controls.Add(tbSubject);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "sendEmailDetail";
            Text = "sendEmailDetail";
            Load += sendEmailDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox tbSubject;
        private TextBox tbBody;
        private Button btnSelectFile;
        private TextBox tbResultFile;
        private OpenFileDialog openFileDialog1;
    }
}