namespace simple_window_form
{
    partial class Form_SortArray
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
            this.btInput = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lbShowResult = new System.Windows.Forms.Label();
            this.btIncrease = new System.Windows.Forms.Button();
            this.btDecrease = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInput
            // 
            this.btInput.AutoSize = true;
            this.btInput.Location = new System.Drawing.Point(32, 28);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(110, 29);
            this.btInput.TabIndex = 0;
            this.btInput.Text = "Input a number";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(167, 30);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(129, 26);
            this.tbInput.TabIndex = 1;
            // 
            // lbShowResult
            // 
            this.lbShowResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbShowResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShowResult.Location = new System.Drawing.Point(32, 73);
            this.lbShowResult.Name = "lbShowResult";
            this.lbShowResult.Size = new System.Drawing.Size(264, 83);
            this.lbShowResult.TabIndex = 2;
            // 
            // btIncrease
            // 
            this.btIncrease.AutoSize = true;
            this.btIncrease.Location = new System.Drawing.Point(318, 28);
            this.btIncrease.Name = "btIncrease";
            this.btIncrease.Size = new System.Drawing.Size(75, 60);
            this.btIncrease.TabIndex = 3;
            this.btIncrease.Text = "Increase";
            this.btIncrease.UseVisualStyleBackColor = true;
            this.btIncrease.Click += new System.EventHandler(this.btIncrease_Click);
            // 
            // btDecrease
            // 
            this.btDecrease.AutoSize = true;
            this.btDecrease.Location = new System.Drawing.Point(318, 96);
            this.btDecrease.Name = "btDecrease";
            this.btDecrease.Size = new System.Drawing.Size(76, 60);
            this.btDecrease.TabIndex = 4;
            this.btDecrease.Text = "Decrease";
            this.btDecrease.UseVisualStyleBackColor = true;
            this.btDecrease.Click += new System.EventHandler(this.btDecrease_Click);
            // 
            // btPrint
            // 
            this.btPrint.AutoSize = true;
            this.btPrint.Location = new System.Drawing.Point(32, 169);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(100, 29);
            this.btPrint.TabIndex = 5;
            this.btPrint.Text = "Print Array";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.Location = new System.Drawing.Point(164, 169);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 29);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.Location = new System.Drawing.Point(293, 169);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 29);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form_SortArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(426, 219);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btDecrease);
            this.Controls.Add(this.btIncrease);
            this.Controls.Add(this.lbShowResult);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btInput);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_SortArray";
            this.Text = "Sort Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lbShowResult;
        private System.Windows.Forms.Button btIncrease;
        private System.Windows.Forms.Button btDecrease;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
    }
}