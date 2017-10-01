namespace simple_window_form
{
    partial class Form_learn_string_1
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbFirstString = new System.Windows.Forms.Label();
            this.tbFirstString = new System.Windows.Forms.TextBox();
            this.lbSecondString = new System.Windows.Forms.Label();
            this.tbSecondString = new System.Windows.Forms.TextBox();
            this.lbRe = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btCompare = new System.Windows.Forms.Button();
            this.btConcat = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCompare2 = new System.Windows.Forms.Button();
            this.btIndexOf = new System.Windows.Forms.Button();
            this.btSubstring = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbTitle.Location = new System.Drawing.Point(34, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(398, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "String Processing Program 1";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFirstString
            // 
            this.lbFirstString.AutoSize = true;
            this.lbFirstString.Location = new System.Drawing.Point(34, 81);
            this.lbFirstString.Name = "lbFirstString";
            this.lbFirstString.Size = new System.Drawing.Size(75, 19);
            this.lbFirstString.TabIndex = 1;
            this.lbFirstString.Text = "First String";
            // 
            // tbFirstString
            // 
            this.tbFirstString.Location = new System.Drawing.Point(201, 78);
            this.tbFirstString.Name = "tbFirstString";
            this.tbFirstString.Size = new System.Drawing.Size(231, 26);
            this.tbFirstString.TabIndex = 2;
            this.tbFirstString.TextChanged += new System.EventHandler(this.tbFirstNumber_TextChanged);
            // 
            // lbSecondString
            // 
            this.lbSecondString.AutoSize = true;
            this.lbSecondString.Location = new System.Drawing.Point(34, 113);
            this.lbSecondString.Name = "lbSecondString";
            this.lbSecondString.Size = new System.Drawing.Size(94, 19);
            this.lbSecondString.TabIndex = 3;
            this.lbSecondString.Text = "Second String";
            // 
            // tbSecondString
            // 
            this.tbSecondString.Location = new System.Drawing.Point(201, 110);
            this.tbSecondString.Name = "tbSecondString";
            this.tbSecondString.Size = new System.Drawing.Size(231, 26);
            this.tbSecondString.TabIndex = 4;
            // 
            // lbRe
            // 
            this.lbRe.AutoSize = true;
            this.lbRe.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRe.Location = new System.Drawing.Point(34, 141);
            this.lbRe.Name = "lbRe";
            this.lbRe.Size = new System.Drawing.Size(52, 19);
            this.lbRe.TabIndex = 5;
            this.lbRe.Text = "Result";
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbResult.Location = new System.Drawing.Point(34, 173);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(398, 60);
            this.lbResult.TabIndex = 6;
            // 
            // btCompare
            // 
            this.btCompare.AutoSize = true;
            this.btCompare.Location = new System.Drawing.Point(38, 245);
            this.btCompare.Name = "btCompare";
            this.btCompare.Size = new System.Drawing.Size(94, 29);
            this.btCompare.TabIndex = 7;
            this.btCompare.Text = "Compare";
            this.btCompare.UseVisualStyleBackColor = true;
            this.btCompare.Click += new System.EventHandler(this.btCompare_Click);
            // 
            // btConcat
            // 
            this.btConcat.AutoSize = true;
            this.btConcat.Location = new System.Drawing.Point(138, 245);
            this.btConcat.Name = "btConcat";
            this.btConcat.Size = new System.Drawing.Size(94, 29);
            this.btConcat.TabIndex = 8;
            this.btConcat.Text = "Concat";
            this.btConcat.UseVisualStyleBackColor = true;
            this.btConcat.Click += new System.EventHandler(this.btConcat_Click);
            // 
            // btInsert
            // 
            this.btInsert.AutoSize = true;
            this.btInsert.Location = new System.Drawing.Point(238, 245);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(94, 29);
            this.btInsert.TabIndex = 9;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.Location = new System.Drawing.Point(338, 245);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(94, 29);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCompare2
            // 
            this.btCompare2.AutoSize = true;
            this.btCompare2.Location = new System.Drawing.Point(38, 283);
            this.btCompare2.Name = "btCompare2";
            this.btCompare2.Size = new System.Drawing.Size(94, 29);
            this.btCompare2.TabIndex = 11;
            this.btCompare2.Text = "COMPARE";
            this.btCompare2.UseVisualStyleBackColor = true;
            this.btCompare2.Click += new System.EventHandler(this.btCompare2_Click);
            // 
            // btIndexOf
            // 
            this.btIndexOf.AutoSize = true;
            this.btIndexOf.Location = new System.Drawing.Point(138, 283);
            this.btIndexOf.Name = "btIndexOf";
            this.btIndexOf.Size = new System.Drawing.Size(94, 29);
            this.btIndexOf.TabIndex = 12;
            this.btIndexOf.Text = "IndexOf";
            this.btIndexOf.UseVisualStyleBackColor = true;
            this.btIndexOf.Click += new System.EventHandler(this.btIndexOf_Click);
            // 
            // btSubstring
            // 
            this.btSubstring.AutoSize = true;
            this.btSubstring.Location = new System.Drawing.Point(238, 283);
            this.btSubstring.Name = "btSubstring";
            this.btSubstring.Size = new System.Drawing.Size(94, 29);
            this.btSubstring.TabIndex = 13;
            this.btSubstring.Text = "Substring";
            this.btSubstring.UseVisualStyleBackColor = true;
            this.btSubstring.Click += new System.EventHandler(this.btSubstring_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.Location = new System.Drawing.Point(338, 280);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(94, 29);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form_learn_string_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(465, 324);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSubstring);
            this.Controls.Add(this.btIndexOf);
            this.Controls.Add(this.btCompare2);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btConcat);
            this.Controls.Add(this.btCompare);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbRe);
            this.Controls.Add(this.tbSecondString);
            this.Controls.Add(this.lbSecondString);
            this.Controls.Add(this.tbFirstString);
            this.Controls.Add(this.lbFirstString);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_learn_string_1";
            this.Text = "String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFirstString;
        private System.Windows.Forms.TextBox tbFirstString;
        private System.Windows.Forms.Label lbSecondString;
        private System.Windows.Forms.TextBox tbSecondString;
        private System.Windows.Forms.Label lbRe;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btCompare;
        private System.Windows.Forms.Button btConcat;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCompare2;
        private System.Windows.Forms.Button btIndexOf;
        private System.Windows.Forms.Button btSubstring;
        private System.Windows.Forms.Button btCancel;
    }
}