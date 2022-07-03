namespace Avokado
{
    partial class userData
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
            this.fioTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telephoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressL = new System.Windows.Forms.Label();
            this.changeAddressBTN = new System.Windows.Forms.Button();
            this.changeAuthDataBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.useDeliveryCB = new System.Windows.Forms.CheckBox();
            this.endingEmailCB = new System.Windows.Forms.ComboBox();
            this.orderHistoryDGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Профиль";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 2);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // fioTB
            // 
            this.fioTB.Location = new System.Drawing.Point(17, 83);
            this.fioTB.Name = "fioTB";
            this.fioTB.Size = new System.Drawing.Size(314, 20);
            this.fioTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО";
            // 
            // telephoneMTB
            // 
            this.telephoneMTB.Location = new System.Drawing.Point(17, 122);
            this.telephoneMTB.Mask = "+7(000)000-00-00";
            this.telephoneMTB.Name = "telephoneMTB";
            this.telephoneMTB.Size = new System.Drawing.Size(100, 20);
            this.telephoneMTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Телефон";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(123, 122);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(128, 20);
            this.emailTB.TabIndex = 6;
            this.emailTB.TextChanged += new System.EventHandler(this.emailTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Электронная почта";
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(17, 161);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(121, 21);
            this.genderCB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пол";
            // 
            // addressL
            // 
            this.addressL.AutoSize = true;
            this.addressL.Location = new System.Drawing.Point(14, 195);
            this.addressL.Name = "addressL";
            this.addressL.Size = new System.Drawing.Size(24, 13);
            this.addressL.TabIndex = 10;
            this.addressL.Text = "</>";
            // 
            // changeAddressBTN
            // 
            this.changeAddressBTN.Location = new System.Drawing.Point(219, 211);
            this.changeAddressBTN.Name = "changeAddressBTN";
            this.changeAddressBTN.Size = new System.Drawing.Size(112, 21);
            this.changeAddressBTN.TabIndex = 11;
            this.changeAddressBTN.Text = "Изменить адрес";
            this.changeAddressBTN.UseVisualStyleBackColor = true;
            this.changeAddressBTN.Click += new System.EventHandler(this.changeAddressBTN_Click);
            // 
            // changeAuthDataBTN
            // 
            this.changeAuthDataBTN.Location = new System.Drawing.Point(428, 16);
            this.changeAuthDataBTN.Name = "changeAuthDataBTN";
            this.changeAuthDataBTN.Size = new System.Drawing.Size(178, 23);
            this.changeAuthDataBTN.TabIndex = 12;
            this.changeAuthDataBTN.Text = "Изменить данные авторизации";
            this.changeAuthDataBTN.UseVisualStyleBackColor = true;
            this.changeAuthDataBTN.Click += new System.EventHandler(this.changeAuthDataBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(195, 301);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(136, 23);
            this.saveBTN.TabIndex = 13;
            this.saveBTN.Text = "Сохранить изменения";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(17, 301);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 14;
            this.cancelBTN.Text = "Отмена";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // useDeliveryCB
            // 
            this.useDeliveryCB.AutoSize = true;
            this.useDeliveryCB.Location = new System.Drawing.Point(17, 211);
            this.useDeliveryCB.Name = "useDeliveryCB";
            this.useDeliveryCB.Size = new System.Drawing.Size(147, 17);
            this.useDeliveryCB.TabIndex = 15;
            this.useDeliveryCB.Text = "Используете доставку?";
            this.useDeliveryCB.UseVisualStyleBackColor = true;
            this.useDeliveryCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.endingEmailCB.Location = new System.Drawing.Point(257, 121);
            this.endingEmailCB.Name = "endingEmailCB";
            this.endingEmailCB.Size = new System.Drawing.Size(74, 21);
            this.endingEmailCB.TabIndex = 16;
            // 
            // orderHistoryDGV
            // 
            this.orderHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderHistoryDGV.Location = new System.Drawing.Point(337, 83);
            this.orderHistoryDGV.Name = "orderHistoryDGV";
            this.orderHistoryDGV.Size = new System.Drawing.Size(269, 241);
            this.orderHistoryDGV.TabIndex = 17;
            this.orderHistoryDGV.DoubleClick += new System.EventHandler(this.orderHistoryDGV_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "История заказов";
            // 
            // userData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 336);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.orderHistoryDGV);
            this.Controls.Add(this.endingEmailCB);
            this.Controls.Add(this.useDeliveryCB);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.changeAuthDataBTN);
            this.Controls.Add(this.changeAddressBTN);
            this.Controls.Add(this.addressL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telephoneMTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fioTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(634, 375);
            this.MinimumSize = new System.Drawing.Size(634, 375);
            this.Name = "userData";
            this.Text = "userData";
            this.Load += new System.EventHandler(this.userData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fioTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox telephoneMTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label addressL;
        private System.Windows.Forms.Button changeAddressBTN;
        private System.Windows.Forms.Button changeAuthDataBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.CheckBox useDeliveryCB;
        private System.Windows.Forms.ComboBox endingEmailCB;
        private System.Windows.Forms.DataGridView orderHistoryDGV;
        private System.Windows.Forms.Label label7;
    }
}