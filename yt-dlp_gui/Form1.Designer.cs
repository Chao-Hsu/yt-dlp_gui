namespace yt_dlp_gui
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Download_Button = new System.Windows.Forms.Button();
            this.Search_listBox = new System.Windows.Forms.ListBox();
            this.radioButton_best = new System.Windows.Forms.RadioButton();
            this.radioButton_bestAudio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_richTextBox = new System.Windows.Forms.RichTextBox();
            this.radioButton_others = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_TextBox.Location = new System.Drawing.Point(122, 31);
            this.Search_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(1013, 29);
            this.Search_TextBox.TabIndex = 0;
            // 
            // Search_Button
            // 
            this.Search_Button.Font = new System.Drawing.Font("繁媛明朝 TW R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Search_Button.Location = new System.Drawing.Point(1143, 30);
            this.Search_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(145, 31);
            this.Search_Button.TabIndex = 1;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Download_Button
            // 
            this.Download_Button.Font = new System.Drawing.Font("繁媛明朝 TW R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Download_Button.Location = new System.Drawing.Point(1143, 577);
            this.Download_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Download_Button.Name = "Download_Button";
            this.Download_Button.Size = new System.Drawing.Size(145, 44);
            this.Download_Button.TabIndex = 4;
            this.Download_Button.Text = "Download";
            this.Download_Button.UseVisualStyleBackColor = true;
            this.Download_Button.Click += new System.EventHandler(this.Download_Button_Click);
            // 
            // Search_listBox
            // 
            this.Search_listBox.Font = new System.Drawing.Font("繁媛明朝 TW R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Search_listBox.FormattingEnabled = true;
            this.Search_listBox.ItemHeight = 18;
            this.Search_listBox.Location = new System.Drawing.Point(122, 74);
            this.Search_listBox.Name = "Search_listBox";
            this.Search_listBox.Size = new System.Drawing.Size(1013, 490);
            this.Search_listBox.TabIndex = 5;
            this.Search_listBox.SelectedIndexChanged += new System.EventHandler(this.Search_listBox_SelectedIndexChanged);
            // 
            // radioButton_best
            // 
            this.radioButton_best.AutoSize = true;
            this.radioButton_best.Font = new System.Drawing.Font("繁媛明朝 TW R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_best.Location = new System.Drawing.Point(1147, 99);
            this.radioButton_best.Name = "radioButton_best";
            this.radioButton_best.Size = new System.Drawing.Size(67, 26);
            this.radioButton_best.TabIndex = 8;
            this.radioButton_best.TabStop = true;
            this.radioButton_best.Text = "Best";
            this.radioButton_best.UseVisualStyleBackColor = true;
            // 
            // radioButton_bestAudio
            // 
            this.radioButton_bestAudio.AutoSize = true;
            this.radioButton_bestAudio.Font = new System.Drawing.Font("繁媛明朝 TW R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_bestAudio.Location = new System.Drawing.Point(1147, 131);
            this.radioButton_bestAudio.Name = "radioButton_bestAudio";
            this.radioButton_bestAudio.Size = new System.Drawing.Size(127, 26);
            this.radioButton_bestAudio.TabIndex = 9;
            this.radioButton_bestAudio.TabStop = true;
            this.radioButton_bestAudio.Text = "Best Audio";
            this.radioButton_bestAudio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("繁媛明朝 TW R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1143, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Best Option";
            // 
            // cmd_richTextBox
            // 
            this.cmd_richTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_richTextBox.Location = new System.Drawing.Point(122, 633);
            this.cmd_richTextBox.Name = "cmd_richTextBox";
            this.cmd_richTextBox.ReadOnly = true;
            this.cmd_richTextBox.Size = new System.Drawing.Size(1166, 294);
            this.cmd_richTextBox.TabIndex = 11;
            this.cmd_richTextBox.Text = "";
            // 
            // radioButton_others
            // 
            this.radioButton_others.AutoSize = true;
            this.radioButton_others.Font = new System.Drawing.Font("繁媛明朝 TW R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton_others.Location = new System.Drawing.Point(1147, 163);
            this.radioButton_others.Name = "radioButton_others";
            this.radioButton_others.Size = new System.Drawing.Size(90, 26);
            this.radioButton_others.TabIndex = 12;
            this.radioButton_others.TabStop = true;
            this.radioButton_others.Text = "Others";
            this.radioButton_others.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1396, 961);
            this.Controls.Add(this.radioButton_others);
            this.Controls.Add(this.cmd_richTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_bestAudio);
            this.Controls.Add(this.radioButton_best);
            this.Controls.Add(this.Search_listBox);
            this.Controls.Add(this.Download_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Search_TextBox);
            this.Font = new System.Drawing.Font("繁媛明朝 TW R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Download_Button;
        private System.Windows.Forms.ListBox Search_listBox;
        private System.Windows.Forms.RadioButton radioButton_best;
        private System.Windows.Forms.RadioButton radioButton_bestAudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox cmd_richTextBox;
        private System.Windows.Forms.RadioButton radioButton_others;
    }
}

