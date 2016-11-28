namespace HealthcareProjectBeamMaginniss.View
{
    partial class CreateLabTestForm
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
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(217, 42);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(45, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLabTestName
            // 
            this.lblLabTestName.AutoSize = true;
            this.lblLabTestName.Location = new System.Drawing.Point(13, 15);
            this.lblLabTestName.Name = "lblLabTestName";
            this.lblLabTestName.Size = new System.Drawing.Size(80, 13);
            this.lblLabTestName.TabIndex = 24;
            this.lblLabTestName.Text = "Lab Test Name";
            // 
            // txtLabTestName
            // 
            this.txtLabTestName.Location = new System.Drawing.Point(99, 12);
            this.txtLabTestName.Name = "txtLabTestName";
            this.txtLabTestName.Size = new System.Drawing.Size(224, 20);
            this.txtLabTestName.TabIndex = 23;
            // 
            // CreateLabTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 77);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLabTestName);
            this.Controls.Add(this.txtLabTestName);
            this.Name = "CreateLabTestForm";
            this.Text = "Create Lab Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLabTestName;
        private System.Windows.Forms.TextBox txtLabTestName;
    }
}