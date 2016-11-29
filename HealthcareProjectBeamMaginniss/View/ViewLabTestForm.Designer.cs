namespace HealthcareProjectBeamMaginniss.View
{
    partial class ViewLabTestForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddUpdateResult = new System.Windows.Forms.Button();
            this.btnViewResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(436, 250);
            this.dataGridView.TabIndex = 0;
            // 
            // btnAddUpdateResult
            // 
            this.btnAddUpdateResult.Location = new System.Drawing.Point(455, 42);
            this.btnAddUpdateResult.Name = "btnAddUpdateResult";
            this.btnAddUpdateResult.Size = new System.Drawing.Size(84, 37);
            this.btnAddUpdateResult.TabIndex = 1;
            this.btnAddUpdateResult.Text = "Add/Update Result";
            this.btnAddUpdateResult.UseVisualStyleBackColor = true;
            // 
            // btnViewResult
            // 
            this.btnViewResult.Location = new System.Drawing.Point(455, 13);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(84, 23);
            this.btnViewResult.TabIndex = 2;
            this.btnViewResult.Text = "View Result";
            this.btnViewResult.UseVisualStyleBackColor = true;
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // ViewLabTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 275);
            this.Controls.Add(this.btnViewResult);
            this.Controls.Add(this.btnAddUpdateResult);
            this.Controls.Add(this.dataGridView);
            this.Name = "ViewLabTestForm";
            this.Text = "ViewLabTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddUpdateResult;
        private System.Windows.Forms.Button btnViewResult;
    }
}