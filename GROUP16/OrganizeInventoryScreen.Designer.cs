namespace GROUP16
{
    partial class OrganizeInventoryScreen
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
            this.goToSupScreen = new System.Windows.Forms.Button();
            this.goToInventoryScreen = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.backToHomepage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goToSupScreen
            // 
            this.goToSupScreen.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToSupScreen.Location = new System.Drawing.Point(194, 247);
            this.goToSupScreen.Name = "goToSupScreen";
            this.goToSupScreen.Size = new System.Drawing.Size(210, 127);
            this.goToSupScreen.TabIndex = 0;
            this.goToSupScreen.Text = "ספקים";
            this.goToSupScreen.UseVisualStyleBackColor = true;
            // 
            // goToInventoryScreen
            // 
            this.goToInventoryScreen.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToInventoryScreen.Location = new System.Drawing.Point(465, 247);
            this.goToInventoryScreen.Name = "goToInventoryScreen";
            this.goToInventoryScreen.Size = new System.Drawing.Size(210, 127);
            this.goToInventoryScreen.TabIndex = 1;
            this.goToInventoryScreen.Text = "מלאי";
            this.goToInventoryScreen.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(7, 8);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(96, 32);
            this.logout.TabIndex = 2;
            this.logout.Text = "התנתק";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // backToHomepage
            // 
            this.backToHomepage.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToHomepage.Location = new System.Drawing.Point(388, 459);
            this.backToHomepage.Name = "backToHomepage";
            this.backToHomepage.Size = new System.Drawing.Size(104, 31);
            this.backToHomepage.TabIndex = 3;
            this.backToHomepage.Text = "חזור";
            this.backToHomepage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "ארגון מלאי";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrganizeInventoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToHomepage);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.goToInventoryScreen);
            this.Controls.Add(this.goToSupScreen);
            this.DoubleBuffered = true;
            this.Name = "OrganizeInventoryScreen";
            this.Text = "OrganizeInventoryScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToSupScreen;
        private System.Windows.Forms.Button goToInventoryScreen;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button backToHomepage;
        private System.Windows.Forms.Label label1;
    }
}