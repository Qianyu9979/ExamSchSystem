namespace 排考系统
{
    partial class Login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelForgetPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonManager = new System.Windows.Forms.RadioButton();
            this.radioButtonTeacher = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.labelRegister = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("楷体", 16F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(167, 323);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(248, 45);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("楷体", 16F);
            this.textBoxPassword.Location = new System.Drawing.Point(167, 226);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(248, 38);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("楷体", 16F);
            this.textBoxUsername.Location = new System.Drawing.Point(167, 185);
            this.textBoxUsername.MaxLength = 20;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(248, 38);
            this.textBoxUsername.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("楷体", 16F);
            this.labelUser.Image = ((System.Drawing.Image)(resources.GetObject("labelUser.Image")));
            this.labelUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelUser.Location = new System.Drawing.Point(37, 188);
            this.labelUser.Name = "labelUser";
            this.labelUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUser.Size = new System.Drawing.Size(124, 27);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "用户名：";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("楷体", 16F);
            this.labelPassword.Image = ((System.Drawing.Image)(resources.GetObject("labelPassword.Image")));
            this.labelPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPassword.Location = new System.Drawing.Point(53, 237);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPassword.Size = new System.Drawing.Size(96, 27);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "密码：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("楷体", 23F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "排考系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelForgetPassword
            // 
            this.labelForgetPassword.AutoSize = true;
            this.labelForgetPassword.Location = new System.Drawing.Point(344, 371);
            this.labelForgetPassword.Name = "labelForgetPassword";
            this.labelForgetPassword.Size = new System.Drawing.Size(87, 15);
            this.labelForgetPassword.TabIndex = 7;
            this.labelForgetPassword.Text = "忘记密码？";
            this.labelForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelForgetPassword.Click += new System.EventHandler(this.labelForgetPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 16F);
            this.label2.Location = new System.Drawing.Point(32, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "账号类型：";
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Font = new System.Drawing.Font("楷体", 16F);
            this.radioButtonManager.Location = new System.Drawing.Point(162, 280);
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Size = new System.Drawing.Size(117, 31);
            this.radioButtonManager.TabIndex = 9;
            this.radioButtonManager.TabStop = true;
            this.radioButtonManager.Text = "管理员";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.Font = new System.Drawing.Font("楷体", 16F);
            this.radioButtonTeacher.Location = new System.Drawing.Point(275, 280);
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Size = new System.Drawing.Size(89, 31);
            this.radioButtonTeacher.TabIndex = 10;
            this.radioButtonTeacher.TabStop = true;
            this.radioButtonTeacher.Text = "教师";
            this.radioButtonTeacher.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Font = new System.Drawing.Font("楷体", 16F);
            this.radioButtonStudent.Location = new System.Drawing.Point(359, 280);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(89, 31);
            this.radioButtonStudent.TabIndex = 11;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "学生";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Location = new System.Drawing.Point(164, 371);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(71, 15);
            this.labelRegister.TabIndex = 12;
            this.labelRegister.Text = "注册账号";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.radioButtonTeacher);
            this.Controls.Add(this.radioButtonManager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelForgetPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelForgetPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonManager;
        private System.Windows.Forms.RadioButton radioButtonTeacher;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.Label labelRegister;
    }
}

