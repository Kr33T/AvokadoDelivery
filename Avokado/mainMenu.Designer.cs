namespace Avokado
{
    partial class mainMenu
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
            this.profileL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsDGV = new System.Windows.Forms.DataGridView();
            this.sortGB = new System.Windows.Forms.GroupBox();
            this.brandCB = new System.Windows.Forms.ComboBox();
            this.goodTypeCB = new System.Windows.Forms.ComboBox();
            this.nameGoodTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minPriceNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxPriceNUD = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).BeginInit();
            this.sortGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // profileL
            // 
            this.profileL.AutoSize = true;
            this.profileL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileL.Location = new System.Drawing.Point(0, 0);
            this.profileL.Name = "profileL";
            this.profileL.Size = new System.Drawing.Size(37, 24);
            this.profileL.TabIndex = 0;
            this.profileL.Text = "</>";
            this.profileL.Click += new System.EventHandler(this.profileL_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(780, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 150);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(185, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Хотите выйти?";
            // 
            // goodsDGV
            // 
            this.goodsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDGV.Location = new System.Drawing.Point(4, 87);
            this.goodsDGV.Name = "goodsDGV";
            this.goodsDGV.Size = new System.Drawing.Size(543, 154);
            this.goodsDGV.TabIndex = 2;
            // 
            // sortGB
            // 
            this.sortGB.Controls.Add(this.maxPriceNUD);
            this.sortGB.Controls.Add(this.label6);
            this.sortGB.Controls.Add(this.label5);
            this.sortGB.Controls.Add(this.minPriceNUD);
            this.sortGB.Controls.Add(this.label4);
            this.sortGB.Controls.Add(this.label3);
            this.sortGB.Controls.Add(this.label2);
            this.sortGB.Controls.Add(this.nameGoodTB);
            this.sortGB.Controls.Add(this.goodTypeCB);
            this.sortGB.Controls.Add(this.brandCB);
            this.sortGB.Location = new System.Drawing.Point(4, 247);
            this.sortGB.Name = "sortGB";
            this.sortGB.Size = new System.Drawing.Size(462, 132);
            this.sortGB.TabIndex = 3;
            this.sortGB.TabStop = false;
            this.sortGB.Text = "Сортировка";
            // 
            // brandCB
            // 
            this.brandCB.FormattingEnabled = true;
            this.brandCB.Location = new System.Drawing.Point(8, 48);
            this.brandCB.Name = "brandCB";
            this.brandCB.Size = new System.Drawing.Size(121, 21);
            this.brandCB.TabIndex = 0;
            this.brandCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // goodTypeCB
            // 
            this.goodTypeCB.FormattingEnabled = true;
            this.goodTypeCB.Location = new System.Drawing.Point(335, 47);
            this.goodTypeCB.Name = "goodTypeCB";
            this.goodTypeCB.Size = new System.Drawing.Size(121, 21);
            this.goodTypeCB.TabIndex = 1;
            this.goodTypeCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // nameGoodTB
            // 
            this.nameGoodTB.Location = new System.Drawing.Point(136, 48);
            this.nameGoodTB.Name = "nameGoodTB";
            this.nameGoodTB.Size = new System.Drawing.Size(193, 20);
            this.nameGoodTB.TabIndex = 2;
            this.nameGoodTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Брэнд";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название продукта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Категория";
            // 
            // minPriceNUD
            // 
            this.minPriceNUD.Location = new System.Drawing.Point(9, 97);
            this.minPriceNUD.Name = "minPriceNUD";
            this.minPriceNUD.Size = new System.Drawing.Size(120, 20);
            this.minPriceNUD.TabIndex = 6;
            this.minPriceNUD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Минимальная цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Максимальная цена";
            // 
            // maxPriceNUD
            // 
            this.maxPriceNUD.Location = new System.Drawing.Point(136, 97);
            this.maxPriceNUD.Name = "maxPriceNUD";
            this.maxPriceNUD.Size = new System.Drawing.Size(120, 20);
            this.maxPriceNUD.TabIndex = 9;
            this.maxPriceNUD.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sortGB);
            this.Controls.Add(this.goodsDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.profileL);
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDGV)).EndInit();
            this.sortGB.ResumeLayout(false);
            this.sortGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView goodsDGV;
        private System.Windows.Forms.GroupBox sortGB;
        private System.Windows.Forms.TextBox nameGoodTB;
        private System.Windows.Forms.ComboBox goodTypeCB;
        private System.Windows.Forms.ComboBox brandCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxPriceNUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown minPriceNUD;
        private System.Windows.Forms.Button button2;
    }
}