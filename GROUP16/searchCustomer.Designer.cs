namespace GROUP16
{
    partial class searchCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.TextBox();
            this.searchCustByNum = new System.Windows.Forms.TextBox();
            this.custPhone = new System.Windows.Forms.TextBox();
            this.custEmail = new System.Windows.Forms.TextBox();
            this.disFromSearchCus = new System.Windows.Forms.Button();
            this.searchCustButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createOrderFromCust = new System.Windows.Forms.Button();
            this.exitFromSerachCust = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "לקוחות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "מספר לקוח";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "שם לקוח";
            // 
            // custName
            // 
            this.custName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(375, 246);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(122, 29);
            this.custName.TabIndex = 3;
            this.custName.TextChanged += new System.EventHandler(this.custName_TextChanged);
            // 
            // searchCustByNum
            // 
            this.searchCustByNum.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustByNum.Location = new System.Drawing.Point(375, 171);
            this.searchCustByNum.Name = "searchCustByNum";
            this.searchCustByNum.Size = new System.Drawing.Size(122, 29);
            this.searchCustByNum.TabIndex = 4;
            this.searchCustByNum.TextChanged += new System.EventHandler(this.searchCustByNum_TextChanged);
            // 
            // custPhone
            // 
            this.custPhone.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPhone.Location = new System.Drawing.Point(375, 291);
            this.custPhone.Name = "custPhone";
            this.custPhone.Size = new System.Drawing.Size(122, 29);
            this.custPhone.TabIndex = 5;
            // 
            // custEmail
            // 
            this.custEmail.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custEmail.Location = new System.Drawing.Point(375, 334);
            this.custEmail.Name = "custEmail";
            this.custEmail.Size = new System.Drawing.Size(122, 29);
            this.custEmail.TabIndex = 6;
            // 
            // disFromSearchCus
            // 
            this.disFromSearchCus.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disFromSearchCus.Location = new System.Drawing.Point(2, 2);
            this.disFromSearchCus.Name = "disFromSearchCus";
            this.disFromSearchCus.Size = new System.Drawing.Size(75, 39);
            this.disFromSearchCus.TabIndex = 7;
            this.disFromSearchCus.Text = "התנתק";
            this.disFromSearchCus.UseVisualStyleBackColor = true;
            this.disFromSearchCus.Click += new System.EventHandler(this.disFromSearchCus_Click);
            // 
            // searchCustButton
            // 
            this.searchCustButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustButton.Location = new System.Drawing.Point(272, 169);
            this.searchCustButton.Name = "searchCustButton";
            this.searchCustButton.Size = new System.Drawing.Size(75, 31);
            this.searchCustButton.TabIndex = 8;
            this.searchCustButton.Text = "חפש";
            this.searchCustButton.UseVisualStyleBackColor = true;
            this.searchCustButton.Click += new System.EventHandler(this.searchCustButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "מספר טלפון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "אימייל";
            // 
            // createOrderFromCust
            // 
            this.createOrderFromCust.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrderFromCust.Location = new System.Drawing.Point(202, 391);
            this.createOrderFromCust.Name = "createOrderFromCust";
            this.createOrderFromCust.Size = new System.Drawing.Size(145, 33);
            this.createOrderFromCust.TabIndex = 11;
            this.createOrderFromCust.Text = "צור הזמנה ללקוח";
            this.createOrderFromCust.UseVisualStyleBackColor = true;
            this.createOrderFromCust.Click += new System.EventHandler(this.createOrderFromCust_Click);
            // 
            // exitFromSerachCust
            // 
            this.exitFromSerachCust.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitFromSerachCust.Location = new System.Drawing.Point(400, 467);
            this.exitFromSerachCust.Name = "exitFromSerachCust";
            this.exitFromSerachCust.Size = new System.Drawing.Size(75, 33);
            this.exitFromSerachCust.TabIndex = 12;
            this.exitFromSerachCust.Text = "חזור";
            this.exitFromSerachCust.UseVisualStyleBackColor = true;
            this.exitFromSerachCust.Click += new System.EventHandler(this.exitFromSerachCust_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomerButton.Location = new System.Drawing.Point(375, 391);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(122, 33);
            this.updateCustomerButton.TabIndex = 13;
            this.updateCustomerButton.Text = "עדכן לקוח";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // searchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.updateCustomerButton);
            this.Controls.Add(this.exitFromSerachCust);
            this.Controls.Add(this.createOrderFromCust);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchCustButton);
            this.Controls.Add(this.disFromSearchCus);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.custPhone);
            this.Controls.Add(this.searchCustByNum);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "searchCustomer";
            this.Text = "searchCustomer";
            this.Load += new System.EventHandler(this.searchCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.TextBox searchCustByNum;
        private System.Windows.Forms.TextBox custPhone;
        private System.Windows.Forms.TextBox custEmail;
        private System.Windows.Forms.Button disFromSearchCus;
        private System.Windows.Forms.Button searchCustButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createOrderFromCust;
        private System.Windows.Forms.Button exitFromSerachCust;
        private System.Windows.Forms.Button updateCustomerButton;
    }
}