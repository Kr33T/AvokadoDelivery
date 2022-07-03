namespace Avokado
{
    partial class ShoppingCart
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
            this.goodsP = new System.Windows.Forms.Panel();
            this.infoP = new System.Windows.Forms.Panel();
            this.countGoodsL = new System.Windows.Forms.Label();
            this.priceCountL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressL = new System.Windows.Forms.Label();
            this.deliveryPriceL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeAddressBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.deliveryCB = new System.Windows.Forms.CheckBox();
            this.priceL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buyBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.infoP.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsP
            // 
            this.goodsP.AutoScroll = true;
            this.goodsP.Location = new System.Drawing.Point(0, 63);
            this.goodsP.Name = "goodsP";
            this.goodsP.Size = new System.Drawing.Size(696, 433);
            this.goodsP.TabIndex = 0;
            // 
            // infoP
            // 
            this.infoP.Controls.Add(this.countGoodsL);
            this.infoP.Controls.Add(this.priceCountL);
            this.infoP.Controls.Add(this.label6);
            this.infoP.Controls.Add(this.addressL);
            this.infoP.Controls.Add(this.deliveryPriceL);
            this.infoP.Controls.Add(this.label4);
            this.infoP.Controls.Add(this.changeAddressBTN);
            this.infoP.Controls.Add(this.label5);
            this.infoP.Controls.Add(this.deliveryCB);
            this.infoP.Controls.Add(this.priceL);
            this.infoP.Controls.Add(this.label3);
            this.infoP.Controls.Add(this.buyBTN);
            this.infoP.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoP.Location = new System.Drawing.Point(702, 0);
            this.infoP.Name = "infoP";
            this.infoP.Size = new System.Drawing.Size(278, 496);
            this.infoP.TabIndex = 1;
            // 
            // countGoodsL
            // 
            this.countGoodsL.Location = new System.Drawing.Point(11, 217);
            this.countGoodsL.Name = "countGoodsL";
            this.countGoodsL.Size = new System.Drawing.Size(129, 17);
            this.countGoodsL.TabIndex = 22;
            this.countGoodsL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceCountL
            // 
            this.priceCountL.Location = new System.Drawing.Point(140, 217);
            this.priceCountL.Name = "priceCountL";
            this.priceCountL.Size = new System.Drawing.Size(129, 17);
            this.priceCountL.TabIndex = 21;
            this.priceCountL.Text = "0";
            this.priceCountL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(14, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 2);
            this.label6.TabIndex = 20;
            // 
            // addressL
            // 
            this.addressL.Location = new System.Drawing.Point(11, 331);
            this.addressL.Name = "addressL";
            this.addressL.Size = new System.Drawing.Size(253, 17);
            this.addressL.TabIndex = 19;
            this.addressL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressL.Click += new System.EventHandler(this.label6_Click);
            // 
            // deliveryPriceL
            // 
            this.deliveryPriceL.Location = new System.Drawing.Point(96, 303);
            this.deliveryPriceL.Name = "deliveryPriceL";
            this.deliveryPriceL.Size = new System.Drawing.Size(170, 17);
            this.deliveryPriceL.TabIndex = 18;
            this.deliveryPriceL.Text = "-";
            this.deliveryPriceL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(14, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 2);
            this.label4.TabIndex = 17;
            // 
            // changeAddressBTN
            // 
            this.changeAddressBTN.Location = new System.Drawing.Point(14, 351);
            this.changeAddressBTN.Name = "changeAddressBTN";
            this.changeAddressBTN.Size = new System.Drawing.Size(66, 23);
            this.changeAddressBTN.TabIndex = 16;
            this.changeAddressBTN.Text = "Изменить";
            this.changeAddressBTN.UseVisualStyleBackColor = true;
            this.changeAddressBTN.Click += new System.EventHandler(this.changeAddressBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Информация о заказе";
            // 
            // deliveryCB
            // 
            this.deliveryCB.AutoSize = true;
            this.deliveryCB.Location = new System.Drawing.Point(14, 303);
            this.deliveryCB.Name = "deliveryCB";
            this.deliveryCB.Size = new System.Drawing.Size(76, 17);
            this.deliveryCB.TabIndex = 3;
            this.deliveryCB.Text = "Доставка";
            this.deliveryCB.UseVisualStyleBackColor = true;
            this.deliveryCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // priceL
            // 
            this.priceL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceL.Location = new System.Drawing.Point(101, 421);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(165, 25);
            this.priceL.TabIndex = 2;
            this.priceL.Text = "0";
            this.priceL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "К оплате:";
            // 
            // buyBTN
            // 
            this.buyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyBTN.Location = new System.Drawing.Point(14, 449);
            this.buyBTN.Name = "buyBTN";
            this.buyBTN.Size = new System.Drawing.Size(252, 35);
            this.buyBTN.TabIndex = 0;
            this.buyBTN.Text = "Оплатить";
            this.buyBTN.UseVisualStyleBackColor = true;
            this.buyBTN.Click += new System.EventHandler(this.buyBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Корзина";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(696, 2);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Очистить корзину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoP);
            this.Controls.Add(this.goodsP);
            this.MaximumSize = new System.Drawing.Size(996, 535);
            this.MinimumSize = new System.Drawing.Size(996, 535);
            this.Name = "ShoppingCart";
            this.Text = "ShoppingCart";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            this.infoP.ResumeLayout(false);
            this.infoP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel goodsP;
        private System.Windows.Forms.Panel infoP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buyBTN;
        private System.Windows.Forms.Label deliveryPriceL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changeAddressBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox deliveryCB;
        private System.Windows.Forms.Label addressL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label countGoodsL;
        private System.Windows.Forms.Label priceCountL;
    }
}