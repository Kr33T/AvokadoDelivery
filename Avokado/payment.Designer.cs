namespace Avokado
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telephoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numberMTB = new System.Windows.Forms.MaskedTextBox();
            this.cvvMTB = new System.Windows.Forms.MaskedTextBox();
            this.monthNUD = new System.Windows.Forms.NumericUpDown();
            this.yearNUD = new System.Windows.Forms.NumericUpDown();
            this.promoTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.stoimL = new System.Windows.Forms.Label();
            this.priceL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1200, 2);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Оформление заказа";
            // 
            // telephoneMTB
            // 
            this.telephoneMTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephoneMTB.Location = new System.Drawing.Point(17, 93);
            this.telephoneMTB.Mask = "+7(000)000-00-00";
            this.telephoneMTB.Name = "telephoneMTB";
            this.telephoneMTB.Size = new System.Drawing.Size(138, 26);
            this.telephoneMTB.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Оплатить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // numberMTB
            // 
            this.numberMTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberMTB.Location = new System.Drawing.Point(327, 194);
            this.numberMTB.Mask = "0000 0000 0000 0000";
            this.numberMTB.Name = "numberMTB";
            this.numberMTB.Size = new System.Drawing.Size(397, 44);
            this.numberMTB.TabIndex = 22;
            // 
            // cvvMTB
            // 
            this.cvvMTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cvvMTB.Location = new System.Drawing.Point(775, 228);
            this.cvvMTB.Mask = "000";
            this.cvvMTB.Name = "cvvMTB";
            this.cvvMTB.Size = new System.Drawing.Size(100, 44);
            this.cvvMTB.TabIndex = 25;
            // 
            // monthNUD
            // 
            this.monthNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthNUD.Location = new System.Drawing.Point(327, 283);
            this.monthNUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNUD.Name = "monthNUD";
            this.monthNUD.Size = new System.Drawing.Size(80, 44);
            this.monthNUD.TabIndex = 26;
            this.monthNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yearNUD
            // 
            this.yearNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearNUD.Location = new System.Drawing.Point(423, 283);
            this.yearNUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.yearNUD.Name = "yearNUD";
            this.yearNUD.Size = new System.Drawing.Size(80, 44);
            this.yearNUD.TabIndex = 27;
            // 
            // promoTB
            // 
            this.promoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.promoTB.Location = new System.Drawing.Point(17, 151);
            this.promoTB.Name = "promoTB";
            this.promoTB.Size = new System.Drawing.Size(138, 26);
            this.promoTB.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Телефон";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 26);
            this.button3.TabIndex = 30;
            this.button3.Text = "Проверить промокод";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // stoimL
            // 
            this.stoimL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stoimL.Location = new System.Drawing.Point(12, 38);
            this.stoimL.Name = "stoimL";
            this.stoimL.Size = new System.Drawing.Size(115, 29);
            this.stoimL.TabIndex = 31;
            this.stoimL.Text = "Стоимость: ";
            this.stoimL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceL
            // 
            this.priceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceL.Location = new System.Drawing.Point(133, 38);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(115, 29);
            this.priceL.TabIndex = 32;
            this.priceL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Промокод";
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceL);
            this.Controls.Add(this.stoimL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.promoTB);
            this.Controls.Add(this.yearNUD);
            this.Controls.Add(this.monthNUD);
            this.Controls.Add(this.cvvMTB);
            this.Controls.Add(this.numberMTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telephoneMTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(931, 434);
            this.MinimumSize = new System.Drawing.Size(931, 434);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox telephoneMTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox numberMTB;
        private System.Windows.Forms.MaskedTextBox cvvMTB;
        private System.Windows.Forms.NumericUpDown monthNUD;
        private System.Windows.Forms.NumericUpDown yearNUD;
        private System.Windows.Forms.TextBox promoTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label stoimL;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.Label label4;
    }
}