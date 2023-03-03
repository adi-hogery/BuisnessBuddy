namespace GROUP16
{
    partial class schedule
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
            this.eventsGrid = new System.Windows.Forms.DataGridView();
            this.disFromSchedule = new System.Windows.Forms.Button();
            this.backFromSchedule = new System.Windows.Forms.Button();
            this.addEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsGrid
            // 
            this.eventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsGrid.Location = new System.Drawing.Point(47, 150);
            this.eventsGrid.Name = "eventsGrid";
            this.eventsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventsGrid.Size = new System.Drawing.Size(646, 245);
            this.eventsGrid.TabIndex = 0;
            this.eventsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventsGrid_CellContentClick);
            // 
            // disFromSchedule
            // 
            this.disFromSchedule.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disFromSchedule.Location = new System.Drawing.Point(0, 1);
            this.disFromSchedule.Name = "disFromSchedule";
            this.disFromSchedule.Size = new System.Drawing.Size(75, 30);
            this.disFromSchedule.TabIndex = 1;
            this.disFromSchedule.Text = "התנתק";
            this.disFromSchedule.UseVisualStyleBackColor = true;
            this.disFromSchedule.Click += new System.EventHandler(this.disFromSchedule_Click);
            // 
            // backFromSchedule
            // 
            this.backFromSchedule.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backFromSchedule.Location = new System.Drawing.Point(357, 519);
            this.backFromSchedule.Name = "backFromSchedule";
            this.backFromSchedule.Size = new System.Drawing.Size(75, 30);
            this.backFromSchedule.TabIndex = 2;
            this.backFromSchedule.Text = "חזור";
            this.backFromSchedule.UseVisualStyleBackColor = true;
            this.backFromSchedule.Click += new System.EventHandler(this.backFromSchedule_Click);
            // 
            // addEvent
            // 
            this.addEvent.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvent.Location = new System.Drawing.Point(335, 435);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(123, 30);
            this.addEvent.TabIndex = 3;
            this.addEvent.Text = "הוסף אירוע";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "לוח הזמנים שלי";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.backFromSchedule);
            this.Controls.Add(this.disFromSchedule);
            this.Controls.Add(this.eventsGrid);
            this.DoubleBuffered = true;
            this.Name = "schedule";
            this.Text = "schedule";
            ((System.ComponentModel.ISupportInitialize)(this.eventsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView eventsGrid;
        private System.Windows.Forms.Button disFromSchedule;
        private System.Windows.Forms.Button backFromSchedule;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.Label label1;
    }
}