namespace N10310027_GUI_Class
{
    partial class FormButton
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnLabel = new System.Windows.Forms.Button();
            this.labDont = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(42, 142);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(100, 40);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "請按我一下";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnLabel
            // 
            this.btnLabel.Location = new System.Drawing.Point(207, 142);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(100, 40);
            this.btnLabel.TabIndex = 1;
            this.btnLabel.Text = "請按我一下";
            this.btnLabel.UseVisualStyleBackColor = true;
            this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
            // 
            // labDont
            // 
            this.labDont.AutoSize = true;
            this.labDont.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labDont.Location = new System.Drawing.Point(204, 94);
            this.labDont.Name = "labDont";
            this.labDont.Size = new System.Drawing.Size(135, 16);
            this.labDont.TabIndex = 2;
            this.labDont.Text = "不要按底下的按鈕";
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labCount.Location = new System.Drawing.Point(521, 94);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(15, 16);
            this.labCount.TabIndex = 4;
            this.labCount.Text = "0";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(407, 142);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(100, 40);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "加1";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(554, 142);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(100, 40);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "減1";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // FormButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.labDont);
            this.Controls.Add(this.btnLabel);
            this.Controls.Add(this.btnClick);
            this.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormButton";
            this.Text = "按鈕";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnLabel;
        private System.Windows.Forms.Label labDont;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnMinus;
    }
}