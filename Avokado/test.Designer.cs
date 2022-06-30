namespace Avokado
{
    partial class test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.productsP = new System.Windows.Forms.Panel();
            this.categoriesP = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxPriceNUD = new System.Windows.Forms.NumericUpDown();
            this.minPriceNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.brandsP = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.userBTN = new System.Windows.Forms.Button();
            this.cartBTN = new System.Windows.Forms.Button();
            this.actionsP = new System.Windows.Forms.Panel();
            this.closePanel = new System.Windows.Forms.Button();
            this.userDataBTN = new System.Windows.Forms.Button();
            this.orderHistoryBTN = new System.Windows.Forms.Button();
            this.logOutBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceNUD)).BeginInit();
            this.actionsP.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsP
            // 
            this.productsP.AutoScroll = true;
            this.productsP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsP.Location = new System.Drawing.Point(264, 144);
            this.productsP.Name = "productsP";
            this.productsP.Size = new System.Drawing.Size(1008, 585);
            this.productsP.TabIndex = 0;
            // 
            // categoriesP
            // 
            this.categoriesP.AutoScroll = true;
            this.categoriesP.Location = new System.Drawing.Point(12, 479);
            this.categoriesP.Name = "categoriesP";
            this.categoriesP.Size = new System.Drawing.Size(246, 221);
            this.categoriesP.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTB.Location = new System.Drawing.Point(218, 31);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(676, 31);
            this.searchTB.TabIndex = 6;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск по названию продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Категории";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(260, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Каталог товаров";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(0, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1286, 2);
            this.label4.TabIndex = 9;
            // 
            // maxPriceNUD
            // 
            this.maxPriceNUD.Location = new System.Drawing.Point(165, 162);
            this.maxPriceNUD.Name = "maxPriceNUD";
            this.maxPriceNUD.Size = new System.Drawing.Size(90, 20);
            this.maxPriceNUD.TabIndex = 11;
            this.maxPriceNUD.ValueChanged += new System.EventHandler(this.maxPriceNUD_ValueChanged);
            // 
            // minPriceNUD
            // 
            this.minPriceNUD.Location = new System.Drawing.Point(36, 162);
            this.minPriceNUD.Name = "minPriceNUD";
            this.minPriceNUD.Size = new System.Drawing.Size(90, 20);
            this.minPriceNUD.TabIndex = 10;
            this.minPriceNUD.ValueChanged += new System.EventHandler(this.minPriceNUD_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "от";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "до";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Восстановить по умолчанию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brandsP
            // 
            this.brandsP.AutoScroll = true;
            this.brandsP.Location = new System.Drawing.Point(12, 222);
            this.brandsP.Name = "brandsP";
            this.brandsP.Size = new System.Drawing.Size(246, 221);
            this.brandsP.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Брэнды/произовдители";
            // 
            // userBTN
            // 
            this.userBTN.Location = new System.Drawing.Point(1132, 0);
            this.userBTN.Name = "userBTN";
            this.userBTN.Size = new System.Drawing.Size(154, 81);
            this.userBTN.TabIndex = 17;
            this.userBTN.Text = "Пользователь";
            this.userBTN.UseVisualStyleBackColor = true;
            this.userBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // cartBTN
            // 
            this.cartBTN.Location = new System.Drawing.Point(980, 0);
            this.cartBTN.Name = "cartBTN";
            this.cartBTN.Size = new System.Drawing.Size(154, 81);
            this.cartBTN.TabIndex = 18;
            this.cartBTN.Text = "Корзина";
            this.cartBTN.UseVisualStyleBackColor = true;
            // 
            // actionsP
            // 
            this.actionsP.Controls.Add(this.logOutBTN);
            this.actionsP.Controls.Add(this.orderHistoryBTN);
            this.actionsP.Controls.Add(this.userDataBTN);
            this.actionsP.Controls.Add(this.closePanel);
            this.actionsP.Location = new System.Drawing.Point(980, 79);
            this.actionsP.Name = "actionsP";
            this.actionsP.Size = new System.Drawing.Size(306, 662);
            this.actionsP.TabIndex = 19;
            this.actionsP.Visible = false;
            // 
            // closePanel
            // 
            this.closePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.closePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closePanel.Location = new System.Drawing.Point(0, 0);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(40, 662);
            this.closePanel.TabIndex = 0;
            this.closePanel.Text = "X";
            this.closePanel.UseVisualStyleBackColor = false;
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            // 
            // userDataBTN
            // 
            this.userDataBTN.Location = new System.Drawing.Point(46, 8);
            this.userDataBTN.Name = "userDataBTN";
            this.userDataBTN.Size = new System.Drawing.Size(252, 26);
            this.userDataBTN.TabIndex = 1;
            this.userDataBTN.Text = "Личные данные";
            this.userDataBTN.UseVisualStyleBackColor = true;
            this.userDataBTN.Click += new System.EventHandler(this.userDataBTN_Click);
            // 
            // orderHistoryBTN
            // 
            this.orderHistoryBTN.Location = new System.Drawing.Point(46, 40);
            this.orderHistoryBTN.Name = "orderHistoryBTN";
            this.orderHistoryBTN.Size = new System.Drawing.Size(252, 26);
            this.orderHistoryBTN.TabIndex = 2;
            this.orderHistoryBTN.Text = "История заказов";
            this.orderHistoryBTN.UseVisualStyleBackColor = true;
            this.orderHistoryBTN.Click += new System.EventHandler(this.orderHistoryBTN_Click);
            // 
            // logOutBTN
            // 
            this.logOutBTN.Location = new System.Drawing.Point(46, 72);
            this.logOutBTN.Name = "logOutBTN";
            this.logOutBTN.Size = new System.Drawing.Size(252, 26);
            this.logOutBTN.TabIndex = 3;
            this.logOutBTN.Text = "Выход";
            this.logOutBTN.UseVisualStyleBackColor = true;
            this.logOutBTN.Click += new System.EventHandler(this.logOutBTN_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.Controls.Add(this.actionsP);
            this.Controls.Add(this.cartBTN);
            this.Controls.Add(this.userBTN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.brandsP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxPriceNUD);
            this.Controls.Add(this.minPriceNUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.categoriesP);
            this.Controls.Add(this.productsP);
            this.MaximumSize = new System.Drawing.Size(1300, 780);
            this.MinimumSize = new System.Drawing.Size(1300, 780);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceNUD)).EndInit();
            this.actionsP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel productsP;
        private System.Windows.Forms.Panel categoriesP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown maxPriceNUD;
        private System.Windows.Forms.NumericUpDown minPriceNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel brandsP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button userBTN;
        private System.Windows.Forms.Button cartBTN;
        private System.Windows.Forms.Panel actionsP;
        private System.Windows.Forms.Button logOutBTN;
        private System.Windows.Forms.Button orderHistoryBTN;
        private System.Windows.Forms.Button userDataBTN;
        private System.Windows.Forms.Button closePanel;
    }
}