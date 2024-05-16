namespace N10310027_GUI_Class
{
    partial class FormGuessNum
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.labClub = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(152, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "←按它開始新遊戲";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.Location = new System.Drawing.Point(51, 41);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "開始遊戲";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(279, 155);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "猜";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // labClub
            // 
            this.labClub.AutoSize = true;
            this.labClub.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labClub.Location = new System.Drawing.Point(48, 105);
            this.labClub.Name = "labClub";
            this.labClub.Size = new System.Drawing.Size(199, 16);
            this.labClub.TabIndex = 3;
            this.labClub.Text = "提示：請輸入0～100的數字";
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(51, 155);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(196, 22);
            this.tbGuess.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // FormGuessNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.labClub);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "FormGuessNum";
            this.Text = "終極密碼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label labClub;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Timer timer1;
    }
}