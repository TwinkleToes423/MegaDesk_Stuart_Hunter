namespace MegaDesk__4_StuartPennington_HunterOakey
{
    partial class AddQuote
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
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.materialInputBox = new System.Windows.Forms.ComboBox();
            this.shippingInputBox = new System.Windows.Forms.ComboBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.widthInputLabel = new System.Windows.Forms.Label();
            this.depthInputLabel = new System.Windows.Forms.Label();
            this.drawerNumberInputForm = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.materialInputLabel = new System.Windows.Forms.Label();
            this.shippingSpeedBox = new System.Windows.Forms.Label();
            this.generateDeskQuoteButton = new System.Windows.Forms.Button();
            this.goBackFromAddQuote = new System.Windows.Forms.Button();
            this.depthInputBox = new System.Windows.Forms.NumericUpDown();
            this.widthInputBox = new System.Windows.Forms.NumericUpDown();
            this.numDesksInputBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNumberInputForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesksInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(12, 12);
            this.customerNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(267, 22);
            this.customerNameBox.TabIndex = 0;
            // 
            // materialInputBox
            // 
            this.materialInputBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialInputBox.FormattingEnabled = true;
            this.materialInputBox.Location = new System.Drawing.Point(12, 126);
            this.materialInputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialInputBox.Name = "materialInputBox";
            this.materialInputBox.Size = new System.Drawing.Size(121, 24);
            this.materialInputBox.TabIndex = 4;
            // 
            // shippingInputBox
            // 
            this.shippingInputBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shippingInputBox.FormattingEnabled = true;
            this.shippingInputBox.Items.AddRange(new object[] {
            "3 day",
            "5 day",
            "7 day",
            "14 day"});
            this.shippingInputBox.Location = new System.Drawing.Point(12, 156);
            this.shippingInputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shippingInputBox.Name = "shippingInputBox";
            this.shippingInputBox.Size = new System.Drawing.Size(121, 24);
            this.shippingInputBox.TabIndex = 5;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(295, 15);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(194, 17);
            this.customerNameLabel.TabIndex = 5;
            this.customerNameLabel.Text = "Please Enter Customer Name";
            // 
            // widthInputLabel
            // 
            this.widthInputLabel.AutoSize = true;
            this.widthInputLabel.Location = new System.Drawing.Point(143, 43);
            this.widthInputLabel.Name = "widthInputLabel";
            this.widthInputLabel.Size = new System.Drawing.Size(264, 17);
            this.widthInputLabel.TabIndex = 6;
            this.widthInputLabel.Text = "Please enter the width between 24\" - 96\"";
            // 
            // depthInputLabel
            // 
            this.depthInputLabel.AutoSize = true;
            this.depthInputLabel.Location = new System.Drawing.Point(139, 71);
            this.depthInputLabel.Name = "depthInputLabel";
            this.depthInputLabel.Size = new System.Drawing.Size(268, 17);
            this.depthInputLabel.TabIndex = 7;
            this.depthInputLabel.Text = "Please enter the depth between 12\" - 48\"";
            // 
            // drawerNumberInputForm
            // 
            this.drawerNumberInputForm.Location = new System.Drawing.Point(13, 98);
            this.drawerNumberInputForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawerNumberInputForm.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerNumberInputForm.Name = "drawerNumberInputForm";
            this.drawerNumberInputForm.Size = new System.Drawing.Size(120, 22);
            this.drawerNumberInputForm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please select number of drawers between 1 - 7";
            // 
            // materialInputLabel
            // 
            this.materialInputLabel.AutoSize = true;
            this.materialInputLabel.Location = new System.Drawing.Point(139, 129);
            this.materialInputLabel.Name = "materialInputLabel";
            this.materialInputLabel.Size = new System.Drawing.Size(272, 17);
            this.materialInputLabel.TabIndex = 10;
            this.materialInputLabel.Text = "Please select type of material for the desk";
            // 
            // shippingSpeedBox
            // 
            this.shippingSpeedBox.AutoSize = true;
            this.shippingSpeedBox.Location = new System.Drawing.Point(139, 159);
            this.shippingSpeedBox.Name = "shippingSpeedBox";
            this.shippingSpeedBox.Size = new System.Drawing.Size(259, 17);
            this.shippingSpeedBox.TabIndex = 11;
            this.shippingSpeedBox.Text = "Please select the desired shippig speed";
            // 
            // generateDeskQuoteButton
            // 
            this.generateDeskQuoteButton.Location = new System.Drawing.Point(195, 288);
            this.generateDeskQuoteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateDeskQuoteButton.Name = "generateDeskQuoteButton";
            this.generateDeskQuoteButton.Size = new System.Drawing.Size(187, 44);
            this.generateDeskQuoteButton.TabIndex = 7;
            this.generateDeskQuoteButton.Text = "Generate Desk Quote";
            this.generateDeskQuoteButton.UseVisualStyleBackColor = true;
            this.generateDeskQuoteButton.Click += new System.EventHandler(this.generateDeskQuoteButton_Click);
            // 
            // goBackFromAddQuote
            // 
            this.goBackFromAddQuote.Location = new System.Drawing.Point(403, 288);
            this.goBackFromAddQuote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goBackFromAddQuote.Name = "goBackFromAddQuote";
            this.goBackFromAddQuote.Size = new System.Drawing.Size(123, 44);
            this.goBackFromAddQuote.TabIndex = 8;
            this.goBackFromAddQuote.Text = "Go Back";
            this.goBackFromAddQuote.UseVisualStyleBackColor = true;
            this.goBackFromAddQuote.Click += new System.EventHandler(this.goBackFromAddQuote_Click);
            // 
            // depthInputBox
            // 
            this.depthInputBox.Location = new System.Drawing.Point(13, 69);
            this.depthInputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depthInputBox.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthInputBox.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInputBox.Name = "depthInputBox";
            this.depthInputBox.Size = new System.Drawing.Size(120, 22);
            this.depthInputBox.TabIndex = 2;
            this.depthInputBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // widthInputBox
            // 
            this.widthInputBox.Location = new System.Drawing.Point(13, 39);
            this.widthInputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.widthInputBox.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthInputBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInputBox.Name = "widthInputBox";
            this.widthInputBox.Size = new System.Drawing.Size(120, 22);
            this.widthInputBox.TabIndex = 1;
            this.widthInputBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numDesksInputBox
            // 
            this.numDesksInputBox.Location = new System.Drawing.Point(13, 187);
            this.numDesksInputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numDesksInputBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDesksInputBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDesksInputBox.Name = "numDesksInputBox";
            this.numDesksInputBox.Size = new System.Drawing.Size(120, 22);
            this.numDesksInputBox.TabIndex = 6;
            this.numDesksInputBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Please enter the number of desks";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(16, 288);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 20);
            this.priceLabel.TabIndex = 14;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 345);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDesksInputBox);
            this.Controls.Add(this.widthInputBox);
            this.Controls.Add(this.depthInputBox);
            this.Controls.Add(this.goBackFromAddQuote);
            this.Controls.Add(this.generateDeskQuoteButton);
            this.Controls.Add(this.shippingSpeedBox);
            this.Controls.Add(this.materialInputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawerNumberInputForm);
            this.Controls.Add(this.depthInputLabel);
            this.Controls.Add(this.widthInputLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.shippingInputBox);
            this.Controls.Add(this.materialInputBox);
            this.Controls.Add(this.customerNameBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawerNumberInputForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesksInputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.ComboBox materialInputBox;
        private System.Windows.Forms.ComboBox shippingInputBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label widthInputLabel;
        private System.Windows.Forms.Label depthInputLabel;
        private System.Windows.Forms.NumericUpDown drawerNumberInputForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label materialInputLabel;
        private System.Windows.Forms.Label shippingSpeedBox;
        private System.Windows.Forms.Button generateDeskQuoteButton;
        private System.Windows.Forms.Button goBackFromAddQuote;
        private System.Windows.Forms.NumericUpDown depthInputBox;
        private System.Windows.Forms.NumericUpDown widthInputBox;
      private System.Windows.Forms.NumericUpDown numDesksInputBox;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label priceLabel;
   }
}