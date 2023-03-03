namespace GROUP16
{
    partial class Customer_sPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchCust = new System.Windows.Forms.Button();
            this.disFromCustPage = new System.Windows.Forms.Button();
            this.backFromCustomers = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CreateCus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ניהול לקוחות";
            // 
            // SearchCust
            // 
            this.SearchCust.BackColor = System.Drawing.Color.Transparent;
            this.SearchCust.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCust.Location = new System.Drawing.Point(454, 240);
            this.SearchCust.Name = "SearchCust";
            this.SearchCust.Size = new System.Drawing.Size(210, 127);
            this.SearchCust.TabIndex = 1;
            this.SearchCust.Text = "חיפוש לקוח";
            this.SearchCust.UseVisualStyleBackColor = false;
            this.SearchCust.Click += new System.EventHandler(this.SearchCust_Click);
            // 
            // disFromCustPage
            // 
            this.disFromCustPage.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disFromCustPage.Location = new System.Drawing.Point(0, 0);
            this.disFromCustPage.Name = "disFromCustPage";
            this.disFromCustPage.Size = new System.Drawing.Size(94, 36);
            this.disFromCustPage.TabIndex = 3;
            this.disFromCustPage.Text = "התנתק";
            this.disFromCustPage.UseVisualStyleBackColor = true;
            this.disFromCustPage.Click += new System.EventHandler(this.disFromCustPage_Click);
            // 
            // backFromCustomers
            // 
            this.backFromCustomers.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backFromCustomers.Location = new System.Drawing.Point(381, 503);
            this.backFromCustomers.Name = "backFromCustomers";
            this.backFromCustomers.Size = new System.Drawing.Size(94, 36);
            this.backFromCustomers.TabIndex = 4;
            this.backFromCustomers.Text = "חזור";
            this.backFromCustomers.UseVisualStyleBackColor = true;
            this.backFromCustomers.Click += new System.EventHandler(this.backFromCustomers_Click);
            // 
            // CreateCus
            // 
            this.CreateCus.BackColor = System.Drawing.Color.Transparent;
            this.CreateCus.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCus.Location = new System.Drawing.Point(196, 240);
            this.CreateCus.Name = "CreateCus";
            this.CreateCus.Size = new System.Drawing.Size(221, 127);
            this.CreateCus.TabIndex = 5;
            this.CreateCus.Text = "צור לקוח";
            this.CreateCus.UseVisualStyleBackColor = false;
            this.CreateCus.Click += new System.EventHandler(this.CreateCus_Click);
            // 
            // Customer_sPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.CreateCus);
            this.Controls.Add(this.backFromCustomers);
            this.Controls.Add(this.disFromCustPage);
            this.Controls.Add(this.SearchCust);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Customer_sPage";
            this.Text = "Customer_sPage";
            this.Load += new System.EventHandler(this.Customer_sPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchCust;
        private System.Windows.Forms.Button CreateCust;
        private System.Windows.Forms.Button disFromCustPage;
        private System.Windows.Forms.Button backFromCustomers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CreateCus;
    }
}