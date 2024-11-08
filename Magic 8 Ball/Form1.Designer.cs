namespace Magic_8_Ball
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
            this.magicButton = new System.Windows.Forms.Button();
            this.magicOutput = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // magicButton
            // 
            this.magicButton.BackColor = System.Drawing.Color.Transparent;
            this.magicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton.FlatAppearance.BorderSize = 0;
            this.magicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.magicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.magicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magicButton.ForeColor = System.Drawing.Color.Transparent;
            this.magicButton.Location = new System.Drawing.Point(204, 162);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(221, 196);
            this.magicButton.TabIndex = 0;
            this.magicButton.UseVisualStyleBackColor = false;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click_1);
            // 
            // magicOutput
            // 
            this.magicOutput.BackColor = System.Drawing.Color.Transparent;
            this.magicOutput.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicOutput.Location = new System.Drawing.Point(161, 486);
            this.magicOutput.Name = "magicOutput";
            this.magicOutput.Size = new System.Drawing.Size(311, 55);
            this.magicOutput.TabIndex = 1;
            this.magicOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(182, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(290, 50);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Ask a Question..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImage = global::Magic_8_Ball.Properties.Resources.clickBall;
            this.ClientSize = new System.Drawing.Size(635, 550);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.magicOutput);
            this.Controls.Add(this.magicButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Label magicOutput;
        private System.Windows.Forms.Label titleLabel;
    }
}

