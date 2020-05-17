namespace AsyncOperations.Examples
{
    partial class ExamplesForm
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
            this.CategoryProjectionsAsynComboBox = new System.Windows.Forms.ComboBox();
            this.LoadProjectsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LoadWithoutProjectsButton = new System.Windows.Forms.Button();
            this.CategoryNoProjectionsAsynComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConventionalLoadButton = new System.Windows.Forms.Button();
            this.CategoryConventionalComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ProductProjectionButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ConventionalProjectionsLoadButton = new System.Windows.Forms.Button();
            this.CategoryConventionalProjectionsComboBox = new System.Windows.Forms.ComboBox();
            this.TypicalLoadButton = new System.Windows.Forms.Button();
            this.TypicalComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryProjectionsAsynComboBox
            // 
            this.CategoryProjectionsAsynComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryProjectionsAsynComboBox.FormattingEnabled = true;
            this.CategoryProjectionsAsynComboBox.Location = new System.Drawing.Point(23, 21);
            this.CategoryProjectionsAsynComboBox.Name = "CategoryProjectionsAsynComboBox";
            this.CategoryProjectionsAsynComboBox.Size = new System.Drawing.Size(190, 21);
            this.CategoryProjectionsAsynComboBox.TabIndex = 1;
            // 
            // LoadProjectsButton
            // 
            this.LoadProjectsButton.Location = new System.Drawing.Point(233, 19);
            this.LoadProjectsButton.Name = "LoadProjectsButton";
            this.LoadProjectsButton.Size = new System.Drawing.Size(75, 23);
            this.LoadProjectsButton.TabIndex = 2;
            this.LoadProjectsButton.Text = "Load";
            this.LoadProjectsButton.UseVisualStyleBackColor = true;
            this.LoadProjectsButton.Click += new System.EventHandler(this.LoadProjectsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadProjectsButton);
            this.groupBox1.Controls.Add(this.CategoryProjectionsAsynComboBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category async projections";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LoadWithoutProjectsButton);
            this.groupBox2.Controls.Add(this.CategoryNoProjectionsAsynComboBox);
            this.groupBox2.Location = new System.Drawing.Point(15, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category async without projections";
            // 
            // LoadWithoutProjectsButton
            // 
            this.LoadWithoutProjectsButton.Location = new System.Drawing.Point(233, 19);
            this.LoadWithoutProjectsButton.Name = "LoadWithoutProjectsButton";
            this.LoadWithoutProjectsButton.Size = new System.Drawing.Size(75, 23);
            this.LoadWithoutProjectsButton.TabIndex = 2;
            this.LoadWithoutProjectsButton.Text = "Load";
            this.LoadWithoutProjectsButton.UseVisualStyleBackColor = true;
            this.LoadWithoutProjectsButton.Click += new System.EventHandler(this.LoadWithoutProjectsButton_Click);
            // 
            // CategoryNoProjectionsAsynComboBox
            // 
            this.CategoryNoProjectionsAsynComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryNoProjectionsAsynComboBox.FormattingEnabled = true;
            this.CategoryNoProjectionsAsynComboBox.Location = new System.Drawing.Point(23, 21);
            this.CategoryNoProjectionsAsynComboBox.Name = "CategoryNoProjectionsAsynComboBox";
            this.CategoryNoProjectionsAsynComboBox.Size = new System.Drawing.Size(190, 21);
            this.CategoryNoProjectionsAsynComboBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ConventionalLoadButton);
            this.groupBox3.Controls.Add(this.CategoryConventionalComboBox);
            this.groupBox3.Location = new System.Drawing.Point(15, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 56);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category sync no projections";
            // 
            // ConventionalLoadButton
            // 
            this.ConventionalLoadButton.Location = new System.Drawing.Point(233, 19);
            this.ConventionalLoadButton.Name = "ConventionalLoadButton";
            this.ConventionalLoadButton.Size = new System.Drawing.Size(75, 23);
            this.ConventionalLoadButton.TabIndex = 2;
            this.ConventionalLoadButton.Text = "Load";
            this.ConventionalLoadButton.UseVisualStyleBackColor = true;
            this.ConventionalLoadButton.Click += new System.EventHandler(this.ConventionalLoadButton_Click);
            // 
            // CategoryConventionalComboBox
            // 
            this.CategoryConventionalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryConventionalComboBox.FormattingEnabled = true;
            this.CategoryConventionalComboBox.Location = new System.Drawing.Point(23, 21);
            this.CategoryConventionalComboBox.Name = "CategoryConventionalComboBox";
            this.CategoryConventionalComboBox.Size = new System.Drawing.Size(190, 21);
            this.CategoryConventionalComboBox.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 317);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Category examples";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.OrdersButton);
            this.groupBox5.Location = new System.Drawing.Point(401, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 85);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Orders";
            // 
            // OrdersButton
            // 
            this.OrdersButton.Location = new System.Drawing.Point(17, 22);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(75, 23);
            this.OrdersButton.TabIndex = 0;
            this.OrdersButton.Text = "Load";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ProductProjectionButton);
            this.groupBox6.Location = new System.Drawing.Point(401, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(178, 85);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Products projection";
            // 
            // ProductProjectionButton
            // 
            this.ProductProjectionButton.Location = new System.Drawing.Point(17, 22);
            this.ProductProjectionButton.Name = "ProductProjectionButton";
            this.ProductProjectionButton.Size = new System.Drawing.Size(75, 23);
            this.ProductProjectionButton.TabIndex = 0;
            this.ProductProjectionButton.Text = "Load";
            this.ProductProjectionButton.UseVisualStyleBackColor = true;
            this.ProductProjectionButton.Click += new System.EventHandler(this.ProductProjectionButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ConventionalProjectionsLoadButton);
            this.groupBox7.Controls.Add(this.CategoryConventionalProjectionsComboBox);
            this.groupBox7.Location = new System.Drawing.Point(15, 233);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(328, 56);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Category sync with projections";
            // 
            // ConventionalProjectionsLoadButton
            // 
            this.ConventionalProjectionsLoadButton.Location = new System.Drawing.Point(233, 19);
            this.ConventionalProjectionsLoadButton.Name = "ConventionalProjectionsLoadButton";
            this.ConventionalProjectionsLoadButton.Size = new System.Drawing.Size(75, 23);
            this.ConventionalProjectionsLoadButton.TabIndex = 2;
            this.ConventionalProjectionsLoadButton.Text = "Load";
            this.ConventionalProjectionsLoadButton.UseVisualStyleBackColor = true;
            this.ConventionalProjectionsLoadButton.Click += new System.EventHandler(this.ConventionalProjectionsLoadButton_Click);
            // 
            // CategoryConventionalProjectionsComboBox
            // 
            this.CategoryConventionalProjectionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryConventionalProjectionsComboBox.FormattingEnabled = true;
            this.CategoryConventionalProjectionsComboBox.Location = new System.Drawing.Point(23, 21);
            this.CategoryConventionalProjectionsComboBox.Name = "CategoryConventionalProjectionsComboBox";
            this.CategoryConventionalProjectionsComboBox.Size = new System.Drawing.Size(190, 21);
            this.CategoryConventionalProjectionsComboBox.TabIndex = 1;
            // 
            // TypicalLoadButton
            // 
            this.TypicalLoadButton.Location = new System.Drawing.Point(401, 216);
            this.TypicalLoadButton.Name = "TypicalLoadButton";
            this.TypicalLoadButton.Size = new System.Drawing.Size(175, 23);
            this.TypicalLoadButton.TabIndex = 9;
            this.TypicalLoadButton.Text = "Typical";
            this.TypicalLoadButton.UseVisualStyleBackColor = true;
            this.TypicalLoadButton.Click += new System.EventHandler(this.TypicalLoadButton_Click);
            // 
            // TypicalComboBox
            // 
            this.TypicalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypicalComboBox.FormattingEnabled = true;
            this.TypicalComboBox.Location = new System.Drawing.Point(401, 245);
            this.TypicalComboBox.Name = "TypicalComboBox";
            this.TypicalComboBox.Size = new System.Drawing.Size(178, 21);
            this.TypicalComboBox.TabIndex = 3;
            // 
            // ExamplesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 341);
            this.Controls.Add(this.TypicalComboBox);
            this.Controls.Add(this.TypicalLoadButton);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExamplesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryProjectionsAsynComboBox;
        private System.Windows.Forms.Button LoadProjectsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LoadWithoutProjectsButton;
        private System.Windows.Forms.ComboBox CategoryNoProjectionsAsynComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ConventionalLoadButton;
        private System.Windows.Forms.ComboBox CategoryConventionalComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button ProductProjectionButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button ConventionalProjectionsLoadButton;
        private System.Windows.Forms.ComboBox CategoryConventionalProjectionsComboBox;
        private System.Windows.Forms.Button TypicalLoadButton;
        private System.Windows.Forms.ComboBox TypicalComboBox;
    }
}