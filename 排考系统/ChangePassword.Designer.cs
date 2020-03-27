namespace 排考系统
{
    partial class ChangePassword
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
            this.buttonChangeYes = new System.Windows.Forms.Button();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChangeYes
            // 
            this.buttonChangeYes.BackColor = System.Drawing.Color.Transparent;
            this.buttonChangeYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeYes.Font = new System.Drawing.Font("楷体", 13F);
            this.buttonChangeYes.Location = new System.Drawing.Point(187, 335);
            this.buttonChangeYes.Name = "buttonChangeYes";
            this.buttonChangeYes.Size = new System.Drawing.Size(90, 33);
            this.buttonChangeYes.TabIndex = 18;
            this.buttonChangeYes.Text = "确定";
            this.buttonChangeYes.UseVisualStyleBackColor = false;
            this.buttonChangeYes.Click += new System.EventHandler(this.buttonChangeYes_Click);
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxOldPassword.Location = new System.Drawing.Point(187, 202);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(177, 30);
            this.textBoxOldPassword.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(79, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "旧密码：";
            // 
            // textBoxNewpassword
            // 
            this.textBoxNewpassword.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNewpassword.Location = new System.Drawing.Point(187, 246);
            this.textBoxNewpassword.Name = "textBoxNewpassword";
            this.textBoxNewpassword.PasswordChar = '*';
            this.textBoxNewpassword.Size = new System.Drawing.Size(177, 30);
            this.textBoxNewpassword.TabIndex = 15;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxusername.Location = new System.Drawing.Point(187, 152);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(177, 30);
            this.textBoxusername.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(79, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "新密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(79, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户名：";
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.buttonChangeYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 471);
            this.Controls.Add(this.buttonChangeYes);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewpassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChangeYes;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}