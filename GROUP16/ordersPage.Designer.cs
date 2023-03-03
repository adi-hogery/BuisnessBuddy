namespace GROUP16
{
    partial class ordersPage
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
            this.liveQueue = new System.Windows.Forms.DataGridView();
            this.relevantOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_16DataSet2 = new GROUP16.SAD_16DataSet2();
            this.relevantOrdersTableAdapter = new GROUP16.SAD_16DataSet2TableAdapters.relevantOrdersTableAdapter();
            this.disFromOrdersPage = new System.Windows.Forms.Button();
            this.exitFromOrdersPage = new System.Windows.Forms.Button();
            this.searchOrderByCustomer = new System.Windows.Forms.TextBox();
            this.fromDateOrder = new System.Windows.Forms.DateTimePicker();
            this.toDateOrder = new System.Windows.Forms.DateTimePicker();
            this.searchOrderByOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderSearchButton = new System.Windows.Forms.Button();
            this.perDateCheckBox = new System.Windows.Forms.CheckBox();
            this.getallColorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_all_ColorsTableAdapter = new GROUP16.SAD_16DataSet2TableAdapters.Get_all_ColorsTableAdapter();
            this.getORDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_ORDERSTableAdapter = new GROUP16.SAD_16DataSet2TableAdapters.Get_ORDERSTableAdapter();
            this.getORDERSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchQueue = new System.Windows.Forms.DataGridView();
            this.backToLiveQueue = new System.Windows.Forms.Button();
            this.sAD_16DataSet5 = new GROUP16.SAD_16DataSet5();
            this.getliveORDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_live_ORDERSTableAdapter = new GROUP16.SAD_16DataSet5TableAdapters.Get_live_ORDERSTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.liveQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relevantOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallColorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getORDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getORDERSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getliveORDERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // liveQueue
            // 
            this.liveQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liveQueue.Location = new System.Drawing.Point(30, 122);
            this.liveQueue.Name = "liveQueue";
            this.liveQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liveQueue.Size = new System.Drawing.Size(444, 300);
            this.liveQueue.TabIndex = 0;
            this.liveQueue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.liveQueue_CellContentClick);
            // 
            // relevantOrdersBindingSource
            // 
            this.relevantOrdersBindingSource.DataMember = "relevantOrders";
            this.relevantOrdersBindingSource.DataSource = this.sAD_16DataSet2;
            // 
            // sAD_16DataSet2
            // 
            this.sAD_16DataSet2.DataSetName = "SAD_16DataSet2";
            this.sAD_16DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relevantOrdersTableAdapter
            // 
            this.relevantOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // disFromOrdersPage
            // 
            this.disFromOrdersPage.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disFromOrdersPage.Location = new System.Drawing.Point(2, 3);
            this.disFromOrdersPage.Name = "disFromOrdersPage";
            this.disFromOrdersPage.Size = new System.Drawing.Size(81, 27);
            this.disFromOrdersPage.TabIndex = 1;
            this.disFromOrdersPage.Text = "התנתק";
            this.disFromOrdersPage.UseVisualStyleBackColor = true;
            this.disFromOrdersPage.Click += new System.EventHandler(this.disFromOrdersPage_Click);
            // 
            // exitFromOrdersPage
            // 
            this.exitFromOrdersPage.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitFromOrdersPage.Location = new System.Drawing.Point(399, 496);
            this.exitFromOrdersPage.Name = "exitFromOrdersPage";
            this.exitFromOrdersPage.Size = new System.Drawing.Size(85, 30);
            this.exitFromOrdersPage.TabIndex = 2;
            this.exitFromOrdersPage.Text = "חזור";
            this.exitFromOrdersPage.UseVisualStyleBackColor = true;
            this.exitFromOrdersPage.Click += new System.EventHandler(this.exitFromOrdersPage_Click);
            // 
            // searchOrderByCustomer
            // 
            this.searchOrderByCustomer.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOrderByCustomer.Location = new System.Drawing.Point(538, 290);
            this.searchOrderByCustomer.Name = "searchOrderByCustomer";
            this.searchOrderByCustomer.Size = new System.Drawing.Size(200, 29);
            this.searchOrderByCustomer.TabIndex = 3;
            // 
            // fromDateOrder
            // 
            this.fromDateOrder.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDateOrder.Location = new System.Drawing.Point(538, 366);
            this.fromDateOrder.Name = "fromDateOrder";
            this.fromDateOrder.Size = new System.Drawing.Size(205, 29);
            this.fromDateOrder.TabIndex = 6;
            // 
            // toDateOrder
            // 
            this.toDateOrder.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateOrder.Location = new System.Drawing.Point(538, 403);
            this.toDateOrder.Name = "toDateOrder";
            this.toDateOrder.Size = new System.Drawing.Size(205, 29);
            this.toDateOrder.TabIndex = 7;
            // 
            // searchOrderByOrder
            // 
            this.searchOrderByOrder.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchOrderByOrder.Location = new System.Drawing.Point(538, 244);
            this.searchOrderByOrder.Name = "searchOrderByOrder";
            this.searchOrderByOrder.Size = new System.Drawing.Size(200, 29);
            this.searchOrderByOrder.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "מספר הזמנה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "מספר לקוח";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "מתאריך";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(763, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "עד תאריך";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 45);
            this.label5.TabIndex = 13;
            this.label5.Text = "תור הזמנות";
            // 
            // orderSearchButton
            // 
            this.orderSearchButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSearchButton.Location = new System.Drawing.Point(611, 457);
            this.orderSearchButton.Name = "orderSearchButton";
            this.orderSearchButton.Size = new System.Drawing.Size(85, 30);
            this.orderSearchButton.TabIndex = 14;
            this.orderSearchButton.Text = "חפש";
            this.orderSearchButton.UseVisualStyleBackColor = true;
            this.orderSearchButton.Click += new System.EventHandler(this.orderSearchButton_Click);
            // 
            // perDateCheckBox
            // 
            this.perDateCheckBox.AutoSize = true;
            this.perDateCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.perDateCheckBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perDateCheckBox.Location = new System.Drawing.Point(736, 335);
            this.perDateCheckBox.Name = "perDateCheckBox";
            this.perDateCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.perDateCheckBox.Size = new System.Drawing.Size(105, 25);
            this.perDateCheckBox.TabIndex = 15;
            this.perDateCheckBox.Text = "לפי תאריך";
            this.perDateCheckBox.UseVisualStyleBackColor = false;
            this.perDateCheckBox.CheckedChanged += new System.EventHandler(this.perDateCheckBox_CheckedChanged);
            // 
            // getallColorsBindingSource
            // 
            this.getallColorsBindingSource.DataMember = "Get_all_Colors";
            this.getallColorsBindingSource.DataSource = this.sAD_16DataSet2;
            // 
            // get_all_ColorsTableAdapter
            // 
            this.get_all_ColorsTableAdapter.ClearBeforeFill = true;
            // 
            // getORDERSBindingSource
            // 
            this.getORDERSBindingSource.DataMember = "Get_ORDERS";
            this.getORDERSBindingSource.DataSource = this.sAD_16DataSet2;
            // 
            // get_ORDERSTableAdapter
            // 
            this.get_ORDERSTableAdapter.ClearBeforeFill = true;
            // 
            // getORDERSBindingSource1
            // 
            this.getORDERSBindingSource1.DataMember = "Get_ORDERS";
            this.getORDERSBindingSource1.DataSource = this.sAD_16DataSet2;
            // 
            // searchQueue
            // 
            this.searchQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQueue.Location = new System.Drawing.Point(30, 122);
            this.searchQueue.MultiSelect = false;
            this.searchQueue.Name = "searchQueue";
            this.searchQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchQueue.Size = new System.Drawing.Size(444, 300);
            this.searchQueue.TabIndex = 16;
            this.searchQueue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchQueue_CellContentClick);
            // 
            // backToLiveQueue
            // 
            this.backToLiveQueue.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLiveQueue.Location = new System.Drawing.Point(611, 486);
            this.backToLiveQueue.Name = "backToLiveQueue";
            this.backToLiveQueue.Size = new System.Drawing.Size(85, 30);
            this.backToLiveQueue.TabIndex = 17;
            this.backToLiveQueue.Text = "נקה";
            this.backToLiveQueue.UseVisualStyleBackColor = true;
            this.backToLiveQueue.Click += new System.EventHandler(this.backToLiveQueue_Click);
            // 
            // sAD_16DataSet5
            // 
            this.sAD_16DataSet5.DataSetName = "SAD_16DataSet5";
            this.sAD_16DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getliveORDERSBindingSource
            // 
            this.getliveORDERSBindingSource.DataMember = "Get_live_ORDERS";
            this.getliveORDERSBindingSource.DataSource = this.sAD_16DataSet5;
            // 
            // get_live_ORDERSTableAdapter
            // 
            this.get_live_ORDERSTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "לחץ על רשומה להצגת פרטי ההזמנה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(498, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "שים לב! מסומנות הזמנות שתאריך היעד שלהן הוא ליום העבודה הנוכחי או עבר";
            // 
            // ordersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backToLiveQueue);
            this.Controls.Add(this.searchQueue);
            this.Controls.Add(this.perDateCheckBox);
            this.Controls.Add(this.orderSearchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchOrderByOrder);
            this.Controls.Add(this.toDateOrder);
            this.Controls.Add(this.fromDateOrder);
            this.Controls.Add(this.searchOrderByCustomer);
            this.Controls.Add(this.exitFromOrdersPage);
            this.Controls.Add(this.disFromOrdersPage);
            this.Controls.Add(this.liveQueue);
            this.DoubleBuffered = true;
            this.Name = "ordersPage";
            this.Text = "ordersPage";
            this.Load += new System.EventHandler(this.ordersPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liveQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relevantOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getallColorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getORDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getORDERSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getliveORDERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView liveQueue;
        private SAD_16DataSet2 sAD_16DataSet2;
        private System.Windows.Forms.BindingSource relevantOrdersBindingSource;
        private SAD_16DataSet2TableAdapters.relevantOrdersTableAdapter relevantOrdersTableAdapter;
        private System.Windows.Forms.Button disFromOrdersPage;
        private System.Windows.Forms.Button exitFromOrdersPage;
        private System.Windows.Forms.TextBox searchOrderByCustomer;
        private System.Windows.Forms.DateTimePicker fromDateOrder;
        private System.Windows.Forms.DateTimePicker toDateOrder;
        private System.Windows.Forms.TextBox searchOrderByOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button orderSearchButton;
        private System.Windows.Forms.CheckBox perDateCheckBox;
        private System.Windows.Forms.BindingSource getallColorsBindingSource;
        private SAD_16DataSet2TableAdapters.Get_all_ColorsTableAdapter get_all_ColorsTableAdapter;
        private System.Windows.Forms.BindingSource getORDERSBindingSource;
        private SAD_16DataSet2TableAdapters.Get_ORDERSTableAdapter get_ORDERSTableAdapter;
        private System.Windows.Forms.BindingSource getORDERSBindingSource1;
        private System.Windows.Forms.DataGridView searchQueue;
        private System.Windows.Forms.Button backToLiveQueue;
        private SAD_16DataSet5 sAD_16DataSet5;
        private System.Windows.Forms.BindingSource getliveORDERSBindingSource;
        private SAD_16DataSet5TableAdapters.Get_live_ORDERSTableAdapter get_live_ORDERSTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}