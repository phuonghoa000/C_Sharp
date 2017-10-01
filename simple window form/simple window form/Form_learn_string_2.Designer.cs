namespace simple_window_form
{
    partial class Form_learn_string_2
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
            this.lbFullName = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.btCount = new System.Windows.Forms.Button();
            this.btProper = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFullName.Location = new System.Drawing.Point(30, 29);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(78, 19);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Text = "Full Name";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(157, 26);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(248, 26);
            this.tbFullName.TabIndex = 1;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbResult.Location = new System.Drawing.Point(30, 70);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(53, 19);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Result";
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbShowResult.Location = new System.Drawing.Point(30, 103);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(375, 61);
            this.lbShowResult.TabIndex = 3;
            // 
            // btCount
            // 
            this.btCount.AutoSize = true;
            this.btCount.Location = new System.Drawing.Point(30, 177);
            this.btCount.Name = "btCount";
            this.btCount.Size = new System.Drawing.Size(121, 29);
            this.btCount.TabIndex = 4;
            this.btCount.Text = "CountOfWord";
            this.btCount.UseVisualStyleBackColor = true;
            this.btCount.Click += new System.EventHandler(this.btCount_Click);
            // 
            // btProper
            // 
            this.btProper.AutoSize = true;
            this.btProper.Location = new System.Drawing.Point(30, 212);
            this.btProper.Name = "btProper";
            this.btProper.Size = new System.Drawing.Size(121, 29);
            this.btProper.TabIndex = 5;
            this.btProper.Text = "Proper";
            this.btProper.UseVisualStyleBackColor = true;
            this.btProper.Click += new System.EventHandler(this.btProper_Click);
            // 
            // btLeft
            // 
            this.btLeft.AutoSize = true;
            this.btLeft.Location = new System.Drawing.Point(157, 177);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(121, 29);
            this.btLeft.TabIndex = 6;
            this.btLeft.Text = "Left";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.AutoSize = true;
            this.btRight.Location = new System.Drawing.Point(157, 212);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(121, 29);
            this.btRight.TabIndex = 7;
            this.btRight.Text = "Right";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.Location = new System.Drawing.Point(284, 177);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(121, 29);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.Location = new System.Drawing.Point(284, 212);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 29);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form_learn_string_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 264);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.btProper);
            this.Controls.Add(this.btCount);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lbFullName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_learn_string_2";
            this.Text = "Full Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.Button btCount;
        private System.Windows.Forms.Button btProper;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
    }
}