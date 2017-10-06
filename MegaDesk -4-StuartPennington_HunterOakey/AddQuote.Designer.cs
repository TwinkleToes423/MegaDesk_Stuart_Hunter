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
         this.customerNameBox.Location = new System.Drawing.Point(9, 10);
         this.customerNameBox.Margin = new System.Windows.Forms.Padding(2);
         this.customerNameBox.Name = "customerNameBox";
         this.customerNameBox.Size = new System.Drawing.Size(201, 20);
         this.customerNameBox.TabIndex = 0;
         // 
         // materialInputBox
         // 
         this.materialInputBox.FormattingEnabled = true;
         this.materialInputBox.Location = new System.Drawing.Point(9, 102);
         this.materialInputBox.Margin = new System.Windows.Forms.Padding(2);
         this.materialInputBox.Name = "materialInputBox";
         this.materialInputBox.Size = new System.Drawing.Size(92, 21);
         this.materialInputBox.TabIndex = 4;
         // 
         // shippingInputBox
         // 
         this.shippingInputBox.FormattingEnabled = true;
         this.shippingInputBox.Items.AddRange(new object[] {
            "3 day",
            "5 day",
            "7 day",
            "14 day"});
         this.shippingInputBox.Location = new System.Drawing.Point(9, 127);
         this.shippingInputBox.Margin = new System.Windows.Forms.Padding(2);
         this.shippingInputBox.Name = "shippingInputBox";
         this.shippingInputBox.Size = new System.Drawing.Size(92, 21);
         this.shippingInputBox.TabIndex = 5;
         // 
         // customerNameLabel
         // 
         this.customerNameLabel.AutoSize = true;
         this.customerNameLabel.Location = new System.Drawing.Point(221, 12);
         this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.customerNameLabel.Name = "customerNameLabel";
         this.customerNameLabel.Size = new System.Drawing.Size(145, 13);
         this.customerNameLabel.TabIndex = 5;
         this.customerNameLabel.Text = "Please Enter Customer Name";
         // 
         // widthInputLabel
         // 
         this.widthInputLabel.AutoSize = true;
         this.widthInputLabel.Location = new System.Drawing.Point(107, 35);
         this.widthInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.widthInputLabel.Name = "widthInputLabel";
         this.widthInputLabel.Size = new System.Drawing.Size(202, 13);
         this.widthInputLabel.TabIndex = 6;
         this.widthInputLabel.Text = "Please enter the width between 24\" - 96\"";
         // 
         // depthInputLabel
         // 
         this.depthInputLabel.AutoSize = true;
         this.depthInputLabel.Location = new System.Drawing.Point(104, 58);
         this.depthInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.depthInputLabel.Name = "depthInputLabel";
         this.depthInputLabel.Size = new System.Drawing.Size(204, 13);
         this.depthInputLabel.TabIndex = 7;
         this.depthInputLabel.Text = "Please enter the depth between 12\" - 48\"";
         // 
         // drawerNumberInputForm
         // 
         this.drawerNumberInputForm.Location = new System.Drawing.Point(10, 80);
         this.drawerNumberInputForm.Margin = new System.Windows.Forms.Padding(2);
         this.drawerNumberInputForm.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
         this.drawerNumberInputForm.Name = "drawerNumberInputForm";
         this.drawerNumberInputForm.Size = new System.Drawing.Size(90, 20);
         this.drawerNumberInputForm.TabIndex = 3;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(104, 81);
         this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(228, 13);
         this.label1.TabIndex = 9;
         this.label1.Text = "Please select number of drawers between 1 - 7";
         // 
         // materialInputLabel
         // 
         this.materialInputLabel.AutoSize = true;
         this.materialInputLabel.Location = new System.Drawing.Point(104, 105);
         this.materialInputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.materialInputLabel.Name = "materialInputLabel";
         this.materialInputLabel.Size = new System.Drawing.Size(203, 13);
         this.materialInputLabel.TabIndex = 10;
         this.materialInputLabel.Text = "Please select type of material for the desk";
         // 
         // shippingSpeedBox
         // 
         this.shippingSpeedBox.AutoSize = true;
         this.shippingSpeedBox.Location = new System.Drawing.Point(104, 129);
         this.shippingSpeedBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.shippingSpeedBox.Name = "shippingSpeedBox";
         this.shippingSpeedBox.Size = new System.Drawing.Size(193, 13);
         this.shippingSpeedBox.TabIndex = 11;
         this.shippingSpeedBox.Text = "Please select the desired shippig speed";
         // 
         // generateDeskQuoteButton
         // 
         this.generateDeskQuoteButton.Location = new System.Drawing.Point(146, 234);
         this.generateDeskQuoteButton.Margin = new System.Windows.Forms.Padding(2);
         this.generateDeskQuoteButton.Name = "generateDeskQuoteButton";
         this.generateDeskQuoteButton.Size = new System.Drawing.Size(140, 36);
         this.generateDeskQuoteButton.TabIndex = 7;
         this.generateDeskQuoteButton.Text = "Generate Desk Quote";
         this.generateDeskQuoteButton.UseVisualStyleBackColor = true;
         this.generateDeskQuoteButton.Click += new System.EventHandler(this.generateDeskQuoteButton_Click);
         // 
         // goBackFromAddQuote
         // 
         this.goBackFromAddQuote.Location = new System.Drawing.Point(302, 234);
         this.goBackFromAddQuote.Margin = new System.Windows.Forms.Padding(2);
         this.goBackFromAddQuote.Name = "goBackFromAddQuote";
         this.goBackFromAddQuote.Size = new System.Drawing.Size(92, 36);
         this.goBackFromAddQuote.TabIndex = 8;
         this.goBackFromAddQuote.Text = "Go Back";
         this.goBackFromAddQuote.UseVisualStyleBackColor = true;
         this.goBackFromAddQuote.Click += new System.EventHandler(this.goBackFromAddQuote_Click);
         // 
         // depthInputBox
         // 
         this.depthInputBox.Location = new System.Drawing.Point(10, 56);
         this.depthInputBox.Margin = new System.Windows.Forms.Padding(2);
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
         this.depthInputBox.Size = new System.Drawing.Size(90, 20);
         this.depthInputBox.TabIndex = 2;
         this.depthInputBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
         // 
         // widthInputBox
         // 
         this.widthInputBox.Location = new System.Drawing.Point(10, 32);
         this.widthInputBox.Margin = new System.Windows.Forms.Padding(2);
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
         this.widthInputBox.Size = new System.Drawing.Size(90, 20);
         this.widthInputBox.TabIndex = 1;
         this.widthInputBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
         // 
         // numDesksInputBox
         // 
         this.numDesksInputBox.Location = new System.Drawing.Point(10, 152);
         this.numDesksInputBox.Margin = new System.Windows.Forms.Padding(2);
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
         this.numDesksInputBox.Size = new System.Drawing.Size(90, 20);
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
         this.label2.Location = new System.Drawing.Point(107, 154);
         this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(165, 13);
         this.label2.TabIndex = 13;
         this.label2.Text = "Please enter the number of desks";
         // 
         // priceLabel
         // 
         this.priceLabel.AutoSize = true;
         this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.priceLabel.Location = new System.Drawing.Point(12, 234);
         this.priceLabel.Name = "priceLabel";
         this.priceLabel.Size = new System.Drawing.Size(0, 17);
         this.priceLabel.TabIndex = 14;
         // 
         // AddQuote
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(456, 280);
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
         this.Margin = new System.Windows.Forms.Padding(2);
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