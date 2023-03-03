namespace GROUP16
{
    partial class ExistingInventory
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
            this.components = new System.ComponentModel.Container();
            this.ExitInventory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTICKERPAPERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_16DataSet2 = new GROUP16.SAD_16DataSet2();
            this.UpdateQuantity = new System.Windows.Forms.Button();
            this.sTICKERPAPERSTableAdapter = new GROUP16.SAD_16DataSet2TableAdapters.STICKERPAPERSTableAdapter();
            this.productNumber = new System.Windows.Forms.TextBox();
            this.backFromExisting = new System.Windows.Forms.Button();
            this.InStock = new System.Windows.Forms.TextBox();
            this.makeOrder = new System.Windows.Forms.Button();
            this.relevantSupp = new System.Windows.Forms.DataGridView();
            this.sUPPLIERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUPPLIERSTableAdapter = new GROUP16.SAD_16DataSet2TableAdapters.SUPPLIERSTableAdapter();
            this.amountToOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shopSuppPage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTICKERPAPERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relevantSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitInventory
            // 
            this.ExitInventory.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitInventory.Location = new System.Drawing.Point(1, 2);
            this.ExitInventory.Name = "ExitInventory";
            this.ExitInventory.Size = new System.Drawing.Size(83, 29);
            this.ExitInventory.TabIndex = 0;
            this.ExitInventory.Text = "התנתק";
            this.ExitInventory.UseVisualStyleBackColor = true;
            this.ExitInventory.Click += new System.EventHandler(this.ExitInventory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "מספר פריט";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(738, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "כמות במלאי";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumberDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productWidthDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTICKERPAPERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(428, 351);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            this.productNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productWidthDataGridViewTextBoxColumn
            // 
            this.productWidthDataGridViewTextBoxColumn.DataPropertyName = "ProductWidth";
            this.productWidthDataGridViewTextBoxColumn.HeaderText = "ProductWidth";
            this.productWidthDataGridViewTextBoxColumn.Name = "productWidthDataGridViewTextBoxColumn";
            this.productWidthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTICKERPAPERSBindingSource
            // 
            this.sTICKERPAPERSBindingSource.DataMember = "STICKERPAPERS";
            this.sTICKERPAPERSBindingSource.DataSource = this.sAD_16DataSet2;
            // 
            // sAD_16DataSet2
            // 
            this.sAD_16DataSet2.DataSetName = "SAD_16DataSet2";
            this.sAD_16DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UpdateQuantity
            // 
            this.UpdateQuantity.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateQuantity.Location = new System.Drawing.Point(530, 267);
            this.UpdateQuantity.Name = "UpdateQuantity";
            this.UpdateQuantity.Size = new System.Drawing.Size(88, 28);
            this.UpdateQuantity.TabIndex = 8;
            this.UpdateQuantity.Text = "עדכן";
            this.UpdateQuantity.UseVisualStyleBackColor = true;
            this.UpdateQuantity.Click += new System.EventHandler(this.UpdateQuantity_Click);
            // 
            // sTICKERPAPERSTableAdapter
            // 
            this.sTICKERPAPERSTableAdapter.ClearBeforeFill = true;
            // 
            // productNumber
            // 
            this.productNumber.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNumber.Location = new System.Drawing.Point(624, 231);
            this.productNumber.Name = "productNumber";
            this.productNumber.Size = new System.Drawing.Size(100, 29);
            this.productNumber.TabIndex = 9;
            this.productNumber.TextChanged += new System.EventHandler(this.productNumber_TextChanged);
            // 
            // backFromExisting
            // 
            this.backFromExisting.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backFromExisting.Location = new System.Drawing.Point(417, 514);
            this.backFromExisting.Name = "backFromExisting";
            this.backFromExisting.Size = new System.Drawing.Size(99, 35);
            this.backFromExisting.TabIndex = 10;
            this.backFromExisting.Text = "חזור";
            this.backFromExisting.UseVisualStyleBackColor = true;
            this.backFromExisting.Click += new System.EventHandler(this.backFromExisting_Click);
            // 
            // InStock
            // 
            this.InStock.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InStock.Location = new System.Drawing.Point(624, 266);
            this.InStock.Name = "InStock";
            this.InStock.Size = new System.Drawing.Size(100, 29);
            this.InStock.TabIndex = 11;
            this.InStock.TextChanged += new System.EventHandler(this.InStock_TextChanged);
            // 
            // makeOrder
            // 
            this.makeOrder.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeOrder.Location = new System.Drawing.Point(535, 478);
            this.makeOrder.Name = "makeOrder";
            this.makeOrder.Size = new System.Drawing.Size(94, 29);
            this.makeOrder.TabIndex = 12;
            this.makeOrder.Text = "בצע הזמנה";
            this.makeOrder.UseVisualStyleBackColor = true;
            this.makeOrder.Click += new System.EventHandler(this.makeOrder_Click);
            // 
            // relevantSupp
            // 
            this.relevantSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relevantSupp.Location = new System.Drawing.Point(640, 342);
            this.relevantSupp.Name = "relevantSupp";
            this.relevantSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.relevantSupp.Size = new System.Drawing.Size(193, 150);
            this.relevantSupp.TabIndex = 13;
            this.relevantSupp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.relevantSupp_CellContentClick);
            // 
            // sUPPLIERSBindingSource
            // 
            this.sUPPLIERSBindingSource.DataMember = "SUPPLIERS";
            this.sUPPLIERSBindingSource.DataSource = this.sAD_16DataSet2;
            // 
            // sUPPLIERSTableAdapter
            // 
            this.sUPPLIERSTableAdapter.ClearBeforeFill = true;
            // 
            // amountToOrder
            // 
            this.amountToOrder.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountToOrder.Location = new System.Drawing.Point(530, 443);
            this.amountToOrder.Name = "amountToOrder";
            this.amountToOrder.Size = new System.Drawing.Size(105, 29);
            this.amountToOrder.TabIndex = 14;
            this.amountToOrder.TextChanged += new System.EventHandler(this.amountToOrder_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 318);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "ספקים רלוונטיים:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(531, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = ":כמות להזמנה";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 45);
            this.label5.TabIndex = 17;
            this.label5.Text = "ארגון מלאי";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 97);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "בחר סוג נייר:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // shopSuppPage
            // 
            this.shopSuppPage.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopSuppPage.Location = new System.Drawing.Point(519, 342);
            this.shopSuppPage.Name = "shopSuppPage";
            this.shopSuppPage.Size = new System.Drawing.Size(115, 35);
            this.shopSuppPage.TabIndex = 20;
            this.shopSuppPage.Text = "הצג דף ספק";
            this.shopSuppPage.UseVisualStyleBackColor = true;
            this.shopSuppPage.Click += new System.EventHandler(this.shopSuppPage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(396, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "שים לב! מסומנים פריטים בהם המלאי נמוך מ1500 מטר";
            // 
            // ExistingInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.shopSuppPage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountToOrder);
            this.Controls.Add(this.relevantSupp);
            this.Controls.Add(this.makeOrder);
            this.Controls.Add(this.InStock);
            this.Controls.Add(this.backFromExisting);
            this.Controls.Add(this.productNumber);
            this.Controls.Add(this.UpdateQuantity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitInventory);
            this.DoubleBuffered = true;
            this.Name = "ExistingInventory";
            this.Text = "ExistingInventory";
            this.Load += new System.EventHandler(this.ExistingInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTICKERPAPERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relevantSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateQuantity;
        private SAD_16DataSet2 sAD_16DataSet2;
        private System.Windows.Forms.BindingSource sTICKERPAPERSBindingSource;
        private SAD_16DataSet2TableAdapters.STICKERPAPERSTableAdapter sTICKERPAPERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox productNumber;
        private System.Windows.Forms.Button backFromExisting;
        private System.Windows.Forms.TextBox InStock;
        private System.Windows.Forms.Button makeOrder;
        private System.Windows.Forms.DataGridView relevantSupp;
        private System.Windows.Forms.BindingSource sUPPLIERSBindingSource;
        private SAD_16DataSet2TableAdapters.SUPPLIERSTableAdapter sUPPLIERSTableAdapter;
        private System.Windows.Forms.TextBox amountToOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button shopSuppPage;
        private System.Windows.Forms.Label label7;
    }
}