namespace N10310027_GUI_Class
{
    partial class Timer
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
            this.label_Class = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.btnButton = new System.Windows.Forms.Button();
            this.btnTextBox = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnHW2 = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnGuessNum = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Class.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_Class.Location = new System.Drawing.Point(16, 12);
            this.label_Class.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Class.Name = "label_Class";
            this.label_Class.Size = new System.Drawing.Size(142, 32);
            this.label_Class.TabIndex = 0;
            this.label_Class.Text = "多遊三甲";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ID.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_ID.Location = new System.Drawing.Point(180, 12);
            this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(158, 32);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "N10310027";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Name.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_Name.Location = new System.Drawing.Point(360, 12);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(110, 32);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "謝羽紋";
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(25, 104);
            this.btnButton.Margin = new System.Windows.Forms.Padding(4);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(133, 53);
            this.btnButton.TabIndex = 3;
            this.btnButton.Text = "按鈕";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnTextBox
            // 
            this.btnTextBox.Location = new System.Drawing.Point(25, 196);
            this.btnTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnTextBox.Name = "btnTextBox";
            this.btnTextBox.Size = new System.Drawing.Size(133, 53);
            this.btnTextBox.TabIndex = 4;
            this.btnTextBox.Text = "文字框";
            this.btnTextBox.UseVisualStyleBackColor = true;
            this.btnTextBox.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // btnMid
            // 
            this.btnMid.Location = new System.Drawing.Point(25, 288);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(133, 53);
            this.btnMid.TabIndex = 5;
            this.btnMid.Text = "期中考-攝氏轉華氏";
            this.btnMid.UseVisualStyleBackColor = true;
            this.btnMid.Click += new System.EventHandler(this.btnMid_Click);
            // 
            // btnHW2
            // 
            this.btnHW2.Location = new System.Drawing.Point(195, 104);
            this.btnHW2.Margin = new System.Windows.Forms.Padding(4);
            this.btnHW2.Name = "btnHW2";
            this.btnHW2.Size = new System.Drawing.Size(133, 53);
            this.btnHW2.TabIndex = 6;
            this.btnHW2.Text = "作業2";
            this.btnHW2.UseVisualStyleBackColor = true;
            this.btnHW2.Click += new System.EventHandler(this.btnHW2_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.btnTimer.Location = new System.Drawing.Point(195, 196);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(133, 53);
            this.btnTimer.TabIndex = 7;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnGuessNum
            // 
            this.btnGuessNum.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.btnGuessNum.Location = new System.Drawing.Point(195, 288);
            this.btnGuessNum.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuessNum.Name = "btnGuessNum";
            this.btnGuessNum.Size = new System.Drawing.Size(133, 53);
            this.btnGuessNum.TabIndex = 8;
            this.btnGuessNum.Text = "終極密碼";
            this.btnGuessNum.UseVisualStyleBackColor = true;
            this.btnGuessNum.Click += new System.EventHandler(this.btnGuessNum_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.btnFinal.Location = new System.Drawing.Point(366, 104);
            this.btnFinal.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(133, 53);
            this.btnFinal.TabIndex = 9;
            this.btnFinal.Text = "期末考－菜單";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 434);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnGuessNum);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnHW2);
            this.Controls.Add(this.btnMid);
            this.Controls.Add(this.btnTextBox);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Class);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timer";
            this.Text = "GUI主程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Class;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnTextBox;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnHW2;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnGuessNum;
        private System.Windows.Forms.Button btnFinal;
    }
}

