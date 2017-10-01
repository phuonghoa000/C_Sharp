namespace simple_window_form
{
    partial class Form_compute
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
            this.lbNumber2 = new System.Windows.Forms.Label();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.grboxChoice = new System.Windows.Forms.GroupBox();
            this.radiobtCD = new System.Windows.Forms.RadioButton();
            this.radiobtMGCD = new System.Windows.Forms.RadioButton();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btCompute = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.grboxChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumber1
            // 
            this.lbNumber1.AutoSize = true;
            this.lbNumber1.Location = new System.Drawing.Point(27, 51);
            this.lbNumber1.Name = "lbNumber1";
            this.lbNumber1.Size = new System.Drawing.Size(90, 19);
            this.lbNumber1.TabIndex = 0;
            this.lbNumber1.Text = "First Number";
            // 
            // lbNumber2
            // 
            this.lbNumber2.AutoSize = true;
            this.lbNumber2.Location = new System.Drawing.Point(27, 83);
            this.lbNumber2.Name = "lbNumber2";
            this.lbNumber2.Size = new System.Drawing.Size(109, 19);
            this.lbNumber2.TabIndex = 1;
            this.lbNumber2.Text = "Second Number";
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(145, 48);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(62, 26);
            this.tbNumber1.TabIndex = 2;
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(145, 80);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(62, 26);
            this.tbNumber2.TabIndex = 3;
            // 
            // grboxChoice
            // 
            this.grboxChoice.Controls.Add(this.radiobtMGCD);
            this.grboxChoice.Controls.Add(this.radiobtCD);
            this.grboxChoice.Location = new System.Drawing.Point(243, 25);
            this.grboxChoice.Name = "grboxChoice";
            this.grboxChoice.Size = new System.Drawing.Size(305, 94);
            this.grboxChoice.TabIndex = 4;
            this.grboxChoice.TabStop = false;
            this.grboxChoice.Text = "Your Choice";
            // 
            // radiobtCD
            // 
            this.radiobtCD.AutoSize = true;
            this.radiobtCD.Location = new System.Drawing.Point(27, 26);
            this.radiobtCD.Name = "radiobtCD";
            this.radiobtCD.Size = new System.Drawing.Size(183, 23);
            this.radiobtCD.TabIndex = 0;
            this.radiobtCD.TabStop = true;
            this.radiobtCD.Text = "Compute common divisor";
            this.radiobtCD.UseVisualStyleBackColor = true;
            // 
            // radiobtMGCD
            // 
            this.radiobtMGCD.AutoSize = true;
            this.radiobtMGCD.Location = new System.Drawing.Point(27, 56);
            this.radiobtMGCD.Name = "radiobtMGCD";
            this.radiobtMGCD.Size = new System.Drawing.Size(254, 23);
            this.radiobtMGCD.TabIndex = 1;
            this.radiobtMGCD.TabStop = true;
            this.radiobtMGCD.Text = "Compute most grand common divisor";
            this.radiobtMGCD.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(27, 140);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(46, 19);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "Result";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(145, 137);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(403, 26);
            this.tbResult.TabIndex = 6;
            // 
            // btCompute
            // 
            this.btCompute.AutoSize = true;
            this.btCompute.Location = new System.Drawing.Point(31, 199);
            this.btCompute.Name = "btCompute";
            this.btCompute.Size = new System.Drawing.Size(125, 29);
            this.btCompute.TabIndex = 7;
            this.btCompute.Text = "Compute";
            this.btCompute.UseVisualStyleBackColor = true;
            this.btCompute.Click += new System.EventHandler(this.btCompute_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.Location = new System.Drawing.Point(229, 199);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(125, 29);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.Location = new System.Drawing.Point(423, 199);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 29);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form_compute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(580, 254);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCompute);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.grboxChoice);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.lbNumber2);
            this.Controls.Add(this.lbNumber1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_compute";
            this.Text = "Common Divisor";
            this.grboxChoice.ResumeLayout(false);
            this.grboxChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumber1;
        private System.Windows.Forms.Label lbNumber2;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.GroupBox grboxChoice;
        private System.Windows.Forms.RadioButton radiobtMGCD;
        private System.Windows.Forms.RadioButton radiobtCD;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btCompute;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
    }
}