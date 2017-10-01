namespace simple_window_form
{
    partial class Form_string_exercise
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
            this.btLen_Count = new System.Windows.Forms.Button();
            this.btLower = new System.Windows.Forms.Button();
            this.btUpper = new System.Windows.Forms.Button();
            this.btUpperFC = new System.Windows.Forms.Button();
            this.btSpace = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(41, 24);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(72, 19);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Text = "Full Name";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(158, 21);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(226, 26);
            this.tbFullName.TabIndex = 1;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(41, 77);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(46, 19);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "Result";
            // 
            // btLen_Count
            // 
            this.btLen_Count.AutoSize = true;
            this.btLen_Count.Location = new System.Drawing.Point(44, 126);
            this.btLen_Count.Name = "btLen_Count";
            this.btLen_Count.Size = new System.Drawing.Size(145, 29);
            this.btLen_Count.TabIndex = 4;
            this.btLen_Count.Text = "LengthAndCount";
            this.btLen_Count.UseVisualStyleBackColor = true;
            this.btLen_Count.Click += new System.EventHandler(this.btLen_Count_Click);
            // 
            // btLower
            // 
            this.btLower.AutoSize = true;
            this.btLower.Location = new System.Drawing.Point(294, 126);
            this.btLower.Name = "btLower";
            this.btLower.Size = new System.Drawing.Size(90, 46);
            this.btLower.TabIndex = 5;
            this.btLower.Text = "ToLower";
            this.btLower.UseVisualStyleBackColor = true;
            this.btLower.Click += new System.EventHandler(this.btLower_Click);
            // 
            // btUpper
            // 
            this.btUpper.AutoSize = true;
            this.btUpper.Location = new System.Drawing.Point(197, 126);
            this.btUpper.Name = "btUpper";
            this.btUpper.Size = new System.Drawing.Size(90, 46);
            this.btUpper.TabIndex = 6;
            this.btUpper.Text = "ToUpper";
            this.btUpper.UseVisualStyleBackColor = true;
            this.btUpper.Click += new System.EventHandler(this.btUpper_Click);
            // 
            // btUpperFC
            // 
            this.btUpperFC.AutoSize = true;
            this.btUpperFC.Location = new System.Drawing.Point(44, 161);
            this.btUpperFC.Name = "btUpperFC";
            this.btUpperFC.Size = new System.Drawing.Size(145, 29);
            this.btUpperFC.TabIndex = 7;
            this.btUpperFC.Text = "UpperFirstCharacter";
            this.btUpperFC.UseVisualStyleBackColor = true;
            this.btUpperFC.Click += new System.EventHandler(this.btUpperFC_Click);
            // 
            // btSpace
            // 
            this.btSpace.AutoSize = true;
            this.btSpace.Location = new System.Drawing.Point(45, 196);
            this.btSpace.Name = "btSpace";
            this.btSpace.Size = new System.Drawing.Size(144, 29);
            this.btSpace.TabIndex = 8;
            this.btSpace.Text = "FormatSpace";
            this.btSpace.UseVisualStyleBackColor = true;
            this.btSpace.Click += new System.EventHandler(this.button5_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.Location = new System.Drawing.Point(198, 179);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(90, 46);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.Location = new System.Drawing.Point(294, 179);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(90, 46);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbShowResult.Location = new System.Drawing.Point(158, 64);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(226, 46);
            this.lbShowResult.TabIndex = 11;
            // 
            // Form_string_exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(426, 254);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSpace);
            this.Controls.Add(this.btUpperFC);
            this.Controls.Add(this.btUpper);
            this.Controls.Add(this.btLower);
            this.Controls.Add(this.btLen_Count);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lbFullName);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_string_exercise";
            this.Text = "Full Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btLen_Count;
        private System.Windows.Forms.Button btLower;
        private System.Windows.Forms.Button btUpper;
        private System.Windows.Forms.Button btUpperFC;
        private System.Windows.Forms.Button btSpace;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbShowResult;
    }
}