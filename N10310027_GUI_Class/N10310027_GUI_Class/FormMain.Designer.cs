﻿namespace N10310027_GUI_Class
{
    partial class FormMain
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
            this.label_ID.Location = new System.Drawing.Point(435, 12);
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
            this.label_Name.Location = new System.Drawing.Point(904, 12);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(110, 32);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "謝羽紋";
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(25, 174);
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
            this.btnTextBox.Location = new System.Drawing.Point(25, 266);
            this.btnTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnTextBox.Name = "btnTextBox";
            this.btnTextBox.Size = new System.Drawing.Size(133, 53);
            this.btnTextBox.TabIndex = 4;
            this.btnTextBox.Text = "文字框";
            this.btnTextBox.UseVisualStyleBackColor = true;
            this.btnTextBox.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.btnTextBox);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Class);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
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
    }
}

