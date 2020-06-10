namespace Hacking
{
    partial class Form1
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
            this.InputedText = new System.Windows.Forms.TextBox();
            this.CryptedText = new System.Windows.Forms.TextBox();
            this.txtBPublicKey = new System.Windows.Forms.Label();
            this.txtBSecretKey = new System.Windows.Forms.Label();
            this.DecryptedText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputedText
            // 
            this.InputedText.BackColor = System.Drawing.SystemColors.MenuBar;
            this.InputedText.Location = new System.Drawing.Point(39, 36);
            this.InputedText.Multiline = true;
            this.InputedText.Name = "InputedText";
            this.InputedText.Size = new System.Drawing.Size(200, 223);
            this.InputedText.TabIndex = 1;
            this.InputedText.TextChanged += new System.EventHandler(this.InputedText_TextChanged);
            // 
            // CryptedText
            // 
            this.CryptedText.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CryptedText.Location = new System.Drawing.Point(288, 36);
            this.CryptedText.Multiline = true;
            this.CryptedText.Name = "CryptedText";
            this.CryptedText.Size = new System.Drawing.Size(200, 223);
            this.CryptedText.TabIndex = 2;
            this.CryptedText.TextChanged += new System.EventHandler(this.CryptedText_TextChanged);
            // 
            // txtBPublicKey
            // 
            this.txtBPublicKey.AutoSize = true;
            this.txtBPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBPublicKey.Location = new System.Drawing.Point(230, 361);
            this.txtBPublicKey.Name = "txtBPublicKey";
            this.txtBPublicKey.Size = new System.Drawing.Size(143, 20);
            this.txtBPublicKey.TabIndex = 3;
            this.txtBPublicKey.Text = "Открытый ключ";
            // 
            // txtBSecretKey
            // 
            this.txtBSecretKey.AutoSize = true;
            this.txtBSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBSecretKey.Location = new System.Drawing.Point(231, 400);
            this.txtBSecretKey.Name = "txtBSecretKey";
            this.txtBSecretKey.Size = new System.Drawing.Size(142, 20);
            this.txtBSecretKey.TabIndex = 4;
            this.txtBSecretKey.Text = "Закрытый ключ";
            // 
            // DecryptedText
            // 
            this.DecryptedText.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DecryptedText.Location = new System.Drawing.Point(550, 36);
            this.DecryptedText.Multiline = true;
            this.DecryptedText.Name = "DecryptedText";
            this.DecryptedText.Size = new System.Drawing.Size(200, 223);
            this.DecryptedText.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(66, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(313, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Сохранить в файл";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(27, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 59);
            this.button3.TabIndex = 8;
            this.button3.Text = "Сгенерировать ключи";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(66, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Шифрованный файл";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите текст:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Зашифрованный текст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(546, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Расшифрованный текст:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DecryptedText);
            this.Controls.Add(this.txtBSecretKey);
            this.Controls.Add(this.txtBPublicKey);
            this.Controls.Add(this.CryptedText);
            this.Controls.Add(this.InputedText);
            this.Name = "Form1";
            this.Text = "Elgamal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputedText;
        private System.Windows.Forms.TextBox CryptedText;
        private System.Windows.Forms.Label txtBPublicKey;
        private System.Windows.Forms.Label txtBSecretKey;
        private System.Windows.Forms.TextBox DecryptedText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

