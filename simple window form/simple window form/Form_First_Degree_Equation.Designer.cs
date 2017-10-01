namespace simple_window_form
{
    partial class Form_First_Degree_Equation
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
            this.lbFirst = new System.Windows.Forms.Label();
            this.lbSecond = new System.Windows.Forms.Label();
            this.lbRoot = new System.Windows.Forms.Label();
            this.lbShowRoot = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.btCompute = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFirst
            // 
            this.lbFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbFirst.Location = new System.Drawing.Point(40, 36);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(40, 24);
            this.lbFirst.TabIndex = 0;
            this.lbFirst.Text = "a";
            this.lbFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSecond
            // 
            this.lbSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbSecond.Location = new System.Drawing.Point(40, 91);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(40, 24);
            this.lbSecond.TabIndex = 1;
            this.lbSecond.Text = "b";
            this.lbSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRoot
            // 
            this.lbRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbRoot.Location = new System.Drawing.Point(40, 146);
            this.lbRoot.Name = "lbRoot";
            this.lbRoot.Size = new System.Drawing.Size(40, 24);
            this.lbRoot.TabIndex = 2;
            this.lbRoot.Text = "Root";
            this.lbRoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbShowRoot
            // 
            this.lbShowRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbShowRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShowRoot.Location = new System.Drawing.Point(118, 146);
            this.lbShowRoot.Name = "lbShowRoot";
            this.lbShowRoot.Size = new System.Drawing.Size(144, 24);
            this.lbShowRoot.TabIndex = 3;
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(118, 36);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(144, 26);
            this.tbFirst.TabIndex = 4;
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(118, 91);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(144, 26);
            this.tbSecond.TabIndex = 5;
            // 
            // btCompute
            // 
            this.btCompute.AutoSize = true;
            this.btCompute.Location = new System.Drawing.Point(300, 34);
            this.btCompute.Name = "btCompute";
            this.btCompute.Size = new System.Drawing.Size(75, 29);
            this.btCompute.TabIndex = 6;
            this.btCompute.Text = "Compute";
            this.btCompute.UseVisualStyleBackColor = true;
            this.btCompute.Click += new System.EventHandler(this.btCompute_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.Location = new System.Drawing.Point(300, 89);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 29);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.Location = new System.Drawing.Point(300, 142);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 29);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form_First_Degree_Equation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(411, 201);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCompute);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.lbShowRoot);
            this.Controls.Add(this.lbRoot);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.lbFirst);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_First_Degree_Equation";
            this.Text = "First Degree Equation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirst;
        private System.Windows.Forms.Label lbSecond;
        private System.Windows.Forms.Label lbRoot;
        private System.Windows.Forms.Label lbShowRoot;
        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Button btCompute;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCancel;

    }
}