namespace Avokado
{
    partial class registrationForm
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
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.midnameTB = new System.Windows.Forms.TextBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.telephoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.endingEmailCB = new System.Windows.Forms.ComboBox();
            this.regBTN = new System.Windows.Forms.Button();
            this.checkDeliveryCB = new System.Windows.Forms.CheckBox();
            this.addressInfoP = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.houseTB = new System.Windows.Forms.TextBox();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.localityTB = new System.Windows.Forms.TextBox();
            this.districtTB = new System.Windows.Forms.TextBox();
            this.regionTB = new System.Windows.Forms.TextBox();
            this.indexMTB = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.showPasswordL = new System.Windows.Forms.Label();
            this.addressInfoP.SuspendLayout();
            this.SuspendLayout();
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(81, 69);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(180, 20);
            this.surnameTB.TabIndex = 0;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(81, 95);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(180, 20);
            this.nameTB.TabIndex = 1;
            // 
            // midnameTB
            // 
            this.midnameTB.Location = new System.Drawing.Point(81, 121);
            this.midnameTB.Name = "midnameTB";
            this.midnameTB.Size = new System.Drawing.Size(180, 20);
            this.midnameTB.TabIndex = 2;
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(81, 147);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(90, 21);
            this.genderCB.TabIndex = 3;
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(339, 121);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(180, 20);
            this.loginTB.TabIndex = 4;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(339, 148);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(180, 20);
            this.passwordTB.TabIndex = 5;
            // 
            // telephoneMTB
            // 
            this.telephoneMTB.Location = new System.Drawing.Point(339, 69);
            this.telephoneMTB.Mask = "+7(000)000-00-00";
            this.telephoneMTB.Name = "telephoneMTB";
            this.telephoneMTB.Size = new System.Drawing.Size(180, 20);
            this.telephoneMTB.TabIndex = 6;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(339, 95);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 7;
            this.emailTB.TextChanged += new System.EventHandler(this.emailTB_TextChanged);
            // 
            // endingEmailCB
            // 
            this.endingEmailCB.FormattingEnabled = true;
            this.endingEmailCB.Items.AddRange(new object[] {
            "@mail.ru",
            "@bk.ru",
            "@list.ru",
            "@inbox.ru",
            "@gmail.com",
            "@yandex.ru"});
            this.endingEmailCB.Location = new System.Drawing.Point(445, 95);
            this.endingEmailCB.Name = "endingEmailCB";
            this.endingEmailCB.Size = new System.Drawing.Size(74, 21);
            this.endingEmailCB.TabIndex = 8;
            // 
            // regBTN
            // 
            this.regBTN.Location = new System.Drawing.Point(397, 294);
            this.regBTN.Name = "regBTN";
            this.regBTN.Size = new System.Drawing.Size(122, 23);
            this.regBTN.TabIndex = 9;
            this.regBTN.Text = "Зарегистрироваться";
            this.regBTN.UseVisualStyleBackColor = true;
            this.regBTN.Click += new System.EventHandler(this.regBTN_Click);
            // 
            // checkDeliveryCB
            // 
            this.checkDeliveryCB.AutoSize = true;
            this.checkDeliveryCB.Location = new System.Drawing.Point(17, 185);
            this.checkDeliveryCB.Name = "checkDeliveryCB";
            this.checkDeliveryCB.Size = new System.Drawing.Size(190, 17);
            this.checkDeliveryCB.TabIndex = 10;
            this.checkDeliveryCB.Text = "Будете использовать доставку?";
            this.checkDeliveryCB.UseVisualStyleBackColor = true;
            this.checkDeliveryCB.CheckedChanged += new System.EventHandler(this.checkDeliveryCB_CheckedChanged);
            // 
            // addressInfoP
            // 
            this.addressInfoP.Controls.Add(this.label15);
            this.addressInfoP.Controls.Add(this.label14);
            this.addressInfoP.Controls.Add(this.label13);
            this.addressInfoP.Controls.Add(this.label12);
            this.addressInfoP.Controls.Add(this.label11);
            this.addressInfoP.Controls.Add(this.label10);
            this.addressInfoP.Controls.Add(this.houseTB);
            this.addressInfoP.Controls.Add(this.streetTB);
            this.addressInfoP.Controls.Add(this.localityTB);
            this.addressInfoP.Controls.Add(this.districtTB);
            this.addressInfoP.Controls.Add(this.regionTB);
            this.addressInfoP.Controls.Add(this.indexMTB);
            this.addressInfoP.Location = new System.Drawing.Point(17, 208);
            this.addressInfoP.Name = "addressInfoP";
            this.addressInfoP.Size = new System.Drawing.Size(397, 80);
            this.addressInfoP.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(179, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Дом";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(179, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Улица";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(179, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Населенный пункт";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Район";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Область";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Индекс";
            // 
            // houseTB
            // 
            this.houseTB.Location = new System.Drawing.Point(287, 55);
            this.houseTB.Name = "houseTB";
            this.houseTB.Size = new System.Drawing.Size(100, 20);
            this.houseTB.TabIndex = 6;
            // 
            // streetTB
            // 
            this.streetTB.Location = new System.Drawing.Point(287, 29);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(100, 20);
            this.streetTB.TabIndex = 5;
            // 
            // localityTB
            // 
            this.localityTB.Location = new System.Drawing.Point(287, 3);
            this.localityTB.Name = "localityTB";
            this.localityTB.Size = new System.Drawing.Size(100, 20);
            this.localityTB.TabIndex = 4;
            // 
            // districtTB
            // 
            this.districtTB.Location = new System.Drawing.Point(64, 55);
            this.districtTB.Name = "districtTB";
            this.districtTB.Size = new System.Drawing.Size(100, 20);
            this.districtTB.TabIndex = 3;
            // 
            // regionTB
            // 
            this.regionTB.Location = new System.Drawing.Point(64, 29);
            this.regionTB.Name = "regionTB";
            this.regionTB.Size = new System.Drawing.Size(100, 20);
            this.regionTB.TabIndex = 1;
            // 
            // indexMTB
            // 
            this.indexMTB.Location = new System.Drawing.Point(64, 3);
            this.indexMTB.Mask = "000000";
            this.indexMTB.Name = "indexMTB";
            this.indexMTB.Size = new System.Drawing.Size(100, 20);
            this.indexMTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Эл. почта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Логин";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Пароль";
            // 
            // showPasswordL
            // 
            this.showPasswordL.AutoSize = true;
            this.showPasswordL.Location = new System.Drawing.Point(426, 171);
            this.showPasswordL.Name = "showPasswordL";
            this.showPasswordL.Size = new System.Drawing.Size(93, 13);
            this.showPasswordL.TabIndex = 20;
            this.showPasswordL.Text = "показать пароль";
            this.showPasswordL.Click += new System.EventHandler(this.label16_Click);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 325);
            this.Controls.Add(this.showPasswordL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressInfoP);
            this.Controls.Add(this.checkDeliveryCB);
            this.Controls.Add(this.regBTN);
            this.Controls.Add(this.endingEmailCB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.telephoneMTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.midnameTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.surnameTB);
            this.Name = "registrationForm";
            this.Text = "registrationForm";
            this.Load += new System.EventHandler(this.registrationForm_Load);
            this.addressInfoP.ResumeLayout(false);
            this.addressInfoP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox midnameTB;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.MaskedTextBox telephoneMTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.ComboBox endingEmailCB;
        private System.Windows.Forms.Button regBTN;
        private System.Windows.Forms.CheckBox checkDeliveryCB;
        private System.Windows.Forms.Panel addressInfoP;
        private System.Windows.Forms.MaskedTextBox indexMTB;
        private System.Windows.Forms.TextBox houseTB;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.TextBox localityTB;
        private System.Windows.Forms.TextBox districtTB;
        private System.Windows.Forms.TextBox regionTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label showPasswordL;
    }
}