namespace 曜日算出
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeldayoftheweek = new System.Windows.Forms.Label();
            this.NumericMonth = new System.Windows.Forms.NumericUpDown();
            this.NumericDay = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDay)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxYear
            // 
            this.textBoxYear.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxYear.Location = new System.Drawing.Point(63, 62);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(71, 19);
            this.textBoxYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "西暦";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "月";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "日";
            // 
            // labeldayoftheweek
            // 
            this.labeldayoftheweek.AutoSize = true;
            this.labeldayoftheweek.Location = new System.Drawing.Point(326, 62);
            this.labeldayoftheweek.Name = "labeldayoftheweek";
            this.labeldayoftheweek.Size = new System.Drawing.Size(35, 12);
            this.labeldayoftheweek.TabIndex = 6;
            this.labeldayoftheweek.Text = "label4";
            // 
            // NumericMonth
            // 
            this.NumericMonth.Location = new System.Drawing.Point(154, 62);
            this.NumericMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumericMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericMonth.Name = "NumericMonth";
            this.NumericMonth.Size = new System.Drawing.Size(50, 19);
            this.NumericMonth.TabIndex = 7;
            this.NumericMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericDay
            // 
            this.NumericDay.Location = new System.Drawing.Point(226, 62);
            this.NumericDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NumericDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericDay.Name = "NumericDay";
            this.NumericDay.Size = new System.Drawing.Size(46, 19);
            this.NumericDay.TabIndex = 8;
            this.NumericDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "曜日算出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 132);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumericDay);
            this.Controls.Add(this.NumericMonth);
            this.Controls.Add(this.labeldayoftheweek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeldayoftheweek;
        private System.Windows.Forms.NumericUpDown NumericMonth;
        private System.Windows.Forms.NumericUpDown NumericDay;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

