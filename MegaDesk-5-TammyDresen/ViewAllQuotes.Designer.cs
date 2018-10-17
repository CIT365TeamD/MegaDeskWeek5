namespace MegaDesk_5_TammyDresen
{
    partial class ViewAllQuotes
    {
        /// <summary>
        /// This form will display all the quotes by reading from
        /// the text file where quotes are stored.
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
            this.btnAllCancel = new System.Windows.Forms.Button();
            this.lblQuotes = new System.Windows.Forms.Label();
            this.QuoteListView = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWidth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDrawers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSurface = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAllCancel
            // 
            this.btnAllCancel.BackColor = System.Drawing.Color.Tan;
            this.btnAllCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCancel.Location = new System.Drawing.Point(560, 393);
            this.btnAllCancel.Name = "btnAllCancel";
            this.btnAllCancel.Size = new System.Drawing.Size(145, 30);
            this.btnAllCancel.TabIndex = 0;
            this.btnAllCancel.Text = "Main Menu";
            this.btnAllCancel.UseVisualStyleBackColor = false;
            this.btnAllCancel.Click += new System.EventHandler(this.btnAllCancel_Click);
            // 
            // lblQuotes
            // 
            this.lblQuotes.AutoSize = true;
            this.lblQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotes.Location = new System.Drawing.Point(51, 41);
            this.lblQuotes.Name = "lblQuotes";
            this.lblQuotes.Size = new System.Drawing.Size(82, 20);
            this.lblQuotes.TabIndex = 1;
            this.lblQuotes.Text = "All Quotes";
            // 
            // QuoteListView
            // 
            this.QuoteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colWidth,
            this.colDepth,
            this.colDrawers,
            this.colSurface,
            this.colSpeed,
            this.colPrice,
            this.colDate});
            this.QuoteListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteListView.FullRowSelect = true;
            this.QuoteListView.GridLines = true;
            this.QuoteListView.Location = new System.Drawing.Point(55, 74);
            this.QuoteListView.Name = "QuoteListView";
            this.QuoteListView.Size = new System.Drawing.Size(650, 304);
            this.QuoteListView.TabIndex = 2;
            this.QuoteListView.UseCompatibleStateImageBehavior = false;
            this.QuoteListView.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Customer";
            this.colName.Width = 139;
            // 
            // colWidth
            // 
            this.colWidth.Text = "Width";
            this.colWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colDepth
            // 
            this.colDepth.Text = "Depth";
            this.colDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colDrawers
            // 
            this.colDrawers.Text = "Drawers";
            this.colDrawers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDrawers.Width = 71;
            // 
            // colSurface
            // 
            this.colSurface.Text = "Surface";
            this.colSurface.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSurface.Width = 69;
            // 
            // colSpeed
            // 
            this.colSpeed.Text = "Delivery";
            this.colSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSpeed.Width = 69;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Price";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colDate
            // 
            this.colDate.Text = "Quote Date";
            this.colDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDate.Width = 119;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.QuoteListView);
            this.Controls.Add(this.lblQuotes);
            this.Controls.Add(this.btnAllCancel);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllCancel;
        private System.Windows.Forms.Label lblQuotes;
        private System.Windows.Forms.ListView QuoteListView;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colWidth;
        private System.Windows.Forms.ColumnHeader colDepth;
        private System.Windows.Forms.ColumnHeader colDrawers;
        private System.Windows.Forms.ColumnHeader colSurface;
        private System.Windows.Forms.ColumnHeader colSpeed;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colDate;
    }
}