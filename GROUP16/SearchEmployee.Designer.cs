namespace GROUP16
{
    partial class SearchEmployee
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
            this.sAD16DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchEmployeeButton = new System.Windows.Forms.Button();
            this.searchEmployeeByNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitSearchEmployee = new System.Windows.Forms.Button();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD16DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.empRole = new System.Windows.Forms.Label();
            this.empGender = new System.Windows.Forms.Label();
            this.empEmail = new System.Windows.Forms.Label();
            this.empPhone = new System.Windows.Forms.Label();
            this.empPass = new System.Windows.Forms.Label();
            this.upEmpName = new System.Windows.Forms.Label();
            this.upEmpRoleText = new System.Windows.Forms.ComboBox();
            this.upEmpGenderText = new System.Windows.Forms.ComboBox();
            this.upEmpPhoneText = new System.Windows.Forms.TextBox();
            this.upEmpPassText = new System.Windows.Forms.TextBox();
            this.upEmpEmailText = new System.Windows.Forms.TextBox();
            this.upEmpBirthdayText = new System.Windows.Forms.TextBox();
            this.upEmpAddressText = new System.Windows.Forms.TextBox();
            this.upEmpNameText = new System.Windows.Forms.TextBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.sAD_16DataSet1 = new GROUP16.SAD_16DataSet1();
            this.sAD16DataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new GROUP16.SAD_16DataSet1TableAdapters.EMPLOYEESTableAdapter();
            this.disFromSearchEmp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sAD16DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD16DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD16DataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchEmployeeButton
            // 
            this.searchEmployeeButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeButton.Location = new System.Drawing.Point(277, 130);
            this.searchEmployeeButton.Name = "searchEmployeeButton";
            this.searchEmployeeButton.Size = new System.Drawing.Size(98, 29);
            this.searchEmployeeButton.TabIndex = 1;
            this.searchEmployeeButton.Text = "חפש";
            this.searchEmployeeButton.UseVisualStyleBackColor = true;
            this.searchEmployeeButton.Click += new System.EventHandler(this.searchEmployeeButton_Click);
            // 
            // searchEmployeeByNum
            // 
            this.searchEmployeeByNum.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEmployeeByNum.Location = new System.Drawing.Point(402, 130);
            this.searchEmployeeByNum.Name = "searchEmployeeByNum";
            this.searchEmployeeByNum.Size = new System.Drawing.Size(127, 29);
            this.searchEmployeeByNum.TabIndex = 3;
            this.searchEmployeeByNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "חיפוש עובד";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitSearchEmployee
            // 
            this.exitSearchEmployee.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitSearchEmployee.Location = new System.Drawing.Point(386, 497);
            this.exitSearchEmployee.Name = "exitSearchEmployee";
            this.exitSearchEmployee.Size = new System.Drawing.Size(75, 31);
            this.exitSearchEmployee.TabIndex = 5;
            this.exitSearchEmployee.Text = "חזור";
            this.exitSearchEmployee.UseVisualStyleBackColor = true;
            this.exitSearchEmployee.Click += new System.EventHandler(this.exitSearchEmployee_Click);
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataSource = this.sAD16DataSet1BindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(535, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "מספר העובד";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(386, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "עדכן";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(319, 331);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(58, 21);
            this.address.TabIndex = 58;
            this.address.Text = "כתובת";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.BackColor = System.Drawing.Color.Transparent;
            this.birthday.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Location = new System.Drawing.Point(282, 291);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(95, 21);
            this.birthday.TabIndex = 57;
            this.birthday.Text = "תאריך לידה";
            // 
            // empRole
            // 
            this.empRole.AutoSize = true;
            this.empRole.BackColor = System.Drawing.Color.Transparent;
            this.empRole.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empRole.Location = new System.Drawing.Point(319, 248);
            this.empRole.Name = "empRole";
            this.empRole.Size = new System.Drawing.Size(58, 21);
            this.empRole.TabIndex = 56;
            this.empRole.Text = "תפקיד";
            // 
            // empGender
            // 
            this.empGender.AutoSize = true;
            this.empGender.BackColor = System.Drawing.Color.Transparent;
            this.empGender.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empGender.Location = new System.Drawing.Point(345, 201);
            this.empGender.Name = "empGender";
            this.empGender.Size = new System.Drawing.Size(31, 21);
            this.empGender.TabIndex = 55;
            this.empGender.Text = "מין";
            // 
            // empEmail
            // 
            this.empEmail.AutoSize = true;
            this.empEmail.BackColor = System.Drawing.Color.Transparent;
            this.empEmail.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEmail.Location = new System.Drawing.Point(580, 323);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(57, 21);
            this.empEmail.TabIndex = 54;
            this.empEmail.Text = "אימייל";
            // 
            // empPhone
            // 
            this.empPhone.AutoSize = true;
            this.empPhone.BackColor = System.Drawing.Color.Transparent;
            this.empPhone.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPhone.Location = new System.Drawing.Point(584, 280);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(51, 21);
            this.empPhone.TabIndex = 53;
            this.empPhone.Text = "טלפון";
            // 
            // empPass
            // 
            this.empPass.AutoSize = true;
            this.empPass.BackColor = System.Drawing.Color.Transparent;
            this.empPass.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPass.Location = new System.Drawing.Point(575, 237);
            this.empPass.Name = "empPass";
            this.empPass.Size = new System.Drawing.Size(61, 21);
            this.empPass.TabIndex = 52;
            this.empPass.Text = "סיסמה";
            // 
            // upEmpName
            // 
            this.upEmpName.AutoSize = true;
            this.upEmpName.BackColor = System.Drawing.Color.Transparent;
            this.upEmpName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upEmpName.Location = new System.Drawing.Point(552, 198);
            this.upEmpName.Name = "upEmpName";
            this.upEmpName.Size = new System.Drawing.Size(83, 21);
            this.upEmpName.TabIndex = 51;
            this.upEmpName.Text = "שם העובד";
            // 
            // upEmpRoleText
            // 
            this.upEmpRoleText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upEmpRoleText.FormattingEnabled = true;
            this.upEmpRoleText.Location = new System.Drawing.Point(146, 248);
            this.upEmpRoleText.Name = "upEmpRoleText";
            this.upEmpRoleText.Size = new System.Drawing.Size(127, 29);
            this.upEmpRoleText.TabIndex = 50;
            // 
            // upEmpGenderText
            // 
            this.upEmpGenderText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upEmpGenderText.FormattingEnabled = true;
            this.upEmpGenderText.Location = new System.Drawing.Point(145, 198);
            this.upEmpGenderText.Name = "upEmpGenderText";
            this.upEmpGenderText.Size = new System.Drawing.Size(127, 29);
            this.upEmpGenderText.TabIndex = 49;
            // 
            // upEmpPhoneText
            // 
            this.upEmpPhoneText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upEmpPhoneText.Location = new System.Drawing.Point(411, 280);
            this.upEmpPhoneText.Name = "upEmpPhoneText";
            this.upEmpPhoneText.Size = new System.Drawing.Size(127, 29);
            this.upEmpPhoneText.TabIndex = 48;
            // 
            // upEmpPassText
            // 
            this.upEmpPassText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upEmpPassText.Location = new System.Drawing.Point(411, 240);
            this.upEmpPassText.Name = "upEmpPassText";
            this.upEmpPassText.Size = new System.Drawing.Size(127, 29);
            this.upEmpPassText.TabIndex = 47;
            // 
            // upEmpEmailText
            // 
            this.upEmpEmailText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upEmpEmailText.Location = new System.Drawing.Point(411, 320);
            this.upEmpEmailText.Name = "upEmpEmailText";
            this.upEmpEmailText.Size = new System.Drawing.Size(127, 29);
            this.upEmpEmailText.TabIndex = 46;
            this.upEmpEmailText.TextChanged += new System.EventHandler(this.upEmpEmailText_TextChanged);
            // 
            // upEmpBirthdayText
            // 
            this.upEmpBirthdayText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upEmpBirthdayText.Location = new System.Drawing.Point(146, 291);
            this.upEmpBirthdayText.Name = "upEmpBirthdayText";
            this.upEmpBirthdayText.Size = new System.Drawing.Size(127, 29);
            this.upEmpBirthdayText.TabIndex = 45;
            this.upEmpBirthdayText.TextChanged += new System.EventHandler(this.upEmpBirthdayText_TextChanged);
            // 
            // upEmpAddressText
            // 
            this.upEmpAddressText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upEmpAddressText.Location = new System.Drawing.Point(146, 331);
            this.upEmpAddressText.Name = "upEmpAddressText";
            this.upEmpAddressText.Size = new System.Drawing.Size(127, 29);
            this.upEmpAddressText.TabIndex = 44;
            // 
            // upEmpNameText
            // 
            this.upEmpNameText.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upEmpNameText.Location = new System.Drawing.Point(411, 198);
            this.upEmpNameText.Name = "upEmpNameText";
            this.upEmpNameText.Size = new System.Drawing.Size(127, 29);
            this.upEmpNameText.TabIndex = 43;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxActive.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(312, 377);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(64, 25);
            this.checkBoxActive.TabIndex = 59;
            this.checkBoxActive.Text = "פעיל";
            this.checkBoxActive.UseVisualStyleBackColor = false;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.checkBoxActive_CheckedChanged);
            // 
            // sAD_16DataSet1
            // 
            this.sAD_16DataSet1.DataSetName = "SAD_16DataSet1";
            this.sAD_16DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sAD16DataSet1BindingSource1
            // 
            this.sAD16DataSet1BindingSource1.DataSource = this.sAD_16DataSet1;
            this.sAD16DataSet1BindingSource1.Position = 0;
            // 
            // eMPLOYEESBindingSource1
            // 
            this.eMPLOYEESBindingSource1.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource1.DataSource = this.sAD_16DataSet1;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // disFromSearchEmp
            // 
            this.disFromSearchEmp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disFromSearchEmp.Location = new System.Drawing.Point(-1, 1);
            this.disFromSearchEmp.Name = "disFromSearchEmp";
            this.disFromSearchEmp.Size = new System.Drawing.Size(75, 30);
            this.disFromSearchEmp.TabIndex = 60;
            this.disFromSearchEmp.Text = "התנתק";
            this.disFromSearchEmp.UseVisualStyleBackColor = true;
            this.disFromSearchEmp.Click += new System.EventHandler(this.disFromSearchEmp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "(YYYY-MM-DD)";
            // 
            // SearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GROUP16.Properties.Resources.רקע_מעודכן_מסכים_אחרים_removebg_preview__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.disFromSearchEmp);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.address);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.empRole);
            this.Controls.Add(this.empGender);
            this.Controls.Add(this.empEmail);
            this.Controls.Add(this.empPhone);
            this.Controls.Add(this.empPass);
            this.Controls.Add(this.upEmpName);
            this.Controls.Add(this.upEmpRoleText);
            this.Controls.Add(this.upEmpGenderText);
            this.Controls.Add(this.upEmpPhoneText);
            this.Controls.Add(this.upEmpPassText);
            this.Controls.Add(this.upEmpEmailText);
            this.Controls.Add(this.upEmpBirthdayText);
            this.Controls.Add(this.upEmpAddressText);
            this.Controls.Add(this.upEmpNameText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitSearchEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchEmployeeByNum);
            this.Controls.Add(this.searchEmployeeButton);
            this.DoubleBuffered = true;
            this.Name = "SearchEmployee";
            this.Text = "SearchEmployee";
            this.Load += new System.EventHandler(this.SearchEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sAD16DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD16DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD16DataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sAD16DataSetBindingSource;
        private SAD_16DataSet sAD_16DataSet;
        private System.Windows.Forms.Button searchEmployeeButton;
        private System.Windows.Forms.TextBox searchEmployeeByNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitSearchEmployee;
        private System.Windows.Forms.BindingSource sAD16DataSet1BindingSource;
        // private SAD_16DataSet1 sAD_16DataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        //private SAD_16DataSet1TableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label empRole;
        private System.Windows.Forms.Label empGender;
        private System.Windows.Forms.Label empEmail;
        private System.Windows.Forms.Label empPhone;
        private System.Windows.Forms.Label empPass;
        private System.Windows.Forms.Label upEmpName;
        private System.Windows.Forms.ComboBox upEmpRoleText;
        private System.Windows.Forms.ComboBox upEmpGenderText;
        private System.Windows.Forms.TextBox upEmpPhoneText;
        private System.Windows.Forms.TextBox upEmpPassText;
        private System.Windows.Forms.TextBox upEmpEmailText;
        private System.Windows.Forms.TextBox upEmpBirthdayText;
        private System.Windows.Forms.TextBox upEmpAddressText;
        private System.Windows.Forms.TextBox upEmpNameText;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.BindingSource sAD16DataSet1BindingSource1;
        private SAD_16DataSet1 sAD_16DataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource1;
        private SAD_16DataSet1TableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.Button disFromSearchEmp;
        private System.Windows.Forms.Label label3;
    }
}

    

    