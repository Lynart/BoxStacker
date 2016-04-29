namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Output = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.uLength = new System.Windows.Forms.NumericUpDown();
            this.uWidth = new System.Windows.Forms.NumericUpDown();
            this.uHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(18, 225);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(136, 13);
            this.Output.TabIndex = 2;
            this.Output.Text = "Number of boxes that will fit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uLength
            // 
            this.uLength.Location = new System.Drawing.Point(21, 27);
            this.uLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uLength.Name = "uLength";
            this.uLength.Size = new System.Drawing.Size(120, 20);
            this.uLength.TabIndex = 5;
            this.uLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uWidth
            // 
            this.uWidth.Location = new System.Drawing.Point(21, 85);
            this.uWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uWidth.Name = "uWidth";
            this.uWidth.Size = new System.Drawing.Size(120, 20);
            this.uWidth.TabIndex = 6;
            this.uWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uHeight
            // 
            this.uHeight.Location = new System.Drawing.Point(21, 137);
            this.uHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uHeight.Name = "uHeight";
            this.uHeight.Size = new System.Drawing.Size(120, 20);
            this.uHeight.TabIndex = 7;
            this.uHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 370);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uHeight);
            this.Controls.Add(this.uWidth);
            this.Controls.Add(this.uLength);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown uLength;
        private System.Windows.Forms.NumericUpDown uWidth;
        private System.Windows.Forms.NumericUpDown uHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

