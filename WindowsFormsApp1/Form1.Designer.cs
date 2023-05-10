namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.Button();
            this.meteorit3 = new System.Windows.Forms.PictureBox(); meteorit3.Tag = 2;
            this.meteorit2 = new System.Windows.Forms.PictureBox(); meteorit2.Tag = 2;
            this.meteorit1 = new System.Windows.Forms.PictureBox(); meteorit1.Tag = 2;
            ((System.ComponentModel.ISupportInitialize)(this.meteorit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorit1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.ForeColor = System.Drawing.Color.Black;
            this.player.Image = global::WindowsFormsApp1.Properties.Resources.Player;
            this.player.Location = new System.Drawing.Point(247, 245);
            this.player.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(65, 68);
            this.player.TabIndex = 0;
            this.player.UseVisualStyleBackColor = false;
            // 
            // meteorit3
            // 
            this.meteorit3.Image = global::WindowsFormsApp1.Properties.Resources.donut_PNG93;
            this.meteorit3.Location = new System.Drawing.Point(76, 8);
            this.meteorit3.Margin = new System.Windows.Forms.Padding(2);
            this.meteorit3.Name = "meteorit3";
            this.meteorit3.Size = new System.Drawing.Size(73, 58);
            this.meteorit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteorit3.TabIndex = 3;
            this.meteorit3.TabStop = false;
            // 
            // meteorit2
            // 
            this.meteorit2.Image = global::WindowsFormsApp1.Properties.Resources.donut_PNG93;
            this.meteorit2.Location = new System.Drawing.Point(435, 8);
            this.meteorit2.Margin = new System.Windows.Forms.Padding(2);
            this.meteorit2.Name = "meteorit2";
            this.meteorit2.Size = new System.Drawing.Size(73, 58);
            this.meteorit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteorit2.TabIndex = 2;
            this.meteorit2.TabStop = false;
            // 
            // meteorit1
            // 
            this.meteorit1.Image = global::WindowsFormsApp1.Properties.Resources.donut_PNG93;
            this.meteorit1.Location = new System.Drawing.Point(253, 8);
            this.meteorit1.Margin = new System.Windows.Forms.Padding(2);
            this.meteorit1.Name = "meteorit1";
            this.meteorit1.Size = new System.Drawing.Size(73, 58);
            this.meteorit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteorit1.TabIndex = 1;
            this.meteorit1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.ControlBox = false;
            this.Controls.Add(this.meteorit3);
            this.Controls.Add(this.meteorit2);
            this.Controls.Add(this.meteorit1);
            this.Controls.Add(this.player);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DONUT";
            ((System.ComponentModel.ISupportInitialize)(this.meteorit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox meteorit3;
        private System.Windows.Forms.PictureBox meteorit2;
        private System.Windows.Forms.PictureBox meteorit1;
    }
}

