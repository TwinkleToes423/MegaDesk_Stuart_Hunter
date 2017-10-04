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
            this.widthInputBox = new System.Windows.Forms.TextBox();
            this.depthInputBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.drawerNumberInputForm)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(12, 12);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(267, 22);
            this.customerNameBox.TabIndex = 0;
            // 
            // widthInputBox
            // 
            this.widthInputBox.Location = new System.Drawing.Point(12, 40);
            this.widthInputBox.Name = "widthInputBox";
            this.widthInputBox.Size = new System.Drawing.Size(100, 22);
            this.widthInputBox.TabIndex = 1;
            // 
            // depthInputBox
            // 
            this.depthInputBox.Location = new System.Drawing.Point(12, 68);
            this.depthInputBox.Name = "depthInputBox";
            this.depthInputBox.Size = new System.Drawing.Size(100, 22);
            this.depthInputBox.TabIndex = 2;
            // 
            // materialInputBox
            // 
            this.materialInputBox.FormattingEnabled = true;
            this.materialInputBox.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialInputBox.Location = new System.Drawing.Point(12, 126);
            this.materialInputBox.Name = "materialInputBox";
            this.materialInputBox.Size = new System.Drawing.Size(121, 24);
            this.materialInputBox.TabIndex = 3;
            // 
            // shippingInputBox
            // 
            this.shippingInputBox.FormattingEnabled = true;
            this.shippingInputBox.Items.AddRange(new object[] {
            "3 day",
            "5 day",
            "7 day",
            "14 day"});
            this.shippingInputBox.Location = new System.Drawing.Point(12, 156);
            this.shippingInputBox.Name = "shippingInputBox";
            this.shippingInputBox.Size = new System.Drawing.Size(121, 24);
            this.shippingInputBox.TabIndex = 4;
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
            this.widthInputLabel.Location = new System.Drawing.Point(128, 43);
            this.widthInputLabel.Name = "widthInputLabel";
            this.widthInputLabel.Size = new System.Drawing.Size(264, 17);
            this.widthInputLabel.TabIndex = 6;
            this.widthInputLabel.Text = "Please enter the width between 24\" - 96\"";
            // 
            // depthInputLabel
            // 
            this.depthInputLabel.AutoSize = true;
            this.depthInputLabel.Location = new System.Drawing.Point(128, 71);
            this.depthInputLabel.Name = "depthInputLabel";
            this.depthInputLabel.Size = new System.Drawing.Size(268, 17);
            this.depthInputLabel.TabIndex = 7;
            this.depthInputLabel.Text = "Please enter the depth between 12\" - 48\"";
            // 
            // drawerNumberInputForm
            // 
            this.drawerNumberInputForm.Location = new System.Drawing.Point(13, 98);
            this.drawerNumberInputForm.Name = "drawerNumberInputForm";
            this.drawerNumberInputForm.Size = new System.Drawing.Size(120, 22);
            this.drawerNumberInputForm.TabIndex = 8;
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
            this.generateDeskQuoteButton.Name = "generateDeskQuoteButton";
            this.generateDeskQuoteButton.Size = new System.Drawing.Size(187, 44);
            this.generateDeskQuoteButton.TabIndex = 12;
            this.generateDeskQuoteButton.Text = "Generate Desk Quote";
            this.generateDeskQuoteButton.UseVisualStyleBackColor = true;
            // 
            // goBackFromAddQuote
            // 
            this.goBackFromAddQuote.Location = new System.Drawing.Point(403, 288);
            this.goBackFromAddQuote.Name = "goBackFromAddQuote";
            this.goBackFromAddQuote.Size = new System.Drawing.Size(122, 44);
            this.goBackFromAddQuote.TabIndex = 13;
            this.goBackFromAddQuote.Text = "Go Back";
            this.goBackFromAddQuote.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 344);
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
            this.Controls.Add(this.depthInputBox);
            this.Controls.Add(this.widthInputBox);
            this.Controls.Add(this.customerNameBox);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawerNumberInputForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.TextBox widthInputBox;
        private System.Windows.Forms.TextBox depthInputBox;
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
    }
}