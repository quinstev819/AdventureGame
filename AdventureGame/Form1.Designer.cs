namespace AdventureGame
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
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.sceneImage = new System.Windows.Forms.PictureBox();
            this.yellowImage = new System.Windows.Forms.PictureBox();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.redImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            this.SuspendLayout();
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(67, 313);
            this.redLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(257, 23);
            this.redLabel.TabIndex = 2;
            this.redLabel.Text = "Right";
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(67, 349);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(257, 23);
            this.blueLabel.TabIndex = 3;
            this.blueLabel.Text = "Left";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(24, 28);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(339, 55);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "You find yourself in a room. There are three doors. Which door would you like to " +
    "try first?";
            // 
            // yellowLabel
            // 
            this.yellowLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.ForeColor = System.Drawing.Color.White;
            this.yellowLabel.Location = new System.Drawing.Point(67, 385);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(100, 23);
            this.yellowLabel.TabIndex = 6;
            this.yellowLabel.Text = "Straight";
            // 
            // sceneImage
            // 
            this.sceneImage.BackgroundImage = global::AdventureGame.Properties.Resources.IMG_1255;
            this.sceneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sceneImage.Location = new System.Drawing.Point(12, 86);
            this.sceneImage.Margin = new System.Windows.Forms.Padding(0);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(362, 212);
            this.sceneImage.TabIndex = 7;
            this.sceneImage.TabStop = false;
            // 
            // yellowImage
            // 
            this.yellowImage.Image = global::AdventureGame.Properties.Resources.yellow_50x50;
            this.yellowImage.Location = new System.Drawing.Point(24, 375);
            this.yellowImage.Margin = new System.Windows.Forms.Padding(2);
            this.yellowImage.Name = "yellowImage";
            this.yellowImage.Size = new System.Drawing.Size(39, 32);
            this.yellowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowImage.TabIndex = 5;
            this.yellowImage.TabStop = false;
            // 
            // blueImage
            // 
            this.blueImage.Image = global::AdventureGame.Properties.Resources.blue_50x50;
            this.blueImage.Location = new System.Drawing.Point(24, 339);
            this.blueImage.Margin = new System.Windows.Forms.Padding(2);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(39, 32);
            this.blueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueImage.TabIndex = 1;
            this.blueImage.TabStop = false;
            // 
            // redImage
            // 
            this.redImage.Image = global::AdventureGame.Properties.Resources.red_50x50;
            this.redImage.Location = new System.Drawing.Point(24, 303);
            this.redImage.Margin = new System.Windows.Forms.Padding(2);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(39, 32);
            this.redImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redImage.TabIndex = 0;
            this.redImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(386, 422);
            this.Controls.Add(this.sceneImage);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.yellowImage);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.redImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Building Escape";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redImage;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox yellowImage;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.PictureBox sceneImage;
    }
}

