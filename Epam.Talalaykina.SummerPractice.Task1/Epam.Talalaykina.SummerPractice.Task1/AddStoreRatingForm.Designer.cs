namespace Epam.Talalaykina.SummerPractice.Task1
{
    partial class AddStoreRatingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.storeNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.assortComboBox = new System.Windows.Forms.ComboBox();
            this.pLevelComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.servRatComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store name";
            // 
            // storeNameTextBox
            // 
            this.storeNameTextBox.Location = new System.Drawing.Point(24, 34);
            this.storeNameTextBox.Name = "storeNameTextBox";
            this.storeNameTextBox.Size = new System.Drawing.Size(367, 22);
            this.storeNameTextBox.TabIndex = 1;
            this.storeNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assortment rating";
            // 
            // assortComboBox
            // 
            this.assortComboBox.FormattingEnabled = true;
            this.assortComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.assortComboBox.Location = new System.Drawing.Point(270, 68);
            this.assortComboBox.Name = "assortComboBox";
            this.assortComboBox.Size = new System.Drawing.Size(121, 24);
            this.assortComboBox.TabIndex = 3;
            // 
            // pLevelComboBox
            // 
            this.pLevelComboBox.FormattingEnabled = true;
            this.pLevelComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.pLevelComboBox.Location = new System.Drawing.Point(270, 98);
            this.pLevelComboBox.Name = "pLevelComboBox";
            this.pLevelComboBox.Size = new System.Drawing.Size(121, 24);
            this.pLevelComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price level rating";
            // 
            // servRatComboBox
            // 
            this.servRatComboBox.FormattingEnabled = true;
            this.servRatComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.servRatComboBox.Location = new System.Drawing.Point(270, 128);
            this.servRatComboBox.Name = "servRatComboBox";
            this.servRatComboBox.Size = new System.Drawing.Size(121, 24);
            this.servRatComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Service rating";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add rating";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStoreRatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.servRatComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pLevelComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.assortComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.storeNameTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(419, 255);
            this.MinimumSize = new System.Drawing.Size(419, 255);
            this.Name = "AddStoreRatingForm";
            this.Text = "AddStoreRatingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox storeNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox assortComboBox;
        private System.Windows.Forms.ComboBox pLevelComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox servRatComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}