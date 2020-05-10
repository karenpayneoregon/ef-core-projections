namespace ConsoleLoggingExample
{
    partial class Form1
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
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.GetProductsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Location = new System.Drawing.Point(13, 16);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(157, 160);
            this.CategoryListBox.TabIndex = 0;
            // 
            // GetProductsButton
            // 
            this.GetProductsButton.Location = new System.Drawing.Point(13, 190);
            this.GetProductsButton.Name = "GetProductsButton";
            this.GetProductsButton.Size = new System.Drawing.Size(157, 23);
            this.GetProductsButton.TabIndex = 1;
            this.GetProductsButton.Text = "Category products";
            this.GetProductsButton.UseVisualStyleBackColor = true;
            this.GetProductsButton.Click += new System.EventHandler(this.GetProductsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 227);
            this.Controls.Add(this.GetProductsButton);
            this.Controls.Add(this.CategoryListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.Button GetProductsButton;
    }
}

