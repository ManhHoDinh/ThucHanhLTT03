namespace Bai05
{
    partial class Bai05
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
            this.lbNumber1 = new System.Windows.Forms.Label();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.lbNumber2 = new System.Windows.Forms.Label();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumber1
            // 
            this.lbNumber1.AutoSize = true;
            this.lbNumber1.Location = new System.Drawing.Point(96, 74);
            this.lbNumber1.Name = "lbNumber1";
            this.lbNumber1.Size = new System.Drawing.Size(78, 20);
            this.lbNumber1.TabIndex = 0;
            this.lbNumber1.Text = "Number 1";
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(240, 68);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(235, 26);
            this.tbNumber1.TabIndex = 0;
            // 
            // lbNumber2
            // 
            this.lbNumber2.AutoSize = true;
            this.lbNumber2.Location = new System.Drawing.Point(96, 132);
            this.lbNumber2.Name = "lbNumber2";
            this.lbNumber2.Size = new System.Drawing.Size(78, 20);
            this.lbNumber2.TabIndex = 0;
            this.lbNumber2.Text = "Number 2";
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(240, 126);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(235, 26);
            this.tbNumber2.TabIndex = 1;
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(96, 290);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(62, 20);
            this.lbAnswer.TabIndex = 0;
            this.lbAnswer.Text = "Answer";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Enabled = false;
            this.tbAnswer.Location = new System.Drawing.Point(240, 284);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(235, 26);
            this.tbAnswer.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(100, 204);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(67, 51);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btCalculatorClick);
            // 
            // btSub
            // 
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.Location = new System.Drawing.Point(209, 204);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(67, 51);
            this.btSub.TabIndex = 2;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btCalculatorClick);
            // 
            // btMul
            // 
            this.btMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMul.Location = new System.Drawing.Point(322, 204);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(67, 51);
            this.btMul.TabIndex = 2;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btCalculatorClick);
            // 
            // btDiv
            // 
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.Location = new System.Drawing.Point(419, 204);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(67, 51);
            this.btDiv.TabIndex = 2;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btCalculatorClick);
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.lbNumber2);
            this.Controls.Add(this.lbNumber1);
            this.Name = "Bai05";
            this.Text = "Bai05";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumber1;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.Label lbNumber2;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btDiv;
    }
}

