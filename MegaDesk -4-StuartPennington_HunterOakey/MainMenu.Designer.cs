namespace MegaDesk__4_StuartPennington_HunterOakey
{
    partial class MainMenu
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
            this.createQuoteMainMenu = new System.Windows.Forms.Button();
            this.viewQuoteMainMenu = new System.Windows.Forms.Button();
            this.searchQuotesMainMenu = new System.Windows.Forms.Button();
            this.exitApplicationMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createQuoteMainMenu
            // 
            this.createQuoteMainMenu.Location = new System.Drawing.Point(12, 12);
            this.createQuoteMainMenu.Name = "createQuoteMainMenu";
            this.createQuoteMainMenu.Size = new System.Drawing.Size(258, 57);
            this.createQuoteMainMenu.TabIndex = 0;
            this.createQuoteMainMenu.Text = "Create New Quote";
            this.createQuoteMainMenu.UseVisualStyleBackColor = true;
            this.createQuoteMainMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewQuoteMainMenu
            // 
            this.viewQuoteMainMenu.Location = new System.Drawing.Point(12, 75);
            this.viewQuoteMainMenu.Name = "viewQuoteMainMenu";
            this.viewQuoteMainMenu.Size = new System.Drawing.Size(258, 57);
            this.viewQuoteMainMenu.TabIndex = 1;
            this.viewQuoteMainMenu.Text = "View Quotes";
            this.viewQuoteMainMenu.UseVisualStyleBackColor = true;
            // 
            // searchQuotesMainMenu
            // 
            this.searchQuotesMainMenu.Location = new System.Drawing.Point(12, 139);
            this.searchQuotesMainMenu.Name = "searchQuotesMainMenu";
            this.searchQuotesMainMenu.Size = new System.Drawing.Size(258, 60);
            this.searchQuotesMainMenu.TabIndex = 2;
            this.searchQuotesMainMenu.Text = "Search Quotes";
            this.searchQuotesMainMenu.UseVisualStyleBackColor = true;
            // 
            // exitApplicationMainMenu
            // 
            this.exitApplicationMainMenu.Location = new System.Drawing.Point(12, 207);
            this.exitApplicationMainMenu.Name = "exitApplicationMainMenu";
            this.exitApplicationMainMenu.Size = new System.Drawing.Size(258, 57);
            this.exitApplicationMainMenu.TabIndex = 3;
            this.exitApplicationMainMenu.Text = "Exit";
            this.exitApplicationMainMenu.UseVisualStyleBackColor = true;
            this.exitApplicationMainMenu.Click += new System.EventHandler(this.exitApplicationMainMenu_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 272);
            this.Controls.Add(this.exitApplicationMainMenu);
            this.Controls.Add(this.searchQuotesMainMenu);
            this.Controls.Add(this.viewQuoteMainMenu);
            this.Controls.Add(this.createQuoteMainMenu);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createQuoteMainMenu;
        private System.Windows.Forms.Button viewQuoteMainMenu;
        private System.Windows.Forms.Button searchQuotesMainMenu;
        private System.Windows.Forms.Button exitApplicationMainMenu;
    }
}

