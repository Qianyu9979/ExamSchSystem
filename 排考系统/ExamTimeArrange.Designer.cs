namespace 排考系统
{
    partial class ExamTimeArrange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxExamTime = new System.Windows.Forms.TextBox();
            this.buttonYes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerExamDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxDepart = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTerm = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.comboBoxDepart);
            this.groupBox1.Controls.Add(this.buttonYes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxCno);
            this.groupBox1.Controls.Add(this.textBoxStartTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxEndTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxExamTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerExamDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxTerm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(104, 58);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(172, 30);
            this.textBoxStartTime.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "开始时间：";
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(432, 58);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(172, 30);
            this.textBoxEndTime.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "结束时间：";
            // 
            // textBoxExamTime
            // 
            this.textBoxExamTime.Location = new System.Drawing.Point(757, 55);
            this.textBoxExamTime.Name = "textBoxExamTime";
            this.textBoxExamTime.Size = new System.Drawing.Size(172, 30);
            this.textBoxExamTime.TabIndex = 11;
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(923, 115);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(95, 34);
            this.buttonYes.TabIndex = 10;
            this.buttonYes.Text = "安排";
            this.buttonYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "考试时间：";
            // 
            // dateTimePickerExamDate
            // 
            this.dateTimePickerExamDate.Location = new System.Drawing.Point(756, 14);
            this.dateTimePickerExamDate.Name = "dateTimePickerExamDate";
            this.dateTimePickerExamDate.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerExamDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "考试日期：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 465);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBoxDepart
            // 
            this.comboBoxDepart.FormattingEnabled = true;
            this.comboBoxDepart.Items.AddRange(new object[] {
            "网计学院",
            "数信学院",
            "公共外语教学部",
            "电信学院",
            "经济学院",
            "新闻学院",
            "政法学院",
            "质监学院",
            "管理学院",
            "化学学院",
            "建工学院",
            "历史学院",
            "生命学院",
            "物理学院",
            "药学院",
            "医学部"});
            this.comboBoxDepart.Location = new System.Drawing.Point(432, 15);
            this.comboBoxDepart.Name = "comboBoxDepart";
            this.comboBoxDepart.Size = new System.Drawing.Size(208, 28);
            this.comboBoxDepart.TabIndex = 17;
            this.comboBoxDepart.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepart_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "开课系所：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(295, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 30);
            this.textBox2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "课序号：";
            // 
            // textBoxCno
            // 
            this.textBoxCno.Location = new System.Drawing.Point(89, 99);
            this.textBoxCno.Name = "textBoxCno";
            this.textBoxCno.Size = new System.Drawing.Size(100, 30);
            this.textBoxCno.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "课程号：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "XML技术基础       ",
            "大学数学C（高等数学I-1）",
            "大学数学C（概率统计Ⅰ）",
            "计算机图形学      ",
            "计算机组成与体系结构          ",
            "数字图像处理      ",
            "硬件描述语言      ",
            "面向对象程序设计        ",
            "信息安全数学基础        ",
            "数据通信原理      ",
            "电路分析基础      ",
            "计算机英语     ",
            "计算机控制技术       ",
            "C++程序设计       ",
            "微机原理与汇编语言         ",
            "嵌入式系统     ",
            "大学英语3",
            "高级编程技术      ",
            "密码学基础     ",
            "操作系统    ",
            "操作系统与安全       ",
            "数据结构    ",
            "移动终端软件开发        ",
            "大学英语1",
            "程序设计    ",
            "计算机网络     ",
            "计算学科导论      ",
            "算法分析与设计       "});
            this.comboBox1.Location = new System.Drawing.Point(516, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 28);
            this.comboBox1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "课程名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "学年学期：";
            // 
            // comboBoxTerm
            // 
            this.comboBoxTerm.FormattingEnabled = true;
            this.comboBoxTerm.Items.AddRange(new object[] {
            "2019-2020学年(春)学期",
            "2019-2010学年(秋)学期"});
            this.comboBoxTerm.Location = new System.Drawing.Point(104, 15);
            this.comboBoxTerm.Name = "comboBoxTerm";
            this.comboBoxTerm.Size = new System.Drawing.Size(208, 28);
            this.comboBoxTerm.TabIndex = 6;
            // 
            // ExamTimeArrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExamTimeArrange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试时间安排";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxExamTime;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerExamDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxDepart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private System.Windows.Forms.Label label1;
    }
}