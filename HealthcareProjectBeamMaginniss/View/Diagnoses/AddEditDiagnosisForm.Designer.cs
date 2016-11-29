namespace HealthcareProjectBeamMaginniss.View.Diagnoses
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.btnSubmit.Location = new System.Drawing.Point(219, 278);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(61, 278);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLabTestName
            // 
            this.lblLabTestName.AutoSize = true;
            this.lblLabTestName.Location = new System.Drawing.Point(24, 18);
            this.lblLabTestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLabTestName.Name = "lblLabTestName";
            this.lblLabTestName.Size = new System.Drawing.Size(70, 17);
            this.lblLabTestName.TabIndex = 28;
            this.lblLabTestName.Text = "Diagnosis";
            // 
            // txtLabTestName
            // 
            this.txtLabTestName.Location = new System.Drawing.Point(116, 15);
            this.txtLabTestName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLabTestName.Multiline = true;
            this.txtLabTestName.Name = "txtLabTestName";
            this.txtLabTestName.Size = new System.Drawing.Size(237, 203);
            this.txtLabTestName.TabIndex = 27;
            // 
            // chkFinal
            // 
            this.chkFinal.AutoSize = true;
            this.chkFinal.Location = new System.Drawing.Point(121, 226);
            this.chkFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFinal.Name = "chkFinal";
            this.chkFinal.Size = new System.Drawing.Size(134, 21);
            this.chkFinal.TabIndex = 31;
            this.chkFinal.Text = "Final Diagnosis?";
            this.chkFinal.UseVisualStyleBackColor = true;
            // 
            // AddEditDiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.chkFinal);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLabTestName);
            this.Controls.Add(this.txtLabTestName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEditDiagnosisForm";
            this.Text = "Diagnosis Info";
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