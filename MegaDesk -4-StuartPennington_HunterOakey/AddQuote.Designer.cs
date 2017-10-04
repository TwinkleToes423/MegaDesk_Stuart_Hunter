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
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 344);
            this.Controls.Add(this.shippingInputBox);
            this.Controls.Add(this.materialInputBox);
            this.Controls.Add(this.depthInputBox);
            this.Controls.Add(this.widthInputBox);
            this.Controls.Add(this.customerNameBox);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.TextBox widthInputBox;
        private System.Windows.Forms.TextBox depthInputBox;
        private System.Windows.Forms.ComboBox materialInputBox;
        private System.Windows.Forms.ComboBox shippingInputBox;
    }
}