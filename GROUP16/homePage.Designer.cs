namespace GROUP16
{
    partial class homePage
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
            this.manageEmployees = new System.Windows.Forms.Button();
            this.manageOrders = new System.Windows.Forms.Button();
            this.manageSchedule = new System.Windows.Forms.Button();
            this.inventoryManagement = new System.Windows.Forms.Button();
            this.sendingMail = new System.Windows.Forms.Button();
            this.disFromHome = new System.Windows.Forms.Button();
            this.custButton = new System.Windows.Forms.Button();
            this.suppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(269, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "מדבקה ברגע בע\"מ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // manageEmployees
            // 
            this.manageEmployees.BackColor = System.Drawing.Color.Transparent;
            this.manageEmployees.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manageEmployees.Location = new System.Drawing.Point(135, 175);
            this.manageEmployees.Name = "manageEmployees";
            this.manageEmployees.Size = new System.Drawing.Size(125, 82);
            this.manageEmployees.TabIndex = 1;
            this.manageEmployees.Text = "ניהול עובדים";
            this.manageEmployees.UseVisualStyleBackColor = false;
            this.manageEmployees.Click += new System.EventHandler(this.manageEmployees_Click);
            // 
            // manageOrders
            // 
            this.manageOrders.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manageOrders.Location = new System.Drawing.Point(283, 175);
            this.manageOrders.Name = "manageOrders";
            this.manageOrders.Size = new System.Drawing.Size(130, 82);
            this.manageOrders.TabIndex = 2;
            this.manageOrders.Text = "הזמנות";
            this.manageOrders.UseVisualStyleBackColor = true;
            this.manageOrders.Click += new System.EventHandler(this.manageOrders_Click);
            // 
            // manageSchedule
            // 
            this.manageSchedule.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.manageSchedule.Location = new System.Drawing.Point(433, 280);
            this.manageSchedule.Name = "manageSchedule";
            this.manageSchedule.Size = new System.Drawing.Size(125, 82);
            this.manageSchedule.TabIndex = 3;
            this.manageSchedule.Text = "לוח אירועים";
            this.manageSchedule.UseVisualStyleBackColor = true;
            this.manageSchedule.Click += new System.EventHandler(this.manageSchedule_Click);
            // 
            // inventoryManagement
            // 
            this.inventoryManagement.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.inventoryManagement.Location = new System.Drawing.Point(288, 282);
            this.inventoryManagement.Name = "inventoryManagement";
            this.inventoryManagement.Size = new System.Drawing.Size(125, 80);
            this.inventoryManagement.TabIndex = 4;
            this.inventoryManagement.Text = "ארגון מלאי";
            this.inventoryManagement.UseVisualStyleBackColor = true;
            this.inventoryManagement.Click += new System.EventHandler(this.inventoryManagement_Click);
            // 
            // sendingMail
            // 
            this.sendingMail.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sendingMail.Location = new System.Drawing.Point(580, 280);
            this.sendingMail.Name = "sendingMail";
            this.sendingMail.Size = new System.Drawing.Size(130, 82);
            this.sendingMail.TabIndex = 5;
            this.sendingMail.Text = "שליחת מייל";
            this.sendingMail.UseVisualStyleBackColor = true;
            this.sendingMail.Click += new System.EventHandler(this.sendingMail_Click);
            // 
            // disFromHome
            // 
            this.disFromHome.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.disFromHome.Location = new System.Drawing.Point(392, 447);
            this.disFromHome.Name = "disFromHome";
            this.disFromHome.Size = new System.Drawing.Size(78, 39);
            this.disFromHome.TabIndex = 6;
            this.disFromHome.Text = "התנתק";
            this.disFromHome.UseVisualStyleBackColor = true;
            this.disFromHome.Click += new System.EventHandler(this.disFromHome_Click);
            // 
            // custButton
            // 
            this.custButton.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.custButton.Location = new System.Drawing.Point(429, 175);
            this.custButton.Name = "custButton";
            this.custButton.Size = new System.Drawing.Size(129, 82);
            this.custButton.TabIndex = 7;
            this.custButton.Text = "לקוחות";
            this.custButton.UseVisualStyleBackColor = true;
            this.custButton.Click += new System.EventHandler(this.custButton_Click);
            // 
            // suppButton
            // 
            this.suppButton.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.suppButton.Location = new System.Drawing.Point(135, 280);
            this.suppButton.Name = "suppButton";
            this.suppButton.Size = new System.Drawing.Size(125, 82);
            this.suppButton.TabIndex = 8;
            this.suppButton.Text = "ספקים";
            this.suppButton.UseVisualStyleBackColor = true;
            this.suppButton.Click += new System.EventHandler(this.suppButton_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.suppButton);
            this.Controls.Add(this.custButton);
            this.Controls.Add(this.disFromHome);
            this.Controls.Add(this.sendingMail);
            this.Controls.Add(this.inventoryManagement);
            this.Controls.Add(this.manageSchedule);
            this.Controls.Add(this.manageOrders);
            this.Controls.Add(this.manageEmployees);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "homePage";
            this.Text = "homePage";
            this.Load += new System.EventHandler(this.homePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manageEmployees;
        private System.Windows.Forms.Button manageOrders;
        private System.Windows.Forms.Button manageSchedule;
        private System.Windows.Forms.Button inventoryManagement;
        private System.Windows.Forms.Button sendingMail;
        private System.Windows.Forms.Button disFromHome;
        private System.Windows.Forms.Button custButton;
        private System.Windows.Forms.Button suppButton;
    }
}