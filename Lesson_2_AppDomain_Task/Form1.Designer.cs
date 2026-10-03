namespace Lesson_2_AppDomain_Task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFrom = new Label();
            txtFrom = new TextBox();
            btnFrom = new Button();
            lblTo = new Label();
            txtTo = new TextBox();
            btnTo = new Button();
            progressBar1 = new ProgressBar();
            btnSuspend = new Button();
            btnResume = new Button();
            btnAbort = new Button();
            btnCopy = new Button();
            SuspendLayout();
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(124, 64);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(43, 20);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(173, 57);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(167, 27);
            txtFrom.TabIndex = 1;
            // 
            // btnFrom
            // 
            btnFrom.Location = new Point(355, 55);
            btnFrom.Name = "btnFrom";
            btnFrom.Size = new Size(94, 29);
            btnFrom.TabIndex = 2;
            btnFrom.Text = "File...";
            btnFrom.UseVisualStyleBackColor = true;
            btnFrom.Click += btnFrom_Click;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(142, 109);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(25, 20);
            lblTo.TabIndex = 3;
            lblTo.Text = "To";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(173, 109);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(167, 27);
            txtTo.TabIndex = 4;
            // 
            // btnTo
            // 
            btnTo.Location = new Point(355, 109);
            btnTo.Name = "btnTo";
            btnTo.Size = new Size(94, 29);
            btnTo.TabIndex = 5;
            btnTo.Text = "File...";
            btnTo.UseVisualStyleBackColor = true;
            btnTo.Click += btnTo_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(84, 189);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(156, 29);
            progressBar1.TabIndex = 6;
            // 
            // btnSuspend
            // 
            btnSuspend.Location = new Point(246, 189);
            btnSuspend.Name = "btnSuspend";
            btnSuspend.Size = new Size(94, 29);
            btnSuspend.TabIndex = 7;
            btnSuspend.Text = "Suspend";
            btnSuspend.UseVisualStyleBackColor = true;
            btnSuspend.Click += btnSuspend_Click;
            // 
            // btnResume
            // 
            btnResume.Location = new Point(346, 189);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(94, 29);
            btnResume.TabIndex = 8;
            btnResume.Text = "Resume";
            btnResume.UseVisualStyleBackColor = true;
            btnResume.Click += btnResume_Click;
            // 
            // btnAbort
            // 
            btnAbort.Location = new Point(446, 189);
            btnAbort.Name = "btnAbort";
            btnAbort.Size = new Size(94, 29);
            btnAbort.TabIndex = 9;
            btnAbort.Text = "Abort";
            btnAbort.UseVisualStyleBackColor = true;
            btnAbort.Click += btnAbort_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(546, 189);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(94, 29);
            btnCopy.TabIndex = 10;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCopy);
            Controls.Add(btnAbort);
            Controls.Add(btnResume);
            Controls.Add(btnSuspend);
            Controls.Add(progressBar1);
            Controls.Add(btnTo);
            Controls.Add(txtTo);
            Controls.Add(lblTo);
            Controls.Add(btnFrom);
            Controls.Add(txtFrom);
            Controls.Add(lblFrom);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFrom;
        private TextBox txtFrom;
        private Button btnFrom;
        private Label lblTo;
        private TextBox txtTo;
        private Button btnTo;
        private ProgressBar progressBar1;
        private Button btnSuspend;
        private Button btnResume;
        private Button btnAbort;
        private Button btnCopy;
    }
}
