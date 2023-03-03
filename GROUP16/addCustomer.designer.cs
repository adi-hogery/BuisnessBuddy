namespace GROUP16
{
    partial class addCustomer
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
            this.custEmail = new System.Windows.Forms.TextBox();
            this.custPhone = new System.Windows.Forms.TextBox();
            this.custNum = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.disFromCreateCustomer = new System.Windows.Forms.Button();
            this.createCusBot = new System.Windows.Forms.Button();
            this.exitFromNewCust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "יצירת לקוח חדש";
            // 
            // custEmail
            // 
            this.custEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.custEmail.Location = new System.Drawing.Point(284, 317);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(130, 23);
            this.custEmail.TabIndex = 1;
            // 
            // custPhone
            // 
            this.custPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.custPhone.Location = new System.Drawing.Point(284, 276);
            this.custPhone.Name = "custPhone";
            this.custPhone.Size = new System.Drawing.Size(130, 23);
            this.custPhone.TabIndex = 2;
            // 
            // custNum
            // 
            this.custNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.custNum.Location = new System.Drawing.Point(284, 184);
            this.custNum.Name = "custNum";
            this.custNum.ReadOnly = true;
            this.custNum.Size = new System.Drawing.Size(130, 23);
            this.custNum.TabIndex = 3;
            // 
            // custName
            // 
            this.custName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.custName.Location = new System.Drawing.Point(284, 228);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(130, 23);
            this.custName.TabIndex = 4;
            this.custName.TextChanged += new System.EventHandler(this.custName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "מספר לקוח";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "שם לקוח";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "טלפון";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "אימייל";
            // 
            // disFromCreateCustomer
            // 
            this.disFromCreateCustomer.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disFromCreateCustomer.Location = new System.Drawing.Point(0, 3);
            this.disFromCreateCustomer.Name = "disFromCreateCustomer";
            this.disFromCreateCustomer.Size = new System.Drawing.Size(82, 30);
            this.disFromCreateCustomer.TabIndex = 9;
            this.disFromCreateCustomer.Text = "התנתק";
            this.disFromCreateCustomer.UseVisualStyleBackColor = true;
            this.disFromCreateCustomer.Click += new System.EventHandler(this.disFromCreateCustomer_Click_1);
            // 
            // createCusBot
            // 
            this.createCusBot.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCusBot.Location = new System.Drawing.Point(382, 428);
            this.createCusBot.Name = "createCusBot";
            this.createCusBot.Size = new System.Drawing.Size(84, 30);
            this.createCusBot.TabIndex = 10;
            this.createCusBot.Text = "צור לקוח";
            this.createCusBot.UseVisualStyleBackColor = true;
            this.createCusBot.Click += new System.EventHandler(this.createCusBot_Click_1);
            // 
            // exitFromNewCust
            // 
            this.exitFromNewCust.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitFromNewCust.Location = new System.Drawing.Point(382, 480);
            this.exitFromNewCust.Name = "exitFromNewCust";
            this.exitFromNewCust.Size = new System.Drawing.Size(84, 30);
            this.exitFromNewCust.TabIndex = 11;
            this.exitFromNewCust.Text = "חזור";
            this.exitFromNewCust.UseVisualStyleBackColor = true;
            this.exitFromNewCust.Click += new System.EventHandler(this.exitFromNewCust_Click_1);
            // 
            // addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.exitFromNewCust);
            this.Controls.Add(this.createCusBot);
            this.Controls.Add(this.disFromCreateCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.custNum);
            this.Controls.Add(this.custPhone);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "addCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.addCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custEmail;
        private System.Windows.Forms.TextBox custPhone;
        private System.Windows.Forms.TextBox custNum;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button disFromCreateCustomer;
        private System.Windows.Forms.Button createCusBot;
        private System.Windows.Forms.Button exitFromNewCust;
    }
}

