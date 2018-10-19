namespace MegaDesk_2_TammyDresen
{
    partial class DisplayQuote
    {
        /// <summary>
        /// This form view displays the current quote information after a successful quote add.
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
            this.btnDisplayCancel = new System.Windows.Forms.Button();
            this.displayRush = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblDrawers = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.displayName = new System.Windows.Forms.Label();
            this.displayWidth = new System.Windows.Forms.Label();
            this.displayDepth = new System.Windows.Forms.Label();
            this.displayDrawers = new System.Windows.Forms.Label();
            this.displayMaterial = new System.Windows.Forms.Label();
            this.displayDelivery = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.displayBasePrice = new System.Windows.Forms.Label();
            this.drawerPrice = new System.Windows.Forms.Label();
            this.materialPrice = new System.Windows.Forms.Label();
            this.rushPrice = new System.Windows.Forms.Label();
            this.drawerPriceLabel = new System.Windows.Forms.Label();
            this.surfacePriceLabel = new System.Windows.Forms.Label();
            this.rushFeeLabel = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.displayDate = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplayCancel
            // 
            this.btnDisplayCancel.BackColor = System.Drawing.Color.Tan;
            this.btnDisplayCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayCancel.Location = new System.Drawing.Point(321, 339);
            this.btnDisplayCancel.Name = "btnDisplayCancel";
            this.btnDisplayCancel.Size = new System.Drawing.Size(130, 30);
            this.btnDisplayCancel.TabIndex = 0;
            this.btnDisplayCancel.Text = "Close";
            this.btnDisplayCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDisplayCancel.UseVisualStyleBackColor = false;
            this.btnDisplayCancel.Click += new System.EventHandler(this.BtnDisplayCancel_Click);
            // 
            // displayRush
            // 
            this.displayRush.AutoSize = true;
            this.displayRush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayRush.Location = new System.Drawing.Point(8, 184);
            this.displayRush.Name = "displayRush";
            this.displayRush.Size = new System.Drawing.Size(126, 20);
            this.displayRush.TabIndex = 8;
            this.displayRush.Text = "Days to Delivery:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(10, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 20);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total Price: ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(8, 152);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(133, 20);
            this.lblMaterial.TabIndex = 10;
            this.lblMaterial.Text = "Surface Material: ";
            // 
            // lblDrawers
            // 
            this.lblDrawers.AutoSize = true;
            this.lblDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawers.Location = new System.Drawing.Point(8, 120);
            this.lblDrawers.Name = "lblDrawers";
            this.lblDrawers.Size = new System.Drawing.Size(154, 20);
            this.lblDrawers.TabIndex = 11;
            this.lblDrawers.Text = "Number of Drawers: ";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(8, 38);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(102, 20);
            this.lblDepth.TabIndex = 12;
            this.lblDepth.Text = "Desk Depth: ";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(8, 8);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(99, 20);
            this.lblWidth.TabIndex = 13;
            this.lblWidth.Text = "Desk Width: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(288, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 20);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Customer: ";
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayName.Location = new System.Drawing.Point(287, 92);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(167, 20);
            this.displayName.TabIndex = 16;
            this.displayName.Text = "Josephine Higglesbys ";
            // 
            // displayWidth
            // 
            this.displayWidth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayWidth.AutoSize = true;
            this.displayWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWidth.Location = new System.Drawing.Point(143, 8);
            this.displayWidth.Name = "displayWidth";
            this.displayWidth.Size = new System.Drawing.Size(77, 20);
            this.displayWidth.TabIndex = 18;
            this.displayWidth.Text = "24 inches";
            this.displayWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // displayDepth
            // 
            this.displayDepth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayDepth.AutoSize = true;
            this.displayDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDepth.Location = new System.Drawing.Point(143, 38);
            this.displayDepth.Name = "displayDepth";
            this.displayDepth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayDepth.Size = new System.Drawing.Size(77, 20);
            this.displayDepth.TabIndex = 19;
            this.displayDepth.Text = "12 inches";
            this.displayDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // displayDrawers
            // 
            this.displayDrawers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayDrawers.AutoSize = true;
            this.displayDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDrawers.Location = new System.Drawing.Point(198, 120);
            this.displayDrawers.Name = "displayDrawers";
            this.displayDrawers.Size = new System.Drawing.Size(22, 20);
            this.displayDrawers.TabIndex = 20;
            this.displayDrawers.Text = "3 ";
            this.displayDrawers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // displayMaterial
            // 
            this.displayMaterial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayMaterial.AutoSize = true;
            this.displayMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMaterial.Location = new System.Drawing.Point(135, 152);
            this.displayMaterial.Name = "displayMaterial";
            this.displayMaterial.Size = new System.Drawing.Size(85, 20);
            this.displayMaterial.TabIndex = 21;
            this.displayMaterial.Text = "Rosewood";
            this.displayMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // displayDelivery
            // 
            this.displayDelivery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayDelivery.AutoSize = true;
            this.displayDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDelivery.Location = new System.Drawing.Point(193, 184);
            this.displayDelivery.Name = "displayDelivery";
            this.displayDelivery.Size = new System.Drawing.Size(27, 20);
            this.displayDelivery.TabIndex = 22;
            this.displayDelivery.Text = "14";
            this.displayDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalPrice
            // 
            this.totalPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(118, 9);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalPrice.Size = new System.Drawing.Size(45, 20);
            this.totalPrice.TabIndex = 23;
            this.totalPrice.Text = "$737";
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(9, 10);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(93, 20);
            this.lblBasePrice.TabIndex = 24;
            this.lblBasePrice.Text = "Base Price: ";
            // 
            // displayBasePrice
            // 
            this.displayBasePrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayBasePrice.AutoSize = true;
            this.displayBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBasePrice.Location = new System.Drawing.Point(118, 10);
            this.displayBasePrice.Name = "displayBasePrice";
            this.displayBasePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.displayBasePrice.Size = new System.Drawing.Size(45, 20);
            this.displayBasePrice.TabIndex = 25;
            this.displayBasePrice.Text = "$402";
            this.displayBasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drawerPrice
            // 
            this.drawerPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.drawerPrice.AutoSize = true;
            this.drawerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerPrice.Location = new System.Drawing.Point(395, 174);
            this.drawerPrice.Name = "drawerPrice";
            this.drawerPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.drawerPrice.Size = new System.Drawing.Size(45, 20);
            this.drawerPrice.TabIndex = 26;
            this.drawerPrice.Text = "$150";
            this.drawerPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialPrice
            // 
            this.materialPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialPrice.AutoSize = true;
            this.materialPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialPrice.Location = new System.Drawing.Point(395, 206);
            this.materialPrice.Name = "materialPrice";
            this.materialPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialPrice.Size = new System.Drawing.Size(45, 20);
            this.materialPrice.TabIndex = 27;
            this.materialPrice.Text = "$125";
            this.materialPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rushPrice
            // 
            this.rushPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rushPrice.AutoSize = true;
            this.rushPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushPrice.Location = new System.Drawing.Point(395, 239);
            this.rushPrice.Name = "rushPrice";
            this.rushPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rushPrice.Size = new System.Drawing.Size(45, 20);
            this.rushPrice.TabIndex = 28;
            this.rushPrice.Text = "$360";
            this.rushPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drawerPriceLabel
            // 
            this.drawerPriceLabel.AutoSize = true;
            this.drawerPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerPriceLabel.Location = new System.Drawing.Point(287, 174);
            this.drawerPriceLabel.Name = "drawerPriceLabel";
            this.drawerPriceLabel.Size = new System.Drawing.Size(94, 20);
            this.drawerPriceLabel.TabIndex = 29;
            this.drawerPriceLabel.Text = "x $50 each: ";
            // 
            // surfacePriceLabel
            // 
            this.surfacePriceLabel.AutoSize = true;
            this.surfacePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfacePriceLabel.Location = new System.Drawing.Point(287, 206);
            this.surfacePriceLabel.Name = "surfacePriceLabel";
            this.surfacePriceLabel.Size = new System.Drawing.Size(105, 20);
            this.surfacePriceLabel.TabIndex = 30;
            this.surfacePriceLabel.Text = "Material Fee: ";
            // 
            // rushFeeLabel
            // 
            this.rushFeeLabel.AutoSize = true;
            this.rushFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushFeeLabel.Location = new System.Drawing.Point(287, 239);
            this.rushFeeLabel.Name = "rushFeeLabel";
            this.rushFeeLabel.Size = new System.Drawing.Size(87, 20);
            this.rushFeeLabel.TabIndex = 31;
            this.rushFeeLabel.Text = "Rush Fee: ";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(7, 10);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(90, 20);
            this.lblArea.TabIndex = 32;
            this.lblArea.Text = "Total Area: ";
            // 
            // area
            // 
            this.area.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.area.AutoSize = true;
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.Location = new System.Drawing.Point(143, 10);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(77, 20);
            this.area.TabIndex = 33;
            this.area.Text = "288 sq.in.";
            this.area.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.displayDelivery);
            this.panel1.Controls.Add(this.displayMaterial);
            this.panel1.Controls.Add(this.displayDrawers);
            this.panel1.Controls.Add(this.displayDepth);
            this.panel1.Controls.Add(this.displayWidth);
            this.panel1.Controls.Add(this.lblWidth);
            this.panel1.Controls.Add(this.lblDepth);
            this.panel1.Controls.Add(this.lblDrawers);
            this.panel1.Controls.Add(this.lblMaterial);
            this.panel1.Controls.Add(this.displayRush);
            this.panel1.Location = new System.Drawing.Point(49, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 219);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.area);
            this.panel2.Controls.Add(this.lblArea);
            this.panel2.Location = new System.Drawing.Point(1, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 39);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Beige;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.displayBasePrice);
            this.panel3.Controls.Add(this.lblBasePrice);
            this.panel3.Location = new System.Drawing.Point(276, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 39);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Beige;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.totalPrice);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Location = new System.Drawing.Point(276, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 38);
            this.panel4.TabIndex = 36;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(8, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 20);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Quote Date: ";
            // 
            // displayDate
            // 
            this.displayDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayDate.AutoSize = true;
            this.displayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDate.Location = new System.Drawing.Point(131, 9);
            this.displayDate.Name = "displayDate";
            this.displayDate.Size = new System.Drawing.Size(89, 20);
            this.displayDate.TabIndex = 17;
            this.displayDate.Text = "01/10/2018";
            this.displayDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Beige;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.displayDate);
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Location = new System.Drawing.Point(49, 272);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 38);
            this.panel5.TabIndex = 37;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(509, 427);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rushFeeLabel);
            this.Controls.Add(this.surfacePriceLabel);
            this.Controls.Add(this.drawerPriceLabel);
            this.Controls.Add(this.rushPrice);
            this.Controls.Add(this.materialPrice);
            this.Controls.Add(this.drawerPrice);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDisplayCancel);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayCancel;
        private System.Windows.Forms.Label displayName;
        private System.Windows.Forms.Label displayWidth;
        private System.Windows.Forms.Label displayDepth;
        private System.Windows.Forms.Label displayMaterial;
        private System.Windows.Forms.Label displayDrawers;
        private System.Windows.Forms.Label displayRush;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblDrawers;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label displayDelivery;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label displayBasePrice;
        private System.Windows.Forms.Label drawerPrice;
        private System.Windows.Forms.Label materialPrice;
        private System.Windows.Forms.Label rushPrice;
        private System.Windows.Forms.Label drawerPriceLabel;
        private System.Windows.Forms.Label surfacePriceLabel;
        private System.Windows.Forms.Label rushFeeLabel;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label displayDate;
        private System.Windows.Forms.Panel panel5;
    }
}