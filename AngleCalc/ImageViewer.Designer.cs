namespace AngleCalc
{
    partial class ImageViewer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.angle_ans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.TextBox();
            this.a2 = new System.Windows.Forms.TextBox();
            this.a3 = new System.Windows.Forms.TextBox();
            this.point = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // angle_ans
            // 
            this.angle_ans.Location = new System.Drawing.Point(372, 344);
            this.angle_ans.Name = "angle_ans";
            this.angle_ans.Size = new System.Drawing.Size(149, 20);
            this.angle_ans.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Angle";
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(195, 341);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(83, 20);
            this.a1.TabIndex = 5;
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(195, 367);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(83, 20);
            this.a2.TabIndex = 6;
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(195, 393);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(83, 20);
            this.a3.TabIndex = 7;
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(23, 393);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(116, 20);
            this.point.TabIndex = 8;
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 437);
            this.Controls.Add(this.point);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.angle_ans);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            this.Load += new System.EventHandler(this.ImageViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox angle_ans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.TextBox a3;
        private System.Windows.Forms.TextBox point;
    }
}