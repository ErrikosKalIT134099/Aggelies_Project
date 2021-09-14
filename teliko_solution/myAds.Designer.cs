namespace WindowsFormsApp1
{
    partial class myAds
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
            this.myAdControl = new System.Windows.Forms.TabControl();
            this.myAdsTab = new System.Windows.Forms.TabPage();
            this.myAdsGV = new System.Windows.Forms.DataGridView();
            this.myFavoriteTab = new System.Windows.Forms.TabPage();
            this.myFavoritesGV = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.database1DataSet1 = new WindowsFormsApp1.Database1DataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseLocal = new WindowsFormsApp1.DatabaseLocal();
            this.user_FavoriteViewTableAdapter = new WindowsFormsApp1.DatabaseLocalTableAdapters.User_FavoriteViewTableAdapter();
            this.myAdControl.SuspendLayout();
            this.myAdsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myAdsGV)).BeginInit();
            this.myFavoriteTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myFavoritesGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // myAdControl
            // 
            this.myAdControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myAdControl.Controls.Add(this.myAdsTab);
            this.myAdControl.Controls.Add(this.myFavoriteTab);
            this.myAdControl.Location = new System.Drawing.Point(2, 1);
            this.myAdControl.Name = "myAdControl";
            this.myAdControl.SelectedIndex = 0;
            this.myAdControl.Size = new System.Drawing.Size(881, 544);
            this.myAdControl.TabIndex = 0;
            // 
            // myAdsTab
            // 
            this.myAdsTab.Controls.Add(this.myAdsGV);
            this.myAdsTab.Location = new System.Drawing.Point(4, 22);
            this.myAdsTab.Name = "myAdsTab";
            this.myAdsTab.Padding = new System.Windows.Forms.Padding(3);
            this.myAdsTab.Size = new System.Drawing.Size(873, 518);
            this.myAdsTab.TabIndex = 0;
            this.myAdsTab.Text = "My Ads";
            this.myAdsTab.UseVisualStyleBackColor = true;
            this.myAdsTab.Click += new System.EventHandler(this.myAdsTab_Click);
            // 
            // myAdsGV
            // 
            this.myAdsGV.AllowUserToAddRows = false;
            this.myAdsGV.AllowUserToDeleteRows = false;
            this.myAdsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myAdsGV.Location = new System.Drawing.Point(3, 6);
            this.myAdsGV.Name = "myAdsGV";
            this.myAdsGV.ReadOnly = true;
            this.myAdsGV.Size = new System.Drawing.Size(870, 206);
            this.myAdsGV.TabIndex = 0;
            // 
            // myFavoriteTab
            // 
            this.myFavoriteTab.AutoScroll = true;
            this.myFavoriteTab.Controls.Add(this.myFavoritesGV);
            this.myFavoriteTab.Location = new System.Drawing.Point(4, 22);
            this.myFavoriteTab.Name = "myFavoriteTab";
            this.myFavoriteTab.Padding = new System.Windows.Forms.Padding(3);
            this.myFavoriteTab.Size = new System.Drawing.Size(873, 518);
            this.myFavoriteTab.TabIndex = 1;
            this.myFavoriteTab.Text = "My Favorites";
            this.myFavoriteTab.UseVisualStyleBackColor = true;
            this.myFavoriteTab.Click += new System.EventHandler(this.myFavoriteTab_Click);
            // 
            // myFavoritesGV
            // 
            this.myFavoritesGV.AllowUserToAddRows = false;
            this.myFavoritesGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myFavoritesGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myFavoritesGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myFavoritesGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myFavoritesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myFavoritesGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete});
            this.myFavoritesGV.Location = new System.Drawing.Point(6, 3);
            this.myFavoritesGV.Name = "myFavoritesGV";
            this.myFavoritesGV.ReadOnly = true;
            this.myFavoritesGV.Size = new System.Drawing.Size(867, 187);
            this.myFavoritesGV.TabIndex = 0;
            this.myFavoritesGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myFavoritesGV_CellContentClick);
            this.myFavoritesGV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.myFavoritesGV_CellPainting);
            // 
            // delete
            // 
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "User_FavoriteView";
            this.bindingSource1.DataSource = this.databaseLocal;
            // 
            // databaseLocal
            // 
            this.databaseLocal.DataSetName = "DatabaseLocal";
            this.databaseLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_FavoriteViewTableAdapter
            // 
            this.user_FavoriteViewTableAdapter.ClearBeforeFill = true;
            // 
            // myAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 540);
            this.Controls.Add(this.myAdControl);
            this.Name = "myAds";
            this.Text = "myAds";
            this.myAdControl.ResumeLayout(false);
            this.myAdsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myAdsGV)).EndInit();
            this.myFavoriteTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myFavoritesGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseLocal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl myAdControl;
        private System.Windows.Forms.TabPage myAdsTab;
        private System.Windows.Forms.TabPage myFavoriteTab;
        private System.Windows.Forms.DataGridView myAdsGV;
        private System.Windows.Forms.DataGridView myFavoritesGV;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DatabaseLocal databaseLocal;
        private DatabaseLocalTableAdapters.User_FavoriteViewTableAdapter user_FavoriteViewTableAdapter;
    }
}