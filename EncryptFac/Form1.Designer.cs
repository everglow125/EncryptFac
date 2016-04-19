namespace EncryptFac
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.RichTextBox();
            this.txtPassword = new System.Windows.Forms.RichTextBox();
            this.cbxEncode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.lblIV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "加密前";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(84, 23);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(190, 21);
            this.txtSource.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "加密类型";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(84, 63);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(190, 20);
            this.cbxType.TabIndex = 3;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "秘钥";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(604, 18);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(158, 35);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "加密";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(604, 55);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(158, 34);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "解密";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "加密后";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(84, 105);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(678, 85);
            this.txtKey.TabIndex = 9;
            this.txtKey.Text = "";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(84, 207);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(678, 151);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "";
            // 
            // cbxEncode
            // 
            this.cbxEncode.FormattingEnabled = true;
            this.cbxEncode.Location = new System.Drawing.Point(374, 63);
            this.cbxEncode.Name = "cbxEncode";
            this.cbxEncode.Size = new System.Drawing.Size(190, 20);
            this.cbxEncode.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "编码类型";
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(374, 23);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(190, 21);
            this.txtIV.TabIndex = 14;
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.Location = new System.Drawing.Point(339, 26);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(29, 12);
            this.lblIV.TabIndex = 13;
            this.lblIV.Text = "向量";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 384);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.cbxEncode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtKey;
        private System.Windows.Forms.RichTextBox txtPassword;
        private System.Windows.Forms.ComboBox cbxEncode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Label lblIV;
    }
}

