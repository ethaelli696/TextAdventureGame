using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAdventureGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int scene;
        //keypress inputs
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                errorBox.Text = "";
                //red button (negative)
                switch (scene)
                {
                    case 1:
                        //scratch the curtains
                        scene = 2;
                        break;
                    case 2:
                        //norma
                        scene = 3;
                        break;
                    case 4:
                        //no screw petunia
                        scene = 5;
                        break;
                    case 7:
                        //naw b
                        scene = 9;
                        break;
                    case 9:
                        //no dont attack petunia
                        scene = 11;
                        break;
                    case 11:
                        //go it alone - dont join the feral cats
                        scene = 24;
                        break;
                    case 24:
                        //no
                        scene = 23;
                        break;
                    case 15:
                        //dont eat the mouse
                        scene = 17;
                        //insert scene here
                        //then go to scene 18 (death)
                        break;
                    case 18:
                        //no dont knock over petunias stew
                        scene = 19;
                        break;
                    case 19:
                        //dont eat the petunias
                        scene = 22;
                        break;
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                errorBox.Text = "";
                switch (scene)
                {
                    case 1:
                        //Go back to sleep
                        scene = 7;
                        break;
                    case 2:
                        //Five year old Timpothy 
                        scene = 4;
                        break;
                    case 4:
                        //Go back 
                        scene = 6;
                        break;
                    case 7:
                        //Eat the treat
                        scene = 8;
                        break;
                    case 9:
                        //Attack 
                        scene = 10;
                        break;
                    case 11:
                        //join the feral cats
                        scene = 26;
                        break;
                    case 15:
                        //eat the mouse 
                        scene = 16;
                        break;
                    case 18:
                        //stew is spilled
                        scene = 20;
                        break;
                    case 24:
                        //Fight the dog
                        scene = 13;
                        break;
                    default:
                        scene = 1;
                        break;
                }
            }
            else if (e.KeyCode == Keys.B) //blue button
            {
                errorBox.Text = "";
                switch (scene)
                {
                    case 1:
                        //hunt
                        scene = 15;
                        break;
                }

            }
            else if (e.KeyCode == Keys.N) //yellow button
            {
                errorBox.Text = "";
                switch (scene)
                {
                    case 1:
                        //Make as much noise as you can
                        scene = 14;
                        break;
                }
            }
            else
            {
                errorBox.Text = "Please use the controls on the left side of the arcade cabinet.";
            }

            //new switch statement to build the scene

            //another switch statement that displays all scene info
        }
        // build the scenes here
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
