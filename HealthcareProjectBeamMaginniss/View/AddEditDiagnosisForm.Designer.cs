namespace HealthcareProjectBeamMaginniss.View
{
    partial class AddEditDiagnosisForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLabTestName = new System.Windows.Forms.Label();
            this.txtLabTestName = new System.Windows.Forms.TextBox();
            this.chkFinal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(164, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(46, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLabTestName
            // 
            this.lblLabTestName.AutoSize = true;
            this.lblLabTestName.Location = new System.Drawing.Point(18, 15);
            this.lblLabTestName.Name = "lblLabTestName";
            this.lblLabTestName.Size = new System.Drawing.Size(53, 13);
            this.lblLabTestName.TabIndex = 28;
            this.lblLabTestName.Text = "Diagnosis";
            // 
            // txtLabTestName
            // 
            this.txtLabTestName.Location = new System.Drawing.Point(87, 12);
            this.txtLabTestName.Multiline = true;
            this.txtLabTestName.Name = "txtLabTestName";
            this.txtLabTestName.Size = new System.Drawing.Size(179, 166);
            this.txtLabTestName.TabIndex = 27;
            // 
            // chkFinal
            // 
            this.chkFinal.AutoSize = true;
            this.chkFinal.Location = new System.Drawing.Point(91, 184);
            this.chkFinal.Name = "chkFinal";
            this.chkFinal.Size = new System.Drawing.Size(103, 17);
            this.chkFinal.TabIndex = 31;
            this.chkFinal.Text = "Final Diagnosis?";
            this.chkFinal.UseVisualStyleBackColor = true;
            // 
            // AddEditDiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chkFinal);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLabTestName);
            this.Controls.Add(this.txtLabTestName);
            this.Name = "AddEditDiagnosisForm";
            this.Text = "AddEditDiagnosisForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLabTestName;
        private System.Windows.Forms.TextBox txtLabTestName;
        private System.Windows.Forms.CheckBox chkFinal;
    }
}