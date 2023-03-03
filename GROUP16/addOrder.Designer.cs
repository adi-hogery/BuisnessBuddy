namespace GROUP16
{
    partial class addOrder
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
            this.disFromCreateOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ordAddress = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.priority = new System.Windows.Forms.TextBox();
            this.dueDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orderNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ordLength = new System.Windows.Forms.TextBox();
            this.ordWidth = new System.Windows.Forms.TextBox();
            this.knifeType = new System.Windows.Forms.TextBox();
            this.ordGraphic = new System.Windows.Forms.TextBox();
            this.ordCustomer = new System.Windows.Forms.TextBox();
            this.createOrder = new System.Windows.Forms.Button();
            this.exitFromCreateOrder = new System.Windows.Forms.Button();
            this.giveDiscount = new System.Windows.Forms.Button();
            this.ordPrice = new System.Windows.Forms.TextBox();
            this.calcPriceButton = new System.Windows.Forms.Button();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.PaperType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.knieTypeCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // disFromCreateOrder
            // 
            this.disFromCreateOrder.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disFromCreateOrder.Location = new System.Drawing.Point(1, 3);
            this.disFromCreateOrder.Name = "disFromCreateOrder";
            this.disFromCreateOrder.Size = new System.Drawing.Size(72, 36);
            this.disFromCreateOrder.TabIndex = 0;
            this.disFromCreateOrder.Text = "התנתק";
            this.disFromCreateOrder.UseVisualStyleBackColor = true;
            this.disFromCreateOrder.Click += new System.EventHandler(this.disFromCreateOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "יצירת הזמנה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(559, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "עדיפות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "כמות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "כתובת";
            // 
            // ordAddress
            // 
            this.ordAddress.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordAddress.Location = new System.Drawing.Point(412, 351);
            this.ordAddress.Name = "ordAddress";
            this.ordAddress.Size = new System.Drawing.Size(100, 29);
            this.ordAddress.TabIndex = 7;
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(412, 310);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 29);
            this.amount.TabIndex = 8;
            this.amount.TextChanged += new System.EventHandler(this.amount_TextChanged);
            // 
            // priority
            // 
            this.priority.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priority.Location = new System.Drawing.Point(412, 267);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(100, 29);
            this.priority.TabIndex = 9;
            // 
            // dueDate
            // 
            this.dueDate.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate.Location = new System.Drawing.Point(412, 225);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(100, 29);
            this.dueDate.TabIndex = 10;
            this.dueDate.TextChanged += new System.EventHandler(this.dueDate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "תאריך יעד";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "מספר הזמנה";
            // 
            // orderNum
            // 
            this.orderNum.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNum.Location = new System.Drawing.Point(412, 184);
            this.orderNum.Name = "orderNum";
            this.orderNum.ReadOnly = true;
            this.orderNum.Size = new System.Drawing.Size(100, 29);
            this.orderNum.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "אורך";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(281, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "רוחב";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(260, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "סוג סכין";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "מספר גרפיקה";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(280, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "לקוח";
            // 
            // ordLength
            // 
            this.ordLength.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordLength.Location = new System.Drawing.Point(411, 393);
            this.ordLength.Name = "ordLength";
            this.ordLength.Size = new System.Drawing.Size(100, 29);
            this.ordLength.TabIndex = 19;
            this.ordLength.TextChanged += new System.EventHandler(this.ordLength_TextChanged);
            // 
            // ordWidth
            // 
            this.ordWidth.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordWidth.Location = new System.Drawing.Point(106, 183);
            this.ordWidth.Name = "ordWidth";
            this.ordWidth.Size = new System.Drawing.Size(100, 29);
            this.ordWidth.TabIndex = 20;
            this.ordWidth.TextChanged += new System.EventHandler(this.ordWidth_TextChanged);
            // 
            // knifeType
            // 
            this.knifeType.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knifeType.Location = new System.Drawing.Point(107, 223);
            this.knifeType.Name = "knifeType";
            this.knifeType.Size = new System.Drawing.Size(100, 29);
            this.knifeType.TabIndex = 21;
            this.knifeType.TextChanged += new System.EventHandler(this.knifeType_TextChanged);
            // 
            // ordGraphic
            // 
            this.ordGraphic.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordGraphic.Location = new System.Drawing.Point(107, 306);
            this.ordGraphic.Name = "ordGraphic";
            this.ordGraphic.Size = new System.Drawing.Size(100, 29);
            this.ordGraphic.TabIndex = 22;
            // 
            // ordCustomer
            // 
            this.ordCustomer.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordCustomer.Location = new System.Drawing.Point(107, 343);
            this.ordCustomer.Name = "ordCustomer";
            this.ordCustomer.Size = new System.Drawing.Size(100, 29);
            this.ordCustomer.TabIndex = 23;
            // 
            // createOrder
            // 
            this.createOrder.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrder.Location = new System.Drawing.Point(353, 481);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(120, 31);
            this.createOrder.TabIndex = 24;
            this.createOrder.Text = "צור הזמנה";
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // exitFromCreateOrder
            // 
            this.exitFromCreateOrder.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitFromCreateOrder.Location = new System.Drawing.Point(377, 518);
            this.exitFromCreateOrder.Name = "exitFromCreateOrder";
            this.exitFromCreateOrder.Size = new System.Drawing.Size(85, 31);
            this.exitFromCreateOrder.TabIndex = 25;
            this.exitFromCreateOrder.Text = "חזור";
            this.exitFromCreateOrder.UseVisualStyleBackColor = true;
            this.exitFromCreateOrder.Click += new System.EventHandler(this.exitFromCreateOrder_Click);
            // 
            // giveDiscount
            // 
            this.giveDiscount.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveDiscount.Location = new System.Drawing.Point(237, 426);
            this.giveDiscount.Name = "giveDiscount";
            this.giveDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.giveDiscount.Size = new System.Drawing.Size(114, 29);
            this.giveDiscount.TabIndex = 26;
            this.giveDiscount.Text = "הזן הנחה (%)";
            this.giveDiscount.UseVisualStyleBackColor = true;
            this.giveDiscount.Click += new System.EventHandler(this.giveDiscount_Click);
            // 
            // ordPrice
            // 
            this.ordPrice.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordPrice.Location = new System.Drawing.Point(107, 384);
            this.ordPrice.Name = "ordPrice";
            this.ordPrice.Size = new System.Drawing.Size(100, 29);
            this.ordPrice.TabIndex = 6;
            this.ordPrice.TextChanged += new System.EventHandler(this.ordPrice_TextChanged);
            // 
            // calcPriceButton
            // 
            this.calcPriceButton.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcPriceButton.Location = new System.Drawing.Point(237, 384);
            this.calcPriceButton.Name = "calcPriceButton";
            this.calcPriceButton.Size = new System.Drawing.Size(114, 30);
            this.calcPriceButton.TabIndex = 27;
            this.calcPriceButton.Text = "חשב מחיר";
            this.calcPriceButton.UseVisualStyleBackColor = true;
            this.calcPriceButton.Click += new System.EventHandler(this.calcPriceButton_Click);
            // 
            // discountTextBox
            // 
            this.discountTextBox.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.Location = new System.Drawing.Point(106, 426);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(101, 29);
            this.discountTextBox.TabIndex = 28;
            this.discountTextBox.TextChanged += new System.EventHandler(this.discountTextBox_TextChanged);
            // 
            // PaperType
            // 
            this.PaperType.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperType.FormattingEnabled = true;
            this.PaperType.Location = new System.Drawing.Point(106, 261);
            this.PaperType.Name = "PaperType";
            this.PaperType.Size = new System.Drawing.Size(100, 29);
            this.PaperType.TabIndex = 29;
            this.PaperType.SelectedIndexChanged += new System.EventHandler(this.PaperType_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(265, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "סוג נייר";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // knieTypeCombo
            // 
            this.knieTypeCombo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knieTypeCombo.FormattingEnabled = true;
            this.knieTypeCombo.Location = new System.Drawing.Point(106, 223);
            this.knieTypeCombo.Name = "knieTypeCombo";
            this.knieTypeCombo.Size = new System.Drawing.Size(100, 29);
            this.knieTypeCombo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "(YYYY-MM-DD)";
            // 
            // addOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.knieTypeCombo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PaperType);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.calcPriceButton);
            this.Controls.Add(this.giveDiscount);
            this.Controls.Add(this.exitFromCreateOrder);
            this.Controls.Add(this.createOrder);
            this.Controls.Add(this.ordCustomer);
            this.Controls.Add(this.ordGraphic);
            this.Controls.Add(this.knifeType);
            this.Controls.Add(this.ordWidth);
            this.Controls.Add(this.ordLength);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.orderNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.ordAddress);
            this.Controls.Add(this.ordPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disFromCreateOrder);
            this.DoubleBuffered = true;
            this.Name = "addOrder";
            this.Text = "s";
            this.Load += new System.EventHandler(this.addOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disFromCreateOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox ordAddress;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox priority;
        private System.Windows.Forms.TextBox dueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox orderNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ordLength;
        private System.Windows.Forms.TextBox ordWidth;
        private System.Windows.Forms.TextBox ordPrice;
        private System.Windows.Forms.TextBox knifeType;
        private System.Windows.Forms.TextBox ordGraphic;
        private System.Windows.Forms.TextBox ordCustomer;
        private System.Windows.Forms.Button createOrder;
        private System.Windows.Forms.Button exitFromCreateOrder;
        private System.Windows.Forms.Button giveDiscount;
        private System.Windows.Forms.Button calcPriceButton;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.ComboBox PaperType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox knieTypeCombo;
        private System.Windows.Forms.Label label5;
    }
}