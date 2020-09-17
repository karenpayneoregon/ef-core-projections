namespace AsyncOperations.Examples
{
    partial class EmployeesForm
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
            this.EmployeeProjectedDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProjectedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeProjectedDataGridView
            // 
            this.EmployeeProjectedDataGridView.AllowUserToAddRows = false;
            this.EmployeeProjectedDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeProjectedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeProjectedDataGridView.Location = new System.Drawing.Point(9, 18);
            this.EmployeeProjectedDataGridView.Name = "EmployeeProjectedDataGridView";
            this.EmployeeProjectedDataGridView.Size = new System.Drawing.Size(479, 150);
            this.EmployeeProjectedDataGridView.TabIndex = 0;
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(9, 190);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.Size = new System.Drawing.Size(479, 150);
            this.EmployeeDataGridView.TabIndex = 1;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 368);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.EmployeeProjectedDataGridView);
            this.Name = "EmployeesForm";
            this.Text = "Employees projected";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeProjectedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeProjectedDataGridView;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
    }
}