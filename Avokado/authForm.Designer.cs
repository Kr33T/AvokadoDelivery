namespace Avokado
{
    partial class authForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(authForm));
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.signInBTN = new System.Windows.Forms.Button();
            this.signUpL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showPasswordL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(202, 199);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(262, 20);
            this.loginTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(202, 239);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.Size = new System.Drawing.Size(262, 20);
            this.passwordTB.TabIndex = 1;
            // 
            // signInBTN
            // 
            this.signInBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInBTN.Location = new System.Drawing.Point(389, 302);
            this.signInBTN.Name = "signInBTN";
            this.signInBTN.Size = new System.Drawing.Size(75, 28);
            this.signInBTN.TabIndex = 2;
            this.signInBTN.Text = "Войти";
            this.signInBTN.UseVisualStyleBackColor = true;
            this.signInBTN.Click += new System.EventHandler(this.signInBTN_Click);
            // 
            // signUpL
            // 
            this.signUpL.AutoSize = true;
            this.signUpL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpL.Location = new System.Drawing.Point(199, 314);
            this.signUpL.Name = "signUpL";
            this.signUpL.Size = new System.Drawing.Size(130, 16);
            this.signUpL.TabIndex = 3;
            this.signUpL.Text = "Не удается зайти?";
            this.signUpL.Click += new System.EventHandler(this.signUpL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // showPasswordL
            // 
            this.showPasswordL.AutoSize = true;
            this.showPasswordL.Location = new System.Drawing.Point(371, 262);
            this.showPasswordL.Name = "showPasswordL";
            this.showPasswordL.Size = new System.Drawing.Size(93, 13);
            this.showPasswordL.TabIndex = 5;
            this.showPasswordL.Text = "показать пароль";
            this.showPasswordL.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // authForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPasswordL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signUpL);
            this.Controls.Add(this.signInBTN);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.MaximumSize = new System.Drawing.Size(666, 427);
            this.MinimumSize = new System.Drawing.Size(666, 427);
            this.Name = "authForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button signInBTN;
        private System.Windows.Forms.Label signUpL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label showPasswordL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

