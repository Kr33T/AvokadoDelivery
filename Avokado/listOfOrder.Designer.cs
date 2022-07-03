namespace Avokado
{
    partial class listOfOrder
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
            this.listOfOrderDGV = new System.Windows.Forms.DataGridView();
            this.closeBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPriceL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listOfOrderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Состав заказа";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 2);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // listOfOrderDGV
            // 
            this.listOfOrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfOrderDGV.Location = new System.Drawing.Point(17, 54);
            this.listOfOrderDGV.Name = "listOfOrderDGV";
            this.listOfOrderDGV.Size = new System.Drawing.Size(463, 150);
            this.listOfOrderDGV.TabIndex = 3;
            // 
            // closeBTN
            // 
            this.closeBTN.Location = new System.Drawing.Point(405, 221);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 4;
            this.closeBTN.Text = "Закрыть";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Итоговая стоимость:";
            // 
            // totalPriceL
            // 
            this.totalPriceL.AutoSize = true;
            this.totalPriceL.Location = new System.Drawing.Point(135, 226);
            this.totalPriceL.Name = "totalPriceL";
            this.totalPriceL.Size = new System.Drawing.Size(0, 13);
            this.totalPriceL.TabIndex = 6;
            // 
            // listOfOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 256);
            this.Controls.Add(this.totalPriceL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.listOfOrderDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(511, 295);
            this.MinimumSize = new System.Drawing.Size(511, 295);
            this.Name = "listOfOrder";
            this.Text = "listOfOrder";
            this.Load += new System.EventHandler(this.listOfOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfOrderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listOfOrderDGV;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalPriceL;
    }
}