using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PuzzleGameWorking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalImage.Image = Properties.Resources.King;

            pictureBox1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
            pictureBox3.BackColor = Color.Gray;
            pictureBox4.BackColor = Color.Gray;
            pictureBox5.BackColor = Color.Gray;
            pictureBox6.BackColor = Color.Gray;
            pictureBox7.BackColor = Color.Gray;
            pictureBox8.BackColor = Color.Gray;
            pictureBox9.BackColor = Color.Gray;
            pictureBox10.BackColor = Color.Gray;
            pictureBox11.BackColor = Color.Gray;
            pictureBox12.BackColor = Color.Gray;
            pictureBox13.BackColor = Color.Gray;
            pictureBox14.BackColor = Color.Gray;
            pictureBox15.BackColor = Color.Gray;
            pictureBox16.BackColor = Color.White;

            // Image Shuffle;

            /*pictureBox1.Image = Properties.Resources.image_part_006;
            pictureBox2.Image = Properties.Resources.image_part_009;
            pictureBox3.Image = Properties.Resources.image_part_012;
            pictureBox4.Image = Properties.Resources.image_part_015;
            pictureBox5.Image = Properties.Resources.image_part_001;
            pictureBox6.Image = Properties.Resources.image_part_004;
            pictureBox7.Image = Properties.Resources.image_part_007;
            pictureBox8.Image = Properties.Resources.image_part_010;
            pictureBox9.Image = Properties.Resources.image_part_013;
            pictureBox10.Image = Properties.Resources.image_part_002;
            pictureBox11.Image = Properties.Resources.image_part_005;                      
            pictureBox12.Image = Properties.Resources.image_part_008;
            pictureBox13.Image = Properties.Resources.image_part_011;
            pictureBox14.Image = Properties.Resources.image_part_014;
            pictureBox15.Image = Properties.Resources.image_part_003;
            pictureBox16.Image = Properties.Resources.image_part_000;*/

            //Images in Order

            pictureBox1.Image = Properties.Resources.image_part_001;
            pictureBox2.Image = Properties.Resources.image_part_002;
            pictureBox3.Image = Properties.Resources.image_part_003;
            pictureBox4.Image = Properties.Resources.image_part_004;
            pictureBox5.Image = Properties.Resources.image_part_005;
            pictureBox6.Image = Properties.Resources.image_part_006;
            pictureBox7.Image = Properties.Resources.image_part_007;
            pictureBox8.Image = Properties.Resources.image_part_008;
            pictureBox9.Image = Properties.Resources.image_part_009;
            pictureBox10.Image = Properties.Resources.image_part_010;
            pictureBox11.Image = Properties.Resources.image_part_011;
            pictureBox12.Image = Properties.Resources.image_part_012;
            pictureBox13.Image = Properties.Resources.image_part_013;
            pictureBox14.Image = Properties.Resources.image_part_014;
            pictureBox15.Image = Properties.Resources.image_part_015;
            pictureBox16.Image = Properties.Resources.image_part_000;

            // Give Tags to Picture Boxes for Comparing purposes(see checkWin Function)

            pictureBox1.Tag = "A";
            pictureBox2.Tag = "B";
            pictureBox3.Tag = "C";
            pictureBox4.Tag = "D";
            pictureBox5.Tag = "E";
            pictureBox6.Tag = "F";
            pictureBox7.Tag = "G";
            pictureBox8.Tag = "H";
            pictureBox9.Tag = "I";
            pictureBox10.Tag = "J";
            pictureBox11.Tag = "K";
            pictureBox12.Tag = "L";
            pictureBox13.Tag = "M";
            pictureBox14.Tag = "N";
            pictureBox15.Tag = "O";
            pictureBox16.Tag = "P";
        }

        //Handle The movement of each image by checking its neighbours. 
        //If there is posibility of movement then swap arount the tags and images of those two neighbuoring picture boxes
        //At every click check to see if the player has completed the game

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox1.Image = Properties.Resources.image_part_000;
                pictureBox1.BackColor = Color.White;
                string aux = pictureBox1.Tag.ToString();
                pictureBox1.Tag = pictureBox2.Tag;
                pictureBox2.Tag = aux;
            }
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox1.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox1.Image = Properties.Resources.image_part_000;
                pictureBox1.BackColor = Color.White;
                string aux = pictureBox1.Tag.ToString();
                pictureBox1.Tag = pictureBox5.Tag;
                pictureBox5.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox2.Image;
                pictureBox1.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources.image_part_000;
                pictureBox2.BackColor = Color.White;
                string aux = pictureBox2.Tag.ToString();
                pictureBox2.Tag = pictureBox1.Tag;
                pictureBox1.Tag = aux;
            }
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox2.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources.image_part_000;
                pictureBox2.BackColor = Color.White;
                string aux = pictureBox2.Tag.ToString();
                pictureBox2.Tag = pictureBox3.Tag;
                pictureBox3.Tag = aux;
            }
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox2.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources.image_part_000;
                pictureBox2.BackColor = Color.White;
                string aux = pictureBox2.Tag.ToString();
                pictureBox2.Tag = pictureBox6.Tag;
                pictureBox6.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox3.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox3.Image = Properties.Resources.image_part_000;
                pictureBox3.BackColor = Color.White;
                string aux = pictureBox3.Tag.ToString();
                pictureBox3.Tag = pictureBox2.Tag;
                pictureBox2.Tag = aux;
            }
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox3.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox3.Image = Properties.Resources.image_part_000;
                pictureBox3.BackColor = Color.White;
                string aux = pictureBox3.Tag.ToString();
                pictureBox3.Tag = pictureBox4.Tag;
                pictureBox4.Tag = aux;
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox3.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox3.Image = Properties.Resources.image_part_000;
                pictureBox3.BackColor = Color.White;
                string aux = pictureBox3.Tag.ToString();
                pictureBox3.Tag = pictureBox7.Tag;
                pictureBox7.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox4.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources.image_part_000;
                pictureBox4.BackColor = Color.White;
                string aux = pictureBox4.Tag.ToString();
                pictureBox4.Tag = pictureBox3.Tag;
                pictureBox3.Tag = aux;
            }
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox4.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources.image_part_000;
                pictureBox4.BackColor = Color.White;
                string aux = pictureBox4.Tag.ToString();
                pictureBox4.Tag = pictureBox8.Tag;
                pictureBox8.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox5.Image;
                pictureBox1.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources.image_part_000;
                pictureBox5.BackColor = Color.White;
                string aux = pictureBox5.Tag.ToString();
                pictureBox5.Tag = pictureBox1.Tag;
                pictureBox1.Tag = aux;
            }
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox5.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources.image_part_000;
                pictureBox5.BackColor = Color.White;
                string aux = pictureBox5.Tag.ToString();
                pictureBox5.Tag = pictureBox6.Tag;
                pictureBox6.Tag = aux;
            }
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox5.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources.image_part_000;
                pictureBox5.BackColor = Color.White;
                string aux = pictureBox5.Tag.ToString();
                pictureBox5.Tag = pictureBox9.Tag;
                pictureBox9.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox6.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources.image_part_000;
                pictureBox6.BackColor = Color.White;
                string aux = pictureBox6.Tag.ToString();
                pictureBox6.Tag = pictureBox2.Tag;
                pictureBox2.Tag = aux;
            }
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox6.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources.image_part_000;
                pictureBox6.BackColor = Color.White;
                string aux = pictureBox6.Tag.ToString();
                pictureBox6.Tag = pictureBox5.Tag;
                pictureBox5.Tag = aux;
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox6.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources.image_part_000;
                pictureBox6.BackColor = Color.White;
                string aux = pictureBox6.Tag.ToString();
                pictureBox6.Tag = pictureBox7.Tag;
                pictureBox7.Tag = aux;
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.Image = pictureBox6.Image;
                pictureBox10.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources.image_part_000;
                pictureBox6.BackColor = Color.White;
                string aux = pictureBox6.Tag.ToString();
                pictureBox6.Tag = pictureBox10.Tag;
                pictureBox10.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox7.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources.image_part_000;
                pictureBox7.BackColor = Color.White;
                string aux = pictureBox7.Tag.ToString();
                pictureBox7.Tag = pictureBox3.Tag;
                pictureBox3.Tag = aux;
            }
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox7.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources.image_part_000;
                pictureBox7.BackColor = Color.White;
                string aux = pictureBox7.Tag.ToString();
                pictureBox7.Tag = pictureBox6.Tag;
                pictureBox6.Tag = aux;
            }
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox7.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources.image_part_000;
                pictureBox7.BackColor = Color.White;
                string aux = pictureBox7.Tag.ToString();
                pictureBox7.Tag = pictureBox8.Tag;
                pictureBox8.Tag = aux;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.Image = pictureBox7.Image;
                pictureBox11.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources.image_part_000;
                pictureBox7.BackColor = Color.White;
                string aux = pictureBox7.Tag.ToString();
                pictureBox7.Tag = pictureBox11.Tag;
                pictureBox11.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox8.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources.image_part_000;
                pictureBox8.BackColor = Color.White;
                string aux = pictureBox8.Tag.ToString();
                pictureBox8.Tag = pictureBox4.Tag;
                pictureBox4.Tag = aux;
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox8.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources.image_part_000;
                pictureBox8.BackColor = Color.White;
                string aux = pictureBox8.Tag.ToString();
                pictureBox8.Tag = pictureBox7.Tag;
                pictureBox7.Tag = aux;
            }
            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.Image = pictureBox8.Image;
                pictureBox12.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources.image_part_000;
                pictureBox8.BackColor = Color.White;
                string aux = pictureBox8.Tag.ToString();
                pictureBox8.Tag = pictureBox12.Tag;
                pictureBox12.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox9.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources.image_part_000;
                pictureBox9.BackColor = Color.White;
                string aux = pictureBox9.Tag.ToString();
                pictureBox9.Tag = pictureBox5.Tag;
                pictureBox5.Tag = aux;
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.Image = pictureBox9.Image;
                pictureBox10.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources.image_part_000;
                pictureBox9.BackColor = Color.White;
                string aux = pictureBox9.Tag.ToString();
                pictureBox9.Tag = pictureBox10.Tag;
                pictureBox10.Tag = aux;
            }
            if (pictureBox13.BackColor == Color.White)
            {
                pictureBox13.Image = pictureBox9.Image;
                pictureBox13.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources.image_part_000;
                pictureBox9.BackColor = Color.White;
                string aux = pictureBox9.Tag.ToString();
                pictureBox9.Tag = pictureBox13.Tag;
                pictureBox13.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox10.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox10.Image = Properties.Resources.image_part_000;
                pictureBox10.BackColor = Color.White;
                string aux = pictureBox10.Tag.ToString();
                pictureBox10.Tag = pictureBox6.Tag;
                pictureBox6.Tag = aux;
            }
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox10.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox10.Image = Properties.Resources.image_part_000;
                pictureBox10.BackColor = Color.White;
                string aux = pictureBox10.Tag.ToString();
                pictureBox10.Tag = pictureBox9.Tag;
                pictureBox9.Tag = aux;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.Image = pictureBox10.Image;
                pictureBox11.BackColor = Color.Gray;
                pictureBox10.Image = Properties.Resources.image_part_000;
                pictureBox10.BackColor = Color.White;
                string aux = pictureBox10.Tag.ToString();
                pictureBox10.Tag = pictureBox11.Tag;
                pictureBox11.Tag = aux;
            }
            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.Image = pictureBox10.Image;
                pictureBox14.BackColor = Color.Gray;
                pictureBox10.Image = Properties.Resources.image_part_000;
                pictureBox10.BackColor = Color.White;
                string aux = pictureBox10.Tag.ToString();
                pictureBox10.Tag = pictureBox14.Tag;
                pictureBox14.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox11.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources.image_part_000;
                pictureBox11.BackColor = Color.White;
                string aux = pictureBox11.Tag.ToString();
                pictureBox11.Tag = pictureBox7.Tag;
                pictureBox7.Tag = aux;
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.Image = pictureBox11.Image;
                pictureBox10.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources.image_part_000;
                pictureBox11.BackColor = Color.White;
                string aux = pictureBox11.Tag.ToString();
                pictureBox11.Tag = pictureBox10.Tag;
                pictureBox10.Tag = aux;
            }
            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.Image = pictureBox11.Image;
                pictureBox12.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources.image_part_000;
                pictureBox11.BackColor = Color.White;
                string aux = pictureBox11.Tag.ToString();
                pictureBox11.Tag = pictureBox12.Tag;
                pictureBox12.Tag = aux;
            }
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.Image = pictureBox11.Image;
                pictureBox15.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources.image_part_000;
                pictureBox11.BackColor = Color.White;
                string aux = pictureBox11.Tag.ToString();
                pictureBox11.Tag = pictureBox15.Tag;
                pictureBox15.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox12.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox12.Image = Properties.Resources.image_part_000;
                pictureBox12.BackColor = Color.White;
                string aux = pictureBox12.Tag.ToString();
                pictureBox12.Tag = pictureBox8.Tag;
                pictureBox8.Tag = aux;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.Image = pictureBox12.Image;
                pictureBox11.BackColor = Color.Gray;
                pictureBox12.Image = Properties.Resources.image_part_000;
                pictureBox12.BackColor = Color.White;
                string aux = pictureBox12.Tag.ToString();
                pictureBox12.Tag = pictureBox11.Tag;
                pictureBox11.Tag = aux;
            }
            if (pictureBox16.BackColor == Color.White)
            {
                pictureBox16.Image = pictureBox12.Image;
                pictureBox16.BackColor = Color.Gray;
                pictureBox12.Image = Properties.Resources.image_part_000;
                pictureBox12.BackColor = Color.White;
                string aux = pictureBox12.Tag.ToString();
                pictureBox12.Tag = pictureBox16.Tag;
                pictureBox16.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox13.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox13.Image = Properties.Resources.image_part_000;
                pictureBox13.BackColor = Color.White;
                string aux = pictureBox13.Tag.ToString();
                pictureBox13.Tag = pictureBox9.Tag;
                pictureBox9.Tag = aux;
            }
            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.Image = pictureBox13.Image;
                pictureBox14.BackColor = Color.Gray;
                pictureBox13.Image = Properties.Resources.image_part_000;
                pictureBox13.BackColor = Color.White;
                string aux = pictureBox13.Tag.ToString();
                pictureBox13.Tag = pictureBox14.Tag;
                pictureBox14.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.Image = pictureBox14.Image;
                pictureBox10.BackColor = Color.Gray;
                pictureBox14.Image = Properties.Resources.image_part_000;
                pictureBox14.BackColor = Color.White;
                string aux = pictureBox14.Tag.ToString();
                pictureBox14.Tag = pictureBox10.Tag;
                pictureBox10.Tag = aux;
            }
            if (pictureBox13.BackColor == Color.White)
            {
                pictureBox13.Image = pictureBox14.Image;
                pictureBox13.BackColor = Color.Gray;
                pictureBox14.Image = Properties.Resources.image_part_000;
                pictureBox14.BackColor = Color.White;
                string aux = pictureBox14.Tag.ToString();
                pictureBox14.Tag = pictureBox13.Tag;
                pictureBox13.Tag = aux;
            }
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.Image = pictureBox14.Image;
                pictureBox15.BackColor = Color.Gray;
                pictureBox14.Image = Properties.Resources.image_part_000;
                pictureBox14.BackColor = Color.White;
                string aux = pictureBox14.Tag.ToString();
                pictureBox14.Tag = pictureBox15.Tag;
                pictureBox15.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.Image = pictureBox15.Image;
                pictureBox11.BackColor = Color.Gray;
                pictureBox15.Image = Properties.Resources.image_part_000;
                pictureBox15.BackColor = Color.White;
                string aux = pictureBox15.Tag.ToString();
                pictureBox15.Tag = pictureBox11.Tag;
                pictureBox11.Tag = aux;
            }
            if (pictureBox14.BackColor == Color.White)
            {
                pictureBox14.Image = pictureBox15.Image;
                pictureBox14.BackColor = Color.Gray;
                pictureBox15.Image = Properties.Resources.image_part_000;
                pictureBox15.BackColor = Color.White;
                string aux = pictureBox15.Tag.ToString();
                pictureBox15.Tag = pictureBox14.Tag;
                pictureBox14.Tag = aux;
            }
            if (pictureBox16.BackColor == Color.White)
            {
                pictureBox16.Image = pictureBox15.Image;
                pictureBox16.BackColor = Color.Gray;
                pictureBox15.Image = Properties.Resources.image_part_000;
                pictureBox15.BackColor = Color.White;
                string aux = pictureBox15.Tag.ToString();
                pictureBox15.Tag = pictureBox16.Tag;
                pictureBox16.Tag = aux;
            }
            checkWin();
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.Image = pictureBox16.Image;
                pictureBox12.BackColor = Color.Gray;
                pictureBox16.Image = Properties.Resources.image_part_000;
                pictureBox16.BackColor = Color.White;
                string aux = pictureBox16.Tag.ToString();
                pictureBox16.Tag = pictureBox12.Tag;
                pictureBox12.Tag = aux;
            }
            if (pictureBox15.BackColor == Color.White)
            {
                pictureBox15.Image = pictureBox16.Image;
                pictureBox15.BackColor = Color.Gray;
                pictureBox16.Image = Properties.Resources.image_part_000;
                pictureBox16.BackColor = Color.White;
                string aux = pictureBox16.Tag.ToString();
                pictureBox16.Tag = pictureBox15.Tag;
                pictureBox15.Tag = aux;
            }
            checkWin();
        }
        //Compare the current picture boxes tags with the original picture boxes tags
        //If true, replace the empty image with the last image and display the winning message
        public void checkWin()
        {
            if((pictureBox1.Tag.ToString().Equals("A")) &&
                (pictureBox2.Tag.ToString().Equals("B")) &&
                (pictureBox3.Tag.ToString().Equals("C")) &&
                (pictureBox4.Tag.ToString().Equals("D")) &&
                (pictureBox5.Tag.ToString().Equals("E")) &&
                (pictureBox6.Tag.ToString().Equals("F")) &&
                (pictureBox7.Tag.ToString().Equals("G")) &&
                (pictureBox8.Tag.ToString().Equals("H")) &&
                (pictureBox9.Tag.ToString().Equals("I")) &&
                (pictureBox10.Tag.ToString().Equals("J")) &&
                (pictureBox11.Tag.ToString().Equals("K")) &&
                (pictureBox12.Tag.ToString().Equals("L")) &&
                (pictureBox13.Tag.ToString().Equals("M")) &&
                (pictureBox14.Tag.ToString().Equals("N")) &&
                (pictureBox15.Tag.ToString().Equals("O")))
            {
                pictureBox16.BackColor = Color.Gray;
                pictureBox16.Image = Properties.Resources.image_part_016;
                MessageBox.Show("Congratulations! You have won!", "Win");
            }
        }
    }
}
