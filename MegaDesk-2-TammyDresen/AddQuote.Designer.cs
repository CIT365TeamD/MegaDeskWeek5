namespace MegaDesk_2_TammyDresen
{
    partial class AddQuote
    {
        /// <summary>
        /// This form provides the user input interface.
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
            this.lblName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblDrawers = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userDrawers = new System.Windows.Forms.NumericUpDown();
            this.submitQuote = new System.Windows.Forms.Button();
            this.cancelQuote = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.userDepth = new System.Windows.Forms.NumericUpDown();
            this.userWidth = new System.Windows.Forms.NumericUpDown();
            this.userSpeed = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.userDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(65, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Your Name";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(181, 104);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(190, 26);
            this.userName.TabIndex = 1;
            this.userName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please fill in desk specifications to receive a price quote";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(65, 148);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(153, 20);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Desk width in inches";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(65, 189);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(157, 20);
            this.lblDepth.TabIndex = 4;
            this.lblDepth.Text = "Desk depth in inches";
            // 
            // lblDrawers
            // 
            this.lblDrawers.AutoSize = true;
            this.lblDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawers.Location = new System.Drawing.Point(65, 230);
            this.lblDrawers.Name = "lblDrawers";
            this.lblDrawers.Size = new System.Drawing.Size(146, 20);
            this.lblDrawers.TabIndex = 5;
            this.lblDrawers.Text = "Number of Drawers";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(65, 271);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(110, 20);
            this.lblFinish.TabIndex = 6;
            this.lblFinish.Text = "Desired Finish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Days to delivery";
            // 
            // userDrawers
            // 
            this.userDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDrawers.Location = new System.Drawing.Point(282, 227);
            this.userDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.userDrawers.Name = "userDrawers";
            this.userDrawers.Size = new System.Drawing.Size(89, 26);
            this.userDrawers.TabIndex = 4;
            // 
            // submitQuote
            // 
            this.submitQuote.BackColor = System.Drawing.Color.Tan;
            this.submitQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitQuote.Location = new System.Drawing.Point(69, 376);
            this.submitQuote.Name = "submitQuote";
            this.submitQuote.Size = new System.Drawing.Size(130, 30);
            this.submitQuote.TabIndex = 7;
            this.submitQuote.Text = "&Submit";
            this.submitQuote.UseVisualStyleBackColor = false;
            this.submitQuote.Click += new System.EventHandler(this.SubmitQuote_Click);
            // 
            // cancelQuote
            // 
            this.cancelQuote.BackColor = System.Drawing.Color.Tan;
            this.cancelQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuote.Location = new System.Drawing.Point(241, 376);
            this.cancelQuote.Name = "cancelQuote";
            this.cancelQuote.Size = new System.Drawing.Size(130, 30);
            this.cancelQuote.TabIndex = 8;
            this.cancelQuote.Text = "&Main Menu";
            this.cancelQuote.UseVisualStyleBackColor = false;
            this.cancelQuote.Click += new System.EventHandler(this.CancelQuote_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 10;
            // 
            // materialComboBox
            // 
            this.materialComboBox.AllowDrop = true;
            this.materialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(250, 268);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(121, 28);
            this.materialComboBox.TabIndex = 5;
            // 
            // userDepth
            // 
            this.userDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDepth.Location = new System.Drawing.Point(251, 189);
            this.userDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.userDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.userDepth.Name = "userDepth";
            this.userDepth.Size = new System.Drawing.Size(120, 26);
            this.userDepth.TabIndex = 3;
            this.userDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // userWidth
            // 
            this.userWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWidth.Location = new System.Drawing.Point(251, 148);
            this.userWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.userWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.userWidth.Name = "userWidth";
            this.userWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userWidth.Size = new System.Drawing.Size(120, 26);
            this.userWidth.TabIndex = 2;
            this.userWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // userSpeed
            // 
            this.userSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSpeed.FormattingEnabled = true;
            this.userSpeed.Items.AddRange(new object[] {
            "",
            "14",
            "7",
            "5",
            "3"});
            this.userSpeed.Location = new System.Drawing.Point(250, 314);
            this.userSpeed.Name = "userSpeed";
            this.userSpeed.Size = new System.Drawing.Size(121, 28);
            this.userSpeed.TabIndex = 6;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(436, 470);
            this.Controls.Add(this.userSpeed);
            this.Controls.Add(this.userWidth);
            this.Controls.Add(this.userDepth);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelQuote);
            this.Controls.Add(this.submitQuote);
            this.Controls.Add(this.userDrawers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblDrawers);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.lblName);
            this.Name = "AddQuote";
            this.Text = "Get a Quote";
            ((System.ComponentModel.ISupportInitialize)(this.userDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblDrawers;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown userDrawers;
        private System.Windows.Forms.Button submitQuote;
        private System.Windows.Forms.Button cancelQuote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.NumericUpDown userDepth;
        private System.Windows.Forms.NumericUpDown userWidth;
        private System.Windows.Forms.ComboBox userSpeed;
    }
}