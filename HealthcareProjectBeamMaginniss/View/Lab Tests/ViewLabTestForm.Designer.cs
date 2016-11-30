namespace HealthcareProjectBeamMaginniss.View.Lab_Tests
{
    /// <summary>
    /// Allows viewing of a lab test and its results
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnAddUpdateResult = new System.Windows.Forms.Button();
            this.btnViewResult = new System.Windows.Forms.Button();
            this.btnOrderTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 16);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(581, 308);
            this.dataGridView.TabIndex = 0;
            // 
            // btnAddUpdateResult
            // 
            this.btnAddUpdateResult.Location = new System.Drawing.Point(607, 52);
            this.btnAddUpdateResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUpdateResult.Name = "btnAddUpdateResult";
            this.btnAddUpdateResult.Size = new System.Drawing.Size(112, 46);
            this.btnAddUpdateResult.TabIndex = 1;
            this.btnAddUpdateResult.Text = "Add/Update Result";
            this.btnAddUpdateResult.UseVisualStyleBackColor = true;
            this.btnAddUpdateResult.Click += new System.EventHandler(this.btnAddUpdateResult_Click);
            // 
            // btnViewResult
            // 
            this.btnViewResult.Location = new System.Drawing.Point(607, 16);
            this.btnViewResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(112, 28);
            this.btnViewResult.TabIndex = 2;
            this.btnViewResult.Text = "View Result";
            this.btnViewResult.UseVisualStyleBackColor = true;
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // btnOrderTest
            // 
            this.btnOrderTest.Location = new System.Drawing.Point(607, 295);
            this.btnOrderTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrderTest.Name = "btnOrderTest";
            this.btnOrderTest.Size = new System.Drawing.Size(112, 28);
            this.btnOrderTest.TabIndex = 3;
            this.btnOrderTest.Text = "Order Test";
            this.btnOrderTest.UseVisualStyleBackColor = true;
            this.btnOrderTest.Click += new System.EventHandler(this.btnOrderTest_Click);
            // 
            // ViewLabTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 338);
            this.Controls.Add(this.btnOrderTest);
            this.Controls.Add(this.btnViewResult);
            this.Controls.Add(this.btnAddUpdateResult);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewLabTestForm";
            this.Text = "Lab Tests ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnAddUpdateResult;
        private System.Windows.Forms.Button btnViewResult;
        private System.Windows.Forms.Button btnOrderTest;
    }
}