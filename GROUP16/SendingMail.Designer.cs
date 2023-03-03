namespace GROUP16
{
    partial class SendingEmail
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
            this.forAddress = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.Label();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.Main = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendMail = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.backFromMail = new System.Windows.Forms.Button();
            this.AddFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "שליחת מייל חדש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = ":אל";
            // 
            // forAddress
            // 
            this.forAddress.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forAddress.Location = new System.Drawing.Point(278, 172);
            this.forAddress.Name = "forAddress";
            this.forAddress.Size = new System.Drawing.Size(304, 29);
            this.forAddress.TabIndex = 2;
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.BackColor = System.Drawing.Color.Transparent;
            this.subject.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.Location = new System.Drawing.Point(588, 253);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(51, 21);
            this.subject.TabIndex = 3;
            this.subject.Text = ":נושא";
            // 
            // textSubject
            // 
            this.textSubject.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSubject.Location = new System.Drawing.Point(278, 250);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(304, 29);
            this.textSubject.TabIndex = 4;
            // 
            // Main
            // 
            this.Main.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.Location = new System.Drawing.Point(278, 331);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(304, 29);
            this.Main.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(594, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = ":תוכן";
            // 
            // SendMail
            // 
            this.SendMail.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMail.Location = new System.Drawing.Point(377, 414);
            this.SendMail.Name = "SendMail";
            this.SendMail.Size = new System.Drawing.Size(93, 34);
            this.SendMail.TabIndex = 7;
            this.SendMail.Text = "שלח";
            this.SendMail.UseVisualStyleBackColor = true;
            this.SendMail.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(-2, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 35);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "התנתק";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // backFromMail
            // 
            this.backFromMail.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backFromMail.Location = new System.Drawing.Point(377, 454);
            this.backFromMail.Name = "backFromMail";
            this.backFromMail.Size = new System.Drawing.Size(93, 34);
            this.backFromMail.TabIndex = 9;
            this.backFromMail.Text = "חזור";
            this.backFromMail.UseVisualStyleBackColor = true;
            this.backFromMail.Click += new System.EventHandler(this.backFromMail_Click);
            // 
            // AddFile
            // 
            this.AddFile.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFile.Location = new System.Drawing.Point(167, 328);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(91, 32);
            this.AddFile.TabIndex = 10;
            this.AddFile.Text = "צרף קובץ";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // SendingEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.AddFile);
            this.Controls.Add(this.backFromMail);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.forAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "SendingEmail";
            this.Text = "SendingMail";
            this.Load += new System.EventHandler(this.SendingEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox forAddress;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.TextBox Main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendMail;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button backFromMail;
        private System.Windows.Forms.Button AddFile;
    }
}