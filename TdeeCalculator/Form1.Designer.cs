namespace TdeeCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActivity = new System.Windows.Forms.ComboBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.ckLabor = new System.Windows.Forms.CheckBox();
            this.ckIntensity = new System.Windows.Forms.CheckBox();
            this.ckMail = new System.Windows.Forms.CheckBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGoal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "男生",
            "女生"});
            this.cbGender.Location = new System.Drawing.Point(149, 25);
            this.cbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(175, 31);
            this.cbGender.TabIndex = 0;
            this.cbGender.Text = "請選擇";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "性別";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "年齡";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "身高(cm)";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(25, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "體重(KG)";
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbAge.Location = new System.Drawing.Point(149, 66);
            this.tbAge.Margin = new System.Windows.Forms.Padding(2);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(175, 32);
            this.tbAge.TabIndex = 5;
            // 
            // tbHeight
            // 
            this.tbHeight.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbHeight.Location = new System.Drawing.Point(149, 118);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(2);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(175, 32);
            this.tbHeight.TabIndex = 6;
            // 
            // tbWeight
            // 
            this.tbWeight.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbWeight.Location = new System.Drawing.Point(149, 165);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(2);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(175, 32);
            this.tbWeight.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.Location = new System.Drawing.Point(29, 397);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(295, 54);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(25, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "活動量";
            // 
            // cbActivity
            // 
            this.cbActivity.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbActivity.FormattingEnabled = true;
            this.cbActivity.Items.AddRange(new object[] {
            "完全沒有運動",
            "一週運動三次",
            "一週運動四次",
            "一週運動五次",
            "一週運動六次",
            "一週運動七次"});
            this.cbActivity.Location = new System.Drawing.Point(149, 211);
            this.cbActivity.Margin = new System.Windows.Forms.Padding(2);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(175, 31);
            this.cbActivity.TabIndex = 10;
            this.cbActivity.Text = "請選擇";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(116, 467);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 20);
            this.lblMsg.TabIndex = 12;
            // 
            // ckLabor
            // 
            this.ckLabor.AutoSize = true;
            this.ckLabor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckLabor.Location = new System.Drawing.Point(38, 306);
            this.ckLabor.Name = "ckLabor";
            this.ckLabor.Size = new System.Drawing.Size(140, 24);
            this.ckLabor.TabIndex = 13;
            this.ckLabor.Text = "是否為勞力工作";
            this.ckLabor.UseVisualStyleBackColor = true;
            // 
            // ckIntensity
            // 
            this.ckIntensity.AutoSize = true;
            this.ckIntensity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckIntensity.Location = new System.Drawing.Point(205, 306);
            this.ckIntensity.Name = "ckIntensity";
            this.ckIntensity.Size = new System.Drawing.Size(156, 24);
            this.ckIntensity.TabIndex = 14;
            this.ckIntensity.Text = "訓練強度是否特高";
            this.ckIntensity.UseVisualStyleBackColor = true;
            // 
            // ckMail
            // 
            this.ckMail.AutoSize = true;
            this.ckMail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckMail.Location = new System.Drawing.Point(38, 338);
            this.ckMail.Name = "ckMail";
            this.ckMail.Size = new System.Drawing.Size(188, 24);
            this.ckMail.TabIndex = 15;
            this.ckMail.Text = "是否須將結果寄至信箱";
            this.ckMail.UseVisualStyleBackColor = true;
            this.ckMail.CheckedChanged += new System.EventHandler(this.ckMail_CheckedChanged);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(38, 368);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(286, 22);
            this.tbMail.TabIndex = 16;
            this.tbMail.Text = "Email";
            this.tbMail.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(25, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "目標";
            // 
            // cbGoal
            // 
            this.cbGoal.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbGoal.FormattingEnabled = true;
            this.cbGoal.Items.AddRange(new object[] {
            "最少增肌",
            "正常增肌",
            "瘋狂增肌",
            "正常減脂",
            "瘋狂減脂",
            "可能消耗肌肉"});
            this.cbGoal.Location = new System.Drawing.Point(149, 257);
            this.cbGoal.Margin = new System.Windows.Forms.Padding(2);
            this.cbGoal.Name = "cbGoal";
            this.cbGoal.Size = new System.Drawing.Size(175, 31);
            this.cbGoal.TabIndex = 17;
            this.cbGoal.Text = "請選擇";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 497);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGoal);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.ckMail);
            this.Controls.Add(this.ckIntensity);
            this.Controls.Add(this.ckLabor);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbActivity);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGender);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "TDEE計算機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbActivity;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.CheckBox ckLabor;
        private System.Windows.Forms.CheckBox ckIntensity;
        private System.Windows.Forms.CheckBox ckMail;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGoal;
    }
}

