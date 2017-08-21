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
            this.bottomText = new System.Windows.Forms.TextBox();
            this.topText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.PictureBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.Location = new System.Drawing.Point(49, 405);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(80, 31);
            this.open.TabIndex = 0;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(225, 405);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 31);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::Meme_Creator_Version_1.Properties.Resources.Background;
            this.groupBox1.Controls.Add(this.bottomText);
            this.groupBox1.Controls.Add(this.topText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 352);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // bottomText
            // 
            this.bottomText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bottomText.Location = new System.Drawing.Point(24, 242);
            this.bottomText.Multiline = true;
            this.bottomText.Name = "bottomText";
            this.bottomText.Size = new System.Drawing.Size(247, 47);
            this.bottomText.TabIndex = 3;
            this.bottomText.TextChanged += new System.EventHandler(this.bottomText_TextChanged);
            // 
            // topText
            // 
            this.topText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.topText.Location = new System.Drawing.Point(24, 78);
            this.topText.Multiline = true;
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(247, 48);
            this.topText.TabIndex = 2;
            this.topText.TextChanged += new System.EventHandler(this.topText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bottom Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Text";
            // 
            // preview
            // 
            this.preview.BackColor = System.Drawing.SystemColors.Control;
            this.preview.Location = new System.Drawing.Point(371, 26);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(383, 352);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preview.TabIndex = 3;
            this.preview.TabStop = false;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.BackColor = System.Drawing.Color.Transparent;
            this.topLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.White;
            this.topLabel.Location = new System.Drawing.Point(444, 40);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(85, 34);
            this.topLabel.TabIndex = 4;
            this.topLabel.Text = "label3";
            // 
            // bottomLabel
            // 
            this.bottomLabel.AutoSize = true;
            this.bottomLabel.BackColor = System.Drawing.Color.Transparent;
            this.bottomLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLabel.ForeColor = System.Drawing.Color.White;
            this.bottomLabel.Location = new System.Drawing.Point(445, 300);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(84, 34);
            this.bottomLabel.TabIndex = 5;
            this.bottomLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Meme_Creator_Version_1.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(827, 468);
            this.Controls.Add(this.bottomLabel);
            this.Controls.Add(this.topLabel);
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
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label bottomLabel;
    }
}

