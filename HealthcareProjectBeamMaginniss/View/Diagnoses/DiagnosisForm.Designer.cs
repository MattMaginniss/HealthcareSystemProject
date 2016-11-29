namespace HealthcareProjectBeamMaginniss.View.Diagnoses
{
    partial class DiagnosisForm
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
            this.components = new System.ComponentModel.Container();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDiagnosis = new System.Windows.Forms.DataGridView();
            this.cs3230f16bDataSet = new HealthcareProjectBeamMaginniss.cs3230f16bDataSet();
            this.cs3230f16bDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3230f16bDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3230f16bDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(529, 310);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(300, 310);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDiagnosis
            // 
            this.dgvDiagnosis.AllowUserToAddRows = false;
            this.dgvDiagnosis.AllowUserToDeleteRows = false;
            this.dgvDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosis.Location = new System.Drawing.Point(17, 16);
            this.dgvDiagnosis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDiagnosis.Name = "dgvDiagnosis";
            this.dgvDiagnosis.ReadOnly = true;
            this.dgvDiagnosis.Size = new System.Drawing.Size(895, 287);
            this.dgvDiagnosis.TabIndex = 31;
            // 
            // cs3230f16bDataSet
            // 
            this.cs3230f16bDataSet.DataSetName = "cs3230f16bDataSet";
            this.cs3230f16bDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cs3230f16bDataSetBindingSource
            // 
            this.cs3230f16bDataSetBindingSource.DataSource = this.cs3230f16bDataSet;
            this.cs3230f16bDataSetBindingSource.Position = 0;
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 353);
            this.Controls.Add(this.dgvDiagnosis);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DiagnosisForm";
            this.Text = "Diagnosies";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3230f16bDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cs3230f16bDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvDiagnosis;
        private cs3230f16bDataSet cs3230f16bDataSet;
        private System.Windows.Forms.BindingSource cs3230f16bDataSetBindingSource;
    }
}