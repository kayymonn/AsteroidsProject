using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {

        uint Counter = 0;
        uint MaxCollisions = 3;
        PictureBox LastCollisionMeteorit = null;
        DateTime StartTime = DateTime.Now;
        int SpeedPlus = 0;

        public Form1()
        {
            InitializeComponent();
         
            PrepareStart();
           
        }

        private void PrepareStart()
        {
            Counter = 0;
            MaxCollisions = 3;
            LastCollisionMeteorit = null;
            StartTime = DateTime.Now;
            timer1.Start();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Keyboard.IsKeyDown(Key.Up))
                Proccess(Keys.Up);
            if (Keyboard.IsKeyDown(Key.Down))
                Proccess(Keys.Down);
            if (Keyboard.IsKeyDown(Key.Left))
                Proccess(Keys.Left);
            if (Keyboard.IsKeyDown(Key.Right))
                Proccess(Keys.Right);

            int newSpeed = random1.Next(1, 6);

            MoveMeteorit(meteorit1);
            MoveMeteorit(meteorit2);
            MoveMeteorit(meteorit3);

            CheckSettings();

            CheckCollisions();

            //print out time
            TimeSpan timeOffset = (DateTime.Now - StartTime);
            lblTime.Text = timeOffset.ToString();

            SpeedPlus = (int) (timeOffset.TotalSeconds / 4d);

        }

        private void CheckSettings()
        {
            if (Keyboard.IsKeyDown(Key.P))
            {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Maximized;
                    Thread.Sleep(100);
                }
                else
                {
                    WindowState = FormWindowState.Normal;
                    Thread.Sleep(100);
                }
            }
        }
        private void Proccess (Keys keyData)
        {
            int movement = 10;

            System.Diagnostics.Debug.WriteLine(player.Left.ToString());

            if (keyData == Keys.Up)
            {
                if (player.Top < -player.Height + 25)
                    player.Top = this.Height - player.Height + 25;
                else
                    player.Top = player.Top - movement;

            }
            if (keyData == Keys.Left)
            {
                if (player.Left < -50)
                    player.Left = this.Width;
                else
                    player.Left = player.Left - movement;

            }
            if (keyData == Keys.Right)
            {
                if (player.Left > this.Width )
                    player.Left = -50;
                else
                    player.Left = player.Left + movement;
            }
            if (keyData == Keys.Down)
            {
                if (player.Top > this.Height - player.Height + 17)
                    player.Top = -player.Height;
                else
                    player.Top = player.Top + movement;
            }
        }

        private Random random = new Random();

        private Random random1 = new Random();

        private void MoveMeteorit(PictureBox pictureBox)
        {
            int maxY = this.Height - pictureBox.Height + 17;
            if (pictureBox.Top > maxY)
            {
                int newX = random.Next(this.Width - pictureBox.Width);
                int newSpeed = random1.Next(1 + SpeedPlus, 6 + SpeedPlus);
                pictureBox.Location = new Point(newX, -pictureBox.Height);
                pictureBox.Tag = newSpeed;
            }
            else
            {
                int speed = Convert.ToInt32(pictureBox.Tag);
                pictureBox.Top += speed;
            }
            
        }

        private void CheckCollisions()
        {
            PictureBox foundmeteorit = FindCollidingObject();

            // collision positive
            if (foundmeteorit != null)
            {
                if (LastCollisionMeteorit == null)
                {
                    Counter = Counter + 1;
                    lblCollisionCounter.Text = Counter.ToString();
                    LastCollisionMeteorit = foundmeteorit;
                } 

            }
            // collision negative
            else
            {
                LastCollisionMeteorit = null;
            }

            // check max collision limit
            if (Counter>=MaxCollisions)
            {
                timer1.Stop();
                if (MessageBox.Show(this, "Game Over", "", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                   PrepareStart();
                }
            }
        }

        private PictureBox FindCollidingObject()
        {
            if (player.Bounds.IntersectsWith(meteorit1.Bounds))
                return meteorit1;
            if (player.Bounds.IntersectsWith(meteorit2.Bounds))
                return meteorit2;
            if (player.Bounds.IntersectsWith(meteorit3.Bounds))
                return meteorit3;

            return null;
        }

    }
}
