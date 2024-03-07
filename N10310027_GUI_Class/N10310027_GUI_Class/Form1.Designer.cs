namespace N10310027_GUI_Class
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
            this.label_Class = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Num = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Class.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_Class.Location = new System.Drawing.Point(12, 9);
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
            this.label_ID.Location = new System.Drawing.Point(326, 9);
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
            this.label_Name.Location = new System.Drawing.Point(678, 9);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(110, 32);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "謝羽紋";
            // 
            // label_Num
            // 
            this.label_Num.AutoSize = true;
            this.label_Num.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Num.Location = new System.Drawing.Point(376, 160);
            this.label_Num.Name = "label_Num";
            this.label_Num.Size = new System.Drawing.Size(44, 48);
            this.label_Num.TabIndex = 3;
            this.label_Num.Text = "0";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Add.Location = new System.Drawing.Point(270, 314);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(80, 40);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "加1";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Sub.Location = new System.Drawing.Point(451, 314);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(80, 40);
            this.btn_Sub.TabIndex = 5;
            this.btn_Sub.Text = "減1";
            this.btn_Sub.UseVisualStyleBackColor = true;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label_Num);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Class);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Class;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Num;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Sub;
    }
}

