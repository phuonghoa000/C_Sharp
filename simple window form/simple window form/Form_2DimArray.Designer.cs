namespace simple_window_form
{
    partial class Form_2DimArray
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
            this.lbShow = new System.Windows.Forms.Label();
            this.btInput = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbShow
            // 
            this.lbShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbShow.Location = new System.Drawing.Point(32, 26);
            this.lbShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(256, 97);
            this.lbShow.TabIndex = 0;
            // 
            // btInput
            // 
            this.btInput.AutoSize = true;
            this.btInput.Location = new System.Drawing.Point(315, 36);
            this.btInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(112, 34);
            this.btInput.TabIndex = 1;
            this.btInput.Text = "Input";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // btSort
            // 
            this.btSort.AutoSize = true;
            this.btSort.Location = new System.Drawing.Point(315, 78);
            this.btSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(112, 34);
            this.btSort.TabIndex = 2;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // btPrint
            // 
            this.btPrint.AutoSize = true;
            this.btPrint.Location = new System.Drawing.Point(36, 149);
            this.btPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(112, 34);
            this.btPrint.TabIndex = 3;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.Location = new System.Drawing.Point(176, 149);
            this.btClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(112, 34);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.Location = new System.Drawing.Point(315, 149);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 34);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form_2DimArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(457, 209);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.lbShow);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_2DimArray";
            this.Text = "Two Dimension Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;
    }
}