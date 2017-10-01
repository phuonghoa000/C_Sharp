namespace simple_window_form
{
    partial class Form_exception
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
            this.lbDivident = new System.Windows.Forms.Label();
            this.lbDivisor = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbDivident = new System.Windows.Forms.TextBox();
            this.tbDivisor = new System.Windows.Forms.TextBox();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.btDiv = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDivident
            // 
            this.lbDivident.AutoSize = true;
            this.lbDivident.Location = new System.Drawing.Point(27, 35);
            this.lbDivident.Name = "lbDivident";
            this.lbDivident.Size = new System.Drawing.Size(59, 19);
            this.lbDivident.TabIndex = 0;
            this.lbDivident.Text = "Divident";
            // 
            // lbDivisor
            // 
            this.lbDivisor.AutoSize = true;
            this.lbDivisor.Location = new System.Drawing.Point(27, 77);
            this.lbDivisor.Name = "lbDivisor";
            this.lbDivisor.Size = new System.Drawing.Size(52, 19);
            this.lbDivisor.TabIndex = 1;
            this.lbDivisor.Text = "Divisor";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(27, 118);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(46, 19);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Result";
            // 
            // tbDivident
            // 
            this.tbDivident.Location = new System.Drawing.Point(121, 32);
            this.tbDivident.Name = "tbDivident";
            this.tbDivident.Size = new System.Drawing.Size(120, 26);
            this.tbDivident.TabIndex = 3;
            // 
            // tbDivisor
            // 
            this.tbDivisor.Location = new System.Drawing.Point(121, 74);
            this.tbDivisor.Name = "tbDivisor";
            this.tbDivisor.Size = new System.Drawing.Size(120, 26);
            this.tbDivisor.TabIndex = 4;
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbShowResult.Location = new System.Drawing.Point(121, 118);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(120, 24);
            this.lbShowResult.TabIndex = 5;
            // 
            // btDiv
            // 
            this.btDiv.AutoSize = true;
            this.btDiv.Location = new System.Drawing.Point(286, 30);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(75, 29);
            this.btDiv.TabIndex = 6;
            this.btDiv.Text = "Div";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.Location = new System.Drawing.Point(286, 72);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 29);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.Location = new System.Drawing.Point(286, 113);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 29);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form_exception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(398, 172);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.tbDivisor);
            this.Controls.Add(this.tbDivident);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbDivisor);
            this.Controls.Add(this.lbDivident);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_exception";
            this.Text = "Test Exception";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDivident;
        private System.Windows.Forms.Label lbDivisor;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbDivident;
        private System.Windows.Forms.TextBox tbDivisor;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
    }
}