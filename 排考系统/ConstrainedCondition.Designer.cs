namespace 排考系统
{
    partial class ConstrainedCondition
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
            this.buttonYes = new System.Windows.Forms.Button();
            this.groupBoxConstrained = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkedListBoxCCon = new System.Windows.Forms.CheckedListBox();
            this.groupBoxConstrained.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(480, 425);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(99, 38);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "确定";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // groupBoxConstrained
            // 
            this.groupBoxConstrained.Controls.Add(this.checkedListBoxCCon);
            this.groupBoxConstrained.Location = new System.Drawing.Point(21, 12);
            this.groupBoxConstrained.Name = "groupBoxConstrained";
            this.groupBoxConstrained.Size = new System.Drawing.Size(687, 387);
            this.groupBoxConstrained.TabIndex = 1;
            this.groupBoxConstrained.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(608, 425);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 37);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCCon
            // 
            this.checkedListBoxCCon.FormattingEnabled = true;
            this.checkedListBoxCCon.Items.AddRange(new object[] {
            "同一班级不能在同一时间参加多场考试",
            "同一课程必须安排在同一时间考试",
            "同一教室同一时间尽量安排一门考试",
            "同一课程的不同考场尽量安排在同一教学楼",
            "同一监考教师同一时间只能监考一个考场"});
            this.checkedListBoxCCon.Location = new System.Drawing.Point(23, 33);
            this.checkedListBoxCCon.Name = "checkedListBoxCCon";
            this.checkedListBoxCCon.Size = new System.Drawing.Size(644, 329);
            this.checkedListBoxCCon.TabIndex = 0;
            // 
            // ConstrainedCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 492);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxConstrained);
            this.Controls.Add(this.buttonYes);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConstrainedCondition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "约束条件设置";
            this.groupBoxConstrained.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.GroupBox groupBoxConstrained;
        private System.Windows.Forms.CheckedListBox checkedListBoxCCon;
        private System.Windows.Forms.Button buttonSave;
    }
}