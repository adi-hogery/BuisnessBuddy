namespace GROUP16
{
    partial class ManageEmployee
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
            this.button1 = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.disFromManageEmp = new System.Windows.Forms.Button();
            this.exitFromManEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "ADD EMPLOYEE";
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(482, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 131);
            this.button1.TabIndex = 0;
            this.button1.Text = "הוסף עובד";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.Search.AccessibleName = "SEARCH EMPLOYEE";
            this.Search.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(146, 233);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(237, 134);
            this.Search.TabIndex = 1;
            this.Search.Text = "חפש עובד";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "ניהול עובדים";
            // 
            // disFromManageEmp
            // 
            this.disFromManageEmp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disFromManageEmp.Location = new System.Drawing.Point(0, 0);
            this.disFromManageEmp.Name = "disFromManageEmp";
            this.disFromManageEmp.Size = new System.Drawing.Size(75, 33);
            this.disFromManageEmp.TabIndex = 3;
            this.disFromManageEmp.Text = "התנתק";
            this.disFromManageEmp.UseVisualStyleBackColor = true;
            this.disFromManageEmp.Click += new System.EventHandler(this.disFromManageEmp_Click);
            // 
            // exitFromManEmp
            // 
            this.exitFromManEmp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitFromManEmp.Location = new System.Drawing.Point(407, 465);
            this.exitFromManEmp.Name = "exitFromManEmp";
            this.exitFromManEmp.Size = new System.Drawing.Size(75, 34);
            this.exitFromManEmp.TabIndex = 4;
            this.exitFromManEmp.Text = "חזור";
            this.exitFromManEmp.UseVisualStyleBackColor = true;
            this.exitFromManEmp.Click += new System.EventHandler(this.exitFromManEmp_Click);
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.exitFromManEmp);
            this.Controls.Add(this.disFromManageEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "ManageEmployee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button disFromManageEmp;
        private System.Windows.Forms.Button exitFromManEmp;
    }
}

