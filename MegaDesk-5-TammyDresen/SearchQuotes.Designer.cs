namespace MegaDesk_5_TammyDresen
{
    partial class SearchQuotes
    {
        /// <summary>
        /// this user interface form allows the user to pick a material type from a combo box and 
        /// displays all quotes with that material.
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
            this.btnSearchCancel = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.MaterialsCombo = new System.Windows.Forms.ComboBox();
            this.searchResultsList = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDrawers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaterial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSearchCancel
            // 
            this.btnSearchCancel.BackColor = System.Drawing.Color.Tan;
            this.btnSearchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCancel.Location = new System.Drawing.Point(570, 386);
            this.btnSearchCancel.Name = "btnSearchCancel";
            this.btnSearchCancel.Size = new System.Drawing.Size(130, 30);
            this.btnSearchCancel.TabIndex = 0;
            this.btnSearchCancel.Text = "Main Menu";
            this.btnSearchCancel.UseVisualStyleBackColor = false;
            this.btnSearchCancel.Click += new System.EventHandler(this.BtnSearchCancel_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Tan;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(570, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 30);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(47, 41);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(262, 20);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search Quotes By Surface Material:";
            // 
            // MaterialsCombo
            // 
            this.MaterialsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialsCombo.FormattingEnabled = true;
            this.MaterialsCombo.Location = new System.Drawing.Point(433, 37);
            this.MaterialsCombo.Name = "MaterialsCombo";
            this.MaterialsCombo.Size = new System.Drawing.Size(121, 28);
            this.MaterialsCombo.TabIndex = 3;
            // 
            // searchResultsList
            // 
            this.searchResultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colWidth,
            this.colDepth,
            this.colDrawers,
            this.colMaterial,
            this.colSpeed,
            this.colPrices,
            this.colDate});
            this.searchResultsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsList.FullRowSelect = true;
            this.searchResultsList.GridLines = true;
            this.searchResultsList.Location = new System.Drawing.Point(51, 81);
            this.searchResultsList.Name = "searchResultsList";
            this.searchResultsList.Size = new System.Drawing.Size(649, 290);
            this.searchResultsList.TabIndex = 4;
            this.searchResultsList.UseCompatibleStateImageBehavior = false;
            this.searchResultsList.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Customer ";
            this.colName.Width = 140;
            // 
            // colWidth
            // 
            this.colWidth.Text = "Width";
            this.colWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colWidth.Width = 55;
            // 
            // colDepth
            // 
            this.colDepth.Text = "Depth";
            this.colDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDepth.Width = 57;
            // 
            // colDrawers
            // 
            this.colDrawers.Text = "Drawers";
            this.colDrawers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDrawers.Width = 73;
            // 
            // colMaterial
            // 
            this.colMaterial.Text = "Surface";
            this.colMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMaterial.Width = 69;
            // 
            // colSpeed
            // 
            this.colSpeed.Text = "Delivery";
            this.colSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSpeed.Width = 67;
            // 
            // colPrices
            // 
            this.colPrices.Text = "Price";
            this.colPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDate.Width = 134;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(765, 461);
            this.Controls.Add(this.searchResultsList);
            this.Controls.Add(this.MaterialsCombo);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.btnSearchCancel);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCancel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox MaterialsCombo;
        private System.Windows.Forms.ListView searchResultsList;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colWidth;
        private System.Windows.Forms.ColumnHeader colDepth;
        private System.Windows.Forms.ColumnHeader colDrawers;
        private System.Windows.Forms.ColumnHeader colMaterial;
        private System.Windows.Forms.ColumnHeader colSpeed;
        private System.Windows.Forms.ColumnHeader colPrices;
        private System.Windows.Forms.ColumnHeader colDate;
    }
}