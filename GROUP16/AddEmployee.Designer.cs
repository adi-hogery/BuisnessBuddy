namespace GROUP16
{
    partial class AddEmployee
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
            this.employeeName = new System.Windows.Forms.TextBox();
            this.employeeAddress = new System.Windows.Forms.TextBox();
            this.employeeBirthday = new System.Windows.Forms.TextBox();
            this.employeeEmail = new System.Windows.Forms.TextBox();
            this.employeePass = new System.Windows.Forms.TextBox();
            this.employeePhone = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.empName = new System.Windows.Forms.Label();
            this.empPass = new System.Windows.Forms.Label();
            this.empPhone = new System.Windows.Forms.Label();
            this.empEmail = new System.Windows.Forms.Label();
            this.empGender = new System.Windows.Forms.Label();
            this.empRole = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitFromAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newEmpNum = new System.Windows.Forms.TextBox();
            this.disFromAddEmp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeName
            // 
            this.employeeName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.Location = new System.Drawing.Point(396, 231);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(127, 29);
            this.employeeName.TabIndex = 6;
            this.employeeName.TextChanged += new System.EventHandler(this.employeeName_TextChanged);
            // 
            // employeeAddress
            // 
            this.employeeAddress.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeAddress.Location = new System.Drawing.Point(135, 278);
            this.employeeAddress.Name = "employeeAddress";
            this.employeeAddress.Size = new System.Drawing.Size(127, 29);
            this.employeeAddress.TabIndex = 7;
            // 
            // employeeBirthday
            // 
            this.employeeBirthday.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeBirthday.Location = new System.Drawing.Point(135, 326);
            this.employeeBirthday.Name = "employeeBirthday";
            this.employeeBirthday.Size = new System.Drawing.Size(127, 29);
            this.employeeBirthday.TabIndex = 8;
            // 
            // employeeEmail
            // 
            this.employeeEmail.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeEmail.Location = new System.Drawing.Point(396, 353);
            this.employeeEmail.Name = "employeeEmail";
            this.employeeEmail.Size = new System.Drawing.Size(127, 29);
            this.employeeEmail.TabIndex = 9;
            // 
            // employeePass
            // 
            this.employeePass.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePass.Location = new System.Drawing.Point(396, 273);
            this.employeePass.Name = "employeePass";
            this.employeePass.Size = new System.Drawing.Size(127, 29);
            this.employeePass.TabIndex = 10;
            this.employeePass.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // employeePhone
            // 
            this.employeePhone.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePhone.Location = new System.Drawing.Point(396, 313);
            this.employeePhone.Name = "employeePhone";
            this.employeePhone.Size = new System.Drawing.Size(127, 29);
            this.employeePhone.TabIndex = 11;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(135, 192);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(127, 29);
            this.comboBoxGender.TabIndex = 12;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(135, 233);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(127, 29);
            this.comboBoxRole.TabIndex = 13;
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.BackColor = System.Drawing.Color.Transparent;
            this.empName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.Location = new System.Drawing.Point(559, 230);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(83, 21);
            this.empName.TabIndex = 16;
            this.empName.Text = "שם העובד";
            this.empName.Click += new System.EventHandler(this.label1_Click);
            // 
            // empPass
            // 
            this.empPass.AutoSize = true;
            this.empPass.BackColor = System.Drawing.Color.Transparent;
            this.empPass.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPass.Location = new System.Drawing.Point(582, 273);
            this.empPass.Name = "empPass";
            this.empPass.Size = new System.Drawing.Size(61, 21);
            this.empPass.TabIndex = 17;
            this.empPass.Text = "סיסמה";
            this.empPass.Click += new System.EventHandler(this.empPass_Click);
            // 
            // empPhone
            // 
            this.empPhone.AutoSize = true;
            this.empPhone.BackColor = System.Drawing.Color.Transparent;
            this.empPhone.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPhone.Location = new System.Drawing.Point(591, 313);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(51, 21);
            this.empPhone.TabIndex = 18;
            this.empPhone.Text = "טלפון";
            // 
            // empEmail
            // 
            this.empEmail.AutoSize = true;
            this.empEmail.BackColor = System.Drawing.Color.Transparent;
            this.empEmail.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEmail.Location = new System.Drawing.Point(587, 353);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(57, 21);
            this.empEmail.TabIndex = 19;
            this.empEmail.Text = "אימייל";
            // 
            // empGender
            // 
            this.empGender.AutoSize = true;
            this.empGender.BackColor = System.Drawing.Color.Transparent;
            this.empGender.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empGender.Location = new System.Drawing.Point(338, 192);
            this.empGender.Name = "empGender";
            this.empGender.Size = new System.Drawing.Size(31, 21);
            this.empGender.TabIndex = 20;
            this.empGender.Text = "מין";
            // 
            // empRole
            // 
            this.empRole.AutoSize = true;
            this.empRole.BackColor = System.Drawing.Color.Transparent;
            this.empRole.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRole.Location = new System.Drawing.Point(312, 233);
            this.empRole.Name = "empRole";
            this.empRole.Size = new System.Drawing.Size(58, 21);
            this.empRole.TabIndex = 21;
            this.empRole.Text = "תפקיד";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.BackColor = System.Drawing.Color.Transparent;
            this.birthday.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Location = new System.Drawing.Point(275, 326);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(95, 21);
            this.birthday.TabIndex = 22;
            this.birthday.Text = "תאריך לידה";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(311, 281);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(58, 21);
            this.address.TabIndex = 23;
            this.address.Text = "כתובת";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(406, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "הוסף עובד";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 45);
            this.label1.TabIndex = 27;
            this.label1.Text = "הוספת עובד";
            // 
            // exitFromAdd
            // 
            this.exitFromAdd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitFromAdd.Location = new System.Drawing.Point(406, 500);
            this.exitFromAdd.Name = "exitFromAdd";
            this.exitFromAdd.Size = new System.Drawing.Size(75, 35);
            this.exitFromAdd.TabIndex = 28;
            this.exitFromAdd.Text = "חזור";
            this.exitFromAdd.UseVisualStyleBackColor = true;
            this.exitFromAdd.Click += new System.EventHandler(this.exitFromAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "מספר העובד";
            // 
            // newEmpNum
            // 
            this.newEmpNum.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmpNum.Location = new System.Drawing.Point(396, 192);
            this.newEmpNum.Name = "newEmpNum";
            this.newEmpNum.ReadOnly = true;
            this.newEmpNum.Size = new System.Drawing.Size(127, 29);
            this.newEmpNum.TabIndex = 30;
            this.newEmpNum.TextChanged += new System.EventHandler(this.newEmpNum_TextChanged);
            // 
            // disFromAddEmp
            // 
            this.disFromAddEmp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disFromAddEmp.Location = new System.Drawing.Point(3, 2);
            this.disFromAddEmp.Name = "disFromAddEmp";
            this.disFromAddEmp.Size = new System.Drawing.Size(76, 33);
            this.disFromAddEmp.TabIndex = 31;
            this.disFromAddEmp.Text = "התנתק";
            this.disFromAddEmp.UseVisualStyleBackColor = true;
            this.disFromAddEmp.Click += new System.EventHandler(this.disFromAddEmp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "(YYYY-MM-DD)";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.disFromAddEmp);
            this.Controls.Add(this.newEmpNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitFromAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.empRole);
            this.Controls.Add(this.empGender);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.empPhone);
            this.Controls.Add(this.empPass);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.employeePhone);
            this.Controls.Add(this.employeePass);
            this.Controls.Add(this.employeeEmail);
            this.Controls.Add(this.employeeBirthday);
            this.Controls.Add(this.employeeAddress);
            this.Controls.Add(this.employeeName);
            this.DoubleBuffered = true;
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.TextBox employeeAddress;
        private System.Windows.Forms.TextBox employeeBirthday;
        private System.Windows.Forms.TextBox employeeEmail;
        private System.Windows.Forms.TextBox employeePass;
        private System.Windows.Forms.TextBox employeePhone;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.Label empPass;
        private System.Windows.Forms.Label empPhone;
        private System.Windows.Forms.Label empEmail;
        private System.Windows.Forms.Label empGender;
        private System.Windows.Forms.Label empRole;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitFromAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newEmpNum;
        private System.Windows.Forms.Button disFromAddEmp;
        private System.Windows.Forms.Label label3;
    }
}