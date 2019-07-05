namespace Epam.Talalaykina.SummerPractice.Task1
{
    partial class PersonalAreaForm
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
            this.userInfo = new System.Windows.Forms.Label();
            this.registrationInfo = new System.Windows.Forms.Label();
            this.changeUserInfoButton = new System.Windows.Forms.Button();
            this.changeRegistrationInfoButton = new System.Windows.Forms.Button();
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.searchStoreByNameButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addRatingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Location = new System.Drawing.Point(22, 23);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(46, 17);
            this.userInfo.TabIndex = 0;
            this.userInfo.Text = "label1";
            // 
            // registrationInfo
            // 
            this.registrationInfo.AutoSize = true;
            this.registrationInfo.Location = new System.Drawing.Point(22, 75);
            this.registrationInfo.Name = "registrationInfo";
            this.registrationInfo.Size = new System.Drawing.Size(46, 17);
            this.registrationInfo.TabIndex = 1;
            this.registrationInfo.Text = "label2";
            // 
            // changeUserInfoButton
            // 
            this.changeUserInfoButton.Location = new System.Drawing.Point(849, 17);
            this.changeUserInfoButton.Name = "changeUserInfoButton";
            this.changeUserInfoButton.Size = new System.Drawing.Size(75, 23);
            this.changeUserInfoButton.TabIndex = 2;
            this.changeUserInfoButton.Text = "Change";
            this.changeUserInfoButton.UseVisualStyleBackColor = true;
            this.changeUserInfoButton.Click += new System.EventHandler(this.changeUserInfoButton_Click);
            // 
            // changeRegistrationInfoButton
            // 
            this.changeRegistrationInfoButton.Location = new System.Drawing.Point(849, 69);
            this.changeRegistrationInfoButton.Name = "changeRegistrationInfoButton";
            this.changeRegistrationInfoButton.Size = new System.Drawing.Size(75, 23);
            this.changeRegistrationInfoButton.TabIndex = 3;
            this.changeRegistrationInfoButton.Text = "Change";
            this.changeRegistrationInfoButton.UseVisualStyleBackColor = true;
            this.changeRegistrationInfoButton.Click += new System.EventHandler(this.changeRegistrationInfoButton_Click);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Location = new System.Drawing.Point(25, 167);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(146, 32);
            this.deleteAccountButton.TabIndex = 4;
            this.deleteAccountButton.Text = "Delete account";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // searchStoreByNameButton
            // 
            this.searchStoreByNameButton.Location = new System.Drawing.Point(759, 112);
            this.searchStoreByNameButton.Name = "searchStoreByNameButton";
            this.searchStoreByNameButton.Size = new System.Drawing.Size(165, 32);
            this.searchStoreByNameButton.TabIndex = 5;
            this.searchStoreByNameButton.Text = "Search store by name";
            this.searchStoreByNameButton.UseVisualStyleBackColor = true;
            this.searchStoreByNameButton.Click += new System.EventHandler(this.searchStoreByNameButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(25, 112);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(146, 32);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update information";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addRatingButton
            // 
            this.addRatingButton.Location = new System.Drawing.Point(759, 167);
            this.addRatingButton.Name = "addRatingButton";
            this.addRatingButton.Size = new System.Drawing.Size(165, 32);
            this.addRatingButton.TabIndex = 7;
            this.addRatingButton.Text = "Add store rating";
            this.addRatingButton.UseVisualStyleBackColor = true;
            this.addRatingButton.Click += new System.EventHandler(this.addRatingButton_Click);
            // 
            // PersonalAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 223);
            this.Controls.Add(this.addRatingButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchStoreByNameButton);
            this.Controls.Add(this.deleteAccountButton);
            this.Controls.Add(this.changeRegistrationInfoButton);
            this.Controls.Add(this.changeUserInfoButton);
            this.Controls.Add(this.registrationInfo);
            this.Controls.Add(this.userInfo);
            this.MaximumSize = new System.Drawing.Size(944, 255);
            this.MinimumSize = new System.Drawing.Size(944, 255);
            this.Name = "PersonalAreaForm";
            this.Text = "PersonalAreaForm";
            this.Load += new System.EventHandler(this.PersonalAreaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.Label registrationInfo;
        private System.Windows.Forms.Button changeUserInfoButton;
        private System.Windows.Forms.Button changeRegistrationInfoButton;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Button searchStoreByNameButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addRatingButton;
    }
}