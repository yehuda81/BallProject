namespace PopBall
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ballPB5 = new System.Windows.Forms.PictureBox();
            this.ballPB4 = new System.Windows.Forms.PictureBox();
            this.ballPB3 = new System.Windows.Forms.PictureBox();
            this.ballPB2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPB2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(349, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "POP BALL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PopBall.Properties.Resources.boom;
            this.pictureBox1.Location = new System.Drawing.Point(3000, 3000);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ballPB5
            // 
            this.ballPB5.Image = global::PopBall.Properties.Resources.BasketBall;
            this.ballPB5.Location = new System.Drawing.Point(3000, 3000);
            this.ballPB5.Name = "ballPB5";
            this.ballPB5.Size = new System.Drawing.Size(150, 150);
            this.ballPB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ballPB5.TabIndex = 5;
            this.ballPB5.TabStop = false;
            this.ballPB5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ballPB5_MouseClick);
            // 
            // ballPB4
            // 
            this.ballPB4.Image = global::PopBall.Properties.Resources.BasketBall;
            this.ballPB4.Location = new System.Drawing.Point(3000, 3000);
            this.ballPB4.Name = "ballPB4";
            this.ballPB4.Size = new System.Drawing.Size(150, 150);
            this.ballPB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ballPB4.TabIndex = 4;
            this.ballPB4.TabStop = false;
            this.ballPB4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ballPB4_MouseClick);
            // 
            // ballPB3
            // 
            this.ballPB3.Image = global::PopBall.Properties.Resources.BasketBall;
            this.ballPB3.Location = new System.Drawing.Point(3000, 3000);
            this.ballPB3.Name = "ballPB3";
            this.ballPB3.Size = new System.Drawing.Size(150, 150);
            this.ballPB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ballPB3.TabIndex = 3;
            this.ballPB3.TabStop = false;
            this.ballPB3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ballPB3_MouseClick);
            // 
            // ballPB2
            // 
            this.ballPB2.Image = global::PopBall.Properties.Resources.BasketBall;
            this.ballPB2.Location = new System.Drawing.Point(3000, 3000);
            this.ballPB2.Name = "ballPB2";
            this.ballPB2.Size = new System.Drawing.Size(150, 150);
            this.ballPB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ballPB2.TabIndex = 2;
            this.ballPB2.TabStop = false;
            this.ballPB2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ballPB2_MouseClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(850, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "New Game";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ballPB5);
            this.Controls.Add(this.ballPB4);
            this.Controls.Add(this.ballPB3);
            this.Controls.Add(this.ballPB2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ballPB2;
        private System.Windows.Forms.PictureBox ballPB3;
        private System.Windows.Forms.PictureBox ballPB4;
        private System.Windows.Forms.PictureBox ballPB5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

