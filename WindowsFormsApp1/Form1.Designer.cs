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
            this.CollisionCounter = new System.Windows.Forms.TextBox();
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
            this.player.Location = new System.Drawing.Point(370, 377);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(98, 105);
            this.player.TabIndex = 0;
            this.player.UseVisualStyleBackColor = false;
            // 
            // meteorit3
            // 
            this.meteorit3.Image = global::WindowsFormsApp1.Properties.Resources.donut_PNG93;
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
            this.meteorit2.Image = global::WindowsFormsApp1.Properties.Resources.donut_PNG93;
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
            this.meteorit1.Image = global::WindowsFormsApp1.Properties.Resources.donut_PNG93;
            this.meteorit1.Location = new System.Drawing.Point(380, 12);
            this.meteorit1.Name = "meteorit1";
            this.meteorit1.Size = new System.Drawing.Size(110, 89);
            this.meteorit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meteorit1.TabIndex = 1;
            this.meteorit1.TabStop = false;
            this.meteorit1.Tag = 2;
            // 
            // CollisionCounter
            // 
            this.CollisionCounter.BackColor = System.Drawing.SystemColors.InfoText;
            this.CollisionCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CollisionCounter.ForeColor = System.Drawing.SystemColors.Window;
            this.CollisionCounter.Location = new System.Drawing.Point(719, 535);
            this.CollisionCounter.Name = "CollisionCounter";
            this.CollisionCounter.ReadOnly = true;
            this.CollisionCounter.Size = new System.Drawing.Size(148, 19);
            this.CollisionCounter.TabIndex = 4;
            this.CollisionCounter.Text = "000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(879, 566);
            this.ControlBox = false;
            this.Controls.Add(this.CollisionCounter);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox meteorit3;
        private System.Windows.Forms.PictureBox meteorit2;
        private System.Windows.Forms.PictureBox meteorit1;
        private System.Windows.Forms.TextBox CollisionCounter;
    }
}

