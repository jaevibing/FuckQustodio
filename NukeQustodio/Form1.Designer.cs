namespace NukeQustodio
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
            this.nuke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nuke
            // 
            this.nuke.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuke.Location = new System.Drawing.Point(147, 199);
            this.nuke.Name = "nuke";
            this.nuke.Size = new System.Drawing.Size(111, 42);
            this.nuke.TabIndex = 0;
            this.nuke.Text = "NUKE";
            this.nuke.UseVisualStyleBackColor = true;
            this.nuke.Click += new System.EventHandler(this.nuke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(399, 269);
            this.Controls.Add(this.nuke);
            this.Name = "Form1";
            this.Text = "NukeQustodio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nuke;
    }
}

