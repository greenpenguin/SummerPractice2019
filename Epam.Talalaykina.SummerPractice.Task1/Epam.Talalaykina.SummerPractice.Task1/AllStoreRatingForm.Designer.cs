namespace Epam.Talalaykina.SummerPractice.Task1
{
    partial class AllStoreRatingForm
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
            this.components = new System.ComponentModel.Container();
            this.storeInfoLabel = new System.Windows.Forms.Label();
            this.userRatingListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTORE_RATING_SYSTEM3DataSet = new Epam.Talalaykina.SummerPractice.Task1.STORE_RATING_SYSTEM3DataSet();
            this.user_Rating_ListTableAdapter = new Epam.Talalaykina.SummerPractice.Task1.STORE_RATING_SYSTEM3DataSetTableAdapters.User_Rating_ListTableAdapter();
            this.userStoreRatingInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userRatingListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORE_RATING_SYSTEM3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // storeInfoLabel
            // 
            this.storeInfoLabel.AutoSize = true;
            this.storeInfoLabel.Location = new System.Drawing.Point(12, 32);
            this.storeInfoLabel.Name = "storeInfoLabel";
            this.storeInfoLabel.Size = new System.Drawing.Size(46, 17);
            this.storeInfoLabel.TabIndex = 0;
            this.storeInfoLabel.Text = "label1";
            // 
            // userRatingListBindingSource
            // 
            this.userRatingListBindingSource.DataMember = "User_Rating_List";
            this.userRatingListBindingSource.DataSource = this.sTORE_RATING_SYSTEM3DataSet;
            // 
            // sTORE_RATING_SYSTEM3DataSet
            // 
            this.sTORE_RATING_SYSTEM3DataSet.DataSetName = "STORE_RATING_SYSTEM3DataSet";
            this.sTORE_RATING_SYSTEM3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_Rating_ListTableAdapter
            // 
            this.user_Rating_ListTableAdapter.ClearBeforeFill = true;
            // 
            // userStoreRatingInfo
            // 
            this.userStoreRatingInfo.AutoSize = true;
            this.userStoreRatingInfo.Location = new System.Drawing.Point(12, 98);
            this.userStoreRatingInfo.Name = "userStoreRatingInfo";
            this.userStoreRatingInfo.Size = new System.Drawing.Size(46, 17);
            this.userStoreRatingInfo.TabIndex = 2;
            this.userStoreRatingInfo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Store information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your rating of this store:";
            // 
            // AllStoreRatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 133);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userStoreRatingInfo);
            this.Controls.Add(this.storeInfoLabel);
            this.MaximumSize = new System.Drawing.Size(901, 165);
            this.MinimumSize = new System.Drawing.Size(901, 165);
            this.Name = "AllStoreRatingForm";
            this.Text = "AllStoreRatingForm";
            this.Load += new System.EventHandler(this.AllStoreRatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRatingListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTORE_RATING_SYSTEM3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storeInfoLabel;
        private STORE_RATING_SYSTEM3DataSet sTORE_RATING_SYSTEM3DataSet;
        private System.Windows.Forms.BindingSource userRatingListBindingSource;
        private STORE_RATING_SYSTEM3DataSetTableAdapters.User_Rating_ListTableAdapter user_Rating_ListTableAdapter;
        private System.Windows.Forms.Label userStoreRatingInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}