namespace HealthcareProjectBeamMaginniss.View
{
    partial class QueryForm
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
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.AcceptsReturn = true;
            this.textBoxQuery.AcceptsTab = true;
            this.textBoxQuery.AllowDrop = true;
            this.textBoxQuery.Location = new System.Drawing.Point(16, 382);
            this.textBoxQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(1144, 358);
            this.textBoxQuery.TabIndex = 0;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(956, 748);
            this.buttonExecute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(205, 63);
            this.buttonExecute.TabIndex = 1;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(17, 748);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(205, 63);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 16);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1144, 358);
            this.dataGridView.TabIndex = 3;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(333, 761);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(150, 31);
            this.labelWelcome.TabIndex = 4;
            this.labelWelcome.Text = "Welcome, ";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 826);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.textBoxQuery);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QueryForm";
            this.Text = "Admin Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelWelcome;
    }
}