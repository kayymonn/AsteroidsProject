﻿namespace WindowsFormsApp1
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
            this.meteorit3 = new System.Windows.Forms.PictureBox();
            this.meteorit2 = new System.Windows.Forms.PictureBox();
            this.meteorit1 = new System.Windows.Forms.PictureBox();
            this.lblCollisionCounter = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
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
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.player.ForeColor = System.Drawing.Color.Black;
            this.player.Image = global::WindowsFormsApp1.Properties.Resources.Player;
            this.player.Location = new System.Drawing.Point(370, 377);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(98, 105);
            this.player.TabIndex = 0;
            this.player.UseVisualStyleBackColor = false;
            // 
            // meteorit3
            // 
            this.meteorit3.Image = global::WindowsFormsApp1.Properties.Resources.Asteroid_03;
            this.meteorit3.Location = new System.Drawing.Point(114, 12);
            this.meteorit3.Name = "meteorit3";
            this.meteorit3.Size = new System.Drawing.Size(110, 89);
            this.meteorit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteorit3.TabIndex = 3;
            this.meteorit3.TabStop = false;
            this.meteorit3.Tag = 2;
            // 
            // meteorit2
            // 
            this.meteorit2.Image = global::WindowsFormsApp1.Properties.Resources.Asteroid_02;
            this.meteorit2.Location = new System.Drawing.Point(652, 12);
            this.meteorit2.Name = "meteorit2";
            this.meteorit2.Size = new System.Drawing.Size(110, 89);
            this.meteorit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteorit2.TabIndex = 2;
            this.meteorit2.TabStop = false;
            this.meteorit2.Tag = 2;
            // 
            // meteorit1
            // 
            this.meteorit1.Image = global::WindowsFormsApp1.Properties.Resources.Asteroid_01;
            this.meteorit1.Location = new System.Drawing.Point(380, 12);
            this.meteorit1.Name = "meteorit1";
            this.meteorit1.Size = new System.Drawing.Size(110, 89);
            this.meteorit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteorit1.TabIndex = 1;
            this.meteorit1.TabStop = false;
            this.meteorit1.Tag = 2;
            // 
            // lblCollisionCounter
            // 
            this.lblCollisionCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCollisionCounter.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblCollisionCounter.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollisionCounter.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCollisionCounter.Location = new System.Drawing.Point(728, 9);
            this.lblCollisionCounter.Name = "lblCollisionCounter";
            this.lblCollisionCounter.Size = new System.Drawing.Size(148, 39);
            this.lblCollisionCounter.TabIndex = 4;
            this.lblCollisionCounter.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblTime.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTime.Location = new System.Drawing.Point(728, 59);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(148, 29);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(879, 566);
            this.ControlBox = false;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCollisionCounter);
            this.Controls.Add(this.meteorit3);
            this.Controls.Add(this.meteorit2);
            this.Controls.Add(this.meteorit1);
            this.Controls.Add(this.player);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.KeyPreview = true;
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
        private System.Windows.Forms.Label lblCollisionCounter;
        private System.Windows.Forms.Label lblTime;
    }
}

