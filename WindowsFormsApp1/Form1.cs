using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int movement = 10;

            System.Diagnostics.Debug.WriteLine(player.Left.ToString());

            if (keyData == Keys.Up)
            {
                if (player.Top < -player.Height +25)
                    player.Top = this.Height - player.Height + 25;
                else
                    player.Top = player.Top -movement;

            }
            if (keyData == Keys.Left)
            {
                if (player.Left < -50)
                    player.Left = this.Width;
                else
                    player.Left = player.Left -movement;

            }
            if (keyData == Keys.Right)
            {
                if (player.Left > 580)
                    player.Left = -50;
                else
                    player.Left = player.Left +movement;
            }
            if (keyData == Keys.Down)
            {
                if (player.Top > this.Height -player.Height +17 )
                    player.Top = -player.Height;
                else
                    player.Top = player.Top +movement;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            MoveMeteorit(meteorit1,5);
            MoveMeteorit(meteorit2,3);
            MoveMeteorit(meteorit3,6);


        }

        private void MoveMeteorit(PictureBox pictureBox,int speed)
        {
            if (pictureBox.Top > this.Height - pictureBox.Height + 17)
                pictureBox.Top = -pictureBox.Height;
            else
                pictureBox.Top = pictureBox.Top +speed;



        }
    
    
    FDHBUIIIIPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPABDCNAIOBXNVCIOABDUIFCBAOSDBCYUAD
    
    
    }

}
