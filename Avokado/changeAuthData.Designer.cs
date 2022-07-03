namespace Avokado
{
    partial class changeAuthData
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
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.applyPasswordTB = new System.Windows.Forms.TextBox();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkPasswordTB = new System.Windows.Forms.TextBox();
            this.skipBTN = new System.Windows.Forms.Button();
            this.showPasswordL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(23, 148);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(173, 20);
            this.loginTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(23, 128);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(173, 20);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            // 
            // applyPasswordTB
            // 
            this.applyPasswordTB.Location = new System.Drawing.Point(23, 167);
            this.applyPasswordTB.Name = "applyPasswordTB";
            this.applyPasswordTB.PasswordChar = '●';
            this.applyPasswordTB.Size = new System.Drawing.Size(173, 20);
            this.applyPasswordTB.TabIndex = 2;
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(23, 238);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 3;
            this.cancelBTN.Text = "Отмена";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(121, 238);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 23);
            this.saveBTN.TabIndex = 4;
            this.saveBTN.Text = "Сохранить";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkPasswordTB);
            this.panel1.Controls.Add(this.skipBTN);
            this.panel1.Location = new System.Drawing.Point(267, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 100);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите пароль от учетной записи";
            // 
            // checkPasswordTB
            // 
            this.checkPasswordTB.Location = new System.Drawing.Point(3, 76);
            this.checkPasswordTB.Name = "checkPasswordTB";
            this.checkPasswordTB.PasswordChar = '●';
            this.checkPasswordTB.Size = new System.Drawing.Size(142, 20);
            this.checkPasswordTB.TabIndex = 1;
            // 
            // skipBTN
            // 
            this.skipBTN.Location = new System.Drawing.Point(151, 74);
            this.skipBTN.Name = "skipBTN";
            this.skipBTN.Size = new System.Drawing.Size(88, 23);
            this.skipBTN.TabIndex = 0;
            this.skipBTN.Text = "Продолжить";
            this.skipBTN.UseVisualStyleBackColor = true;
            this.skipBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // showPasswordL
            // 
            this.showPasswordL.AutoSize = true;
            this.showPasswordL.Location = new System.Drawing.Point(103, 190);
            this.showPasswordL.Name = "showPasswordL";
            this.showPasswordL.Size = new System.Drawing.Size(93, 13);
            this.showPasswordL.TabIndex = 6;
            this.showPasswordL.Text = "показать пароль";
            this.showPasswordL.Click += new System.EventHandler(this.showPasswordL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Подтверждение пароля";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(38, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Смена данных";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("Смена пароля");
            this.domainUpDown1.Items.Add("Смена логина");
            this.domainUpDown1.Location = new System.Drawing.Point(42, 66);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(136, 20);
            this.domainUpDown1.TabIndex = 11;
            this.domainUpDown1.Text = "domainUpDown1";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // changeAuthData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 273);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showPasswordL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.applyPasswordTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.MaximumSize = new System.Drawing.Size(233, 312);
            this.MinimumSize = new System.Drawing.Size(233, 312);
            this.Name = "changeAuthData";
            this.Text = "changeAuthData";
            this.Load += new System.EventHandler(this.changeAuthData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox applyPasswordTB;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox checkPasswordTB;
        private System.Windows.Forms.Button skipBTN;
        private System.Windows.Forms.Label showPasswordL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}