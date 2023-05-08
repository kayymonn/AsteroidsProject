using System;
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

        public Form1()
        {
            InitializeComponent();

            timer1.Start(); 
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            return base.ProcessCmdKey(ref msg, keyData);
        }
            private void timer1_Tick(object sender, EventArgs e)
        {

            if (Keyboard.IsKeyDown(Key.Up))
                Proccess (Keys.Up);
            if (Keyboard.IsKeyDown(Key.Down))
                Proccess(Keys.Down);
            if (Keyboard.IsKeyDown(Key.Left))
                Proccess(Keys.Left);
            if (Keyboard.IsKeyDown(Key.Right))
                Proccess(Keys.Right);

            MoveMeteorit(meteorit1,5);
            MoveMeteorit(meteorit2,3);
            MoveMeteorit(meteorit3,6);

            CheckCollisions();
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
                if (player.Left > 580)
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

        private void MoveMeteorit(PictureBox pictureBox,int speed)
        {
            if (pictureBox.Top > this.Height - pictureBox.Height + 17)
                pictureBox.Top = -pictureBox.Height;
            else
                pictureBox.Top = pictureBox.Top +speed;



        }
        private void CheckCollisions()
        {
            if (player.Bounds.IntersectsWith(meteorit1.Bounds))
            {
                Console.WriteLine("GameOver");
            }
            
            if (player.Bounds.IntersectsWith(meteorit2.Bounds))
            {
                Console.WriteLine("GameOver");
            }
            
            if (player.Bounds.IntersectsWith(meteorit3.Bounds))
            {
                Console.WriteLine("GameOver");
            }
        }
    
    
    }

}
