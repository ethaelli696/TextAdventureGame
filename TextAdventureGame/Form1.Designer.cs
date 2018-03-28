namespace TextAdventureGame
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
            this.sceneBox = new System.Windows.Forms.PictureBox();
            this.tobyBox = new System.Windows.Forms.PictureBox();
            this.sceneOutput = new System.Windows.Forms.Label();
            this.errorBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sceneBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tobyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sceneBox
            // 
            this.sceneBox.Location = new System.Drawing.Point(35, 28);
            this.sceneBox.Name = "sceneBox";
            this.sceneBox.Size = new System.Drawing.Size(558, 261);
            this.sceneBox.TabIndex = 0;
            this.sceneBox.TabStop = false;
            // 
            // tobyBox
            // 
            this.tobyBox.Image = global::TextAdventureGame.Properties.Resources.toby;
            this.tobyBox.Location = new System.Drawing.Point(522, 344);
            this.tobyBox.Name = "tobyBox";
            this.tobyBox.Size = new System.Drawing.Size(90, 69);
            this.tobyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tobyBox.TabIndex = 1;
            this.tobyBox.TabStop = false;
            // 
            // sceneOutput
            // 
            this.sceneOutput.AutoSize = true;
            this.sceneOutput.Location = new System.Drawing.Point(32, 292);
            this.sceneOutput.Name = "sceneOutput";
            this.sceneOutput.Size = new System.Drawing.Size(35, 13);
            this.sceneOutput.TabIndex = 2;
            this.sceneOutput.Text = "label1";
            // 
            // errorBox
            // 
            this.errorBox.AutoSize = true;
            this.errorBox.Location = new System.Drawing.Point(35, 9);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(0, 13);
            this.errorBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(614, 414);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.sceneOutput);
            this.Controls.Add(this.tobyBox);
            this.Controls.Add(this.sceneBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sceneBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tobyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sceneBox;
        private System.Windows.Forms.PictureBox tobyBox;
        private System.Windows.Forms.Label sceneOutput;
        private System.Windows.Forms.Label errorBox;
    }
}

