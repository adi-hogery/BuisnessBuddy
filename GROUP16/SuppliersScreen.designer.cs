namespace GROUP16
{
    partial class SuppliersScreen
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
            this.SearchSup = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.AddSupp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backToInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchSup
            // 
            this.SearchSup.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSup.Location = new System.Drawing.Point(480, 231);
            this.SearchSup.Name = "SearchSup";
            this.SearchSup.Size = new System.Drawing.Size(207, 128);
            this.SearchSup.TabIndex = 1;
            this.SearchSup.Text = "חפש ספק";
            this.SearchSup.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(2, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(90, 39);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "התנתק";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // AddSupp
            // 
            this.AddSupp.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupp.Location = new System.Drawing.Point(138, 228);
            this.AddSupp.Name = "AddSupp";
            this.AddSupp.Size = new System.Drawing.Size(215, 130);
            this.AddSupp.TabIndex = 3;
            this.AddSupp.Text = "הוסף ספק";
            this.AddSupp.UseVisualStyleBackColor = true;
            this.AddSupp.Click += new System.EventHandler(this.AddSupp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "ספקים";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backToInventory
            // 
            this.backToInventory.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToInventory.Location = new System.Drawing.Point(368, 483);
            this.backToInventory.Name = "backToInventory";
            this.backToInventory.Size = new System.Drawing.Size(100, 32);
            this.backToInventory.TabIndex = 5;
            this.backToInventory.Text = "חזור";
            this.backToInventory.UseVisualStyleBackColor = true;
            this.backToInventory.Click += new System.EventHandler(this.backToInventory_Click);
            // 
            // SuppliersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.backToInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddSupp);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.SearchSup);
            this.DoubleBuffered = true;
            this.Name = "SuppliersScreen";
            this.Text = "SuppliersScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchSup;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button AddSupp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToInventory;
    }
}