namespace Meme_Creator_Version_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topText = new System.Windows.Forms.TextBox();
            this.bottomText = new System.Windows.Forms.TextBox();
            this.preview = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(61, 413);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 0;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(262, 413);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bottomText);
            this.groupBox1.Controls.Add(this.topText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 352);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bottom Text";
            // 
            // topText
            // 
            this.topText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.topText.Location = new System.Drawing.Point(24, 78);
            this.topText.Multiline = true;
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(247, 48);
            this.topText.TabIndex = 2;
            // 
            // bottomText
            // 
            this.bottomText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bottomText.Location = new System.Drawing.Point(24, 242);
            this.bottomText.Multiline = true;
            this.bottomText.Name = "bottomText";
            this.bottomText.Size = new System.Drawing.Size(247, 47);
            this.bottomText.TabIndex = 3;
            // 
            // preview
            // 
            this.preview.Location = new System.Drawing.Point(445, 26);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(315, 352);
            this.preview.TabIndex = 3;
            this.preview.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Meme Creator Version 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox bottomText;
        private System.Windows.Forms.TextBox topText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

