using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CoolestFlashCardAppEver
{
    public partial class fCustomize : Form
    {
        public fCustomize()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fCustomize_Load(object sender, EventArgs e)
        {
            txbBackColor1.Text = fCards.backColor1.ToString();
            txbBackColor2.Text = fCards.backColor2.ToString();
            txbBackColor3.Text = fCards.backColor3.ToString();
            txbEngColor1.Text = fCards.engColor1.ToString();
            txbEngColor2.Text = fCards.engColor2.ToString();
            txbEngColor3.Text = fCards.engColor3.ToString();
            txbViColor1.Text = fCards.viColor1.ToString();
            txbViColor2.Text = fCards.viColor2.ToString();
            txbViColor3.Text = fCards.viColor3.ToString();
            txbTime.Text = fCards.timedigit.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            fCards.backColor1 = Int32.Parse(txbBackColor1.Text);
            fCards.backColor2 = Int32.Parse(txbBackColor2.Text);
            fCards.backColor3 = Int32.Parse(txbBackColor3.Text);
            fCards.engColor1 = Int32.Parse(txbEngColor1.Text);
            fCards.engColor2 = Int32.Parse(txbEngColor2.Text);
            fCards.engColor3 = Int32.Parse(txbEngColor3.Text);
            fCards.viColor1 = Int32.Parse(txbViColor1.Text);
            fCards.viColor2 = Int32.Parse(txbViColor2.Text);
            fCards.viColor3 = Int32.Parse(txbViColor3.Text);
            fCards.timedigit = Int32.Parse(txbTime.Text);
    
 
            using (StreamWriter writer = new StreamWriter("config.txt"))
            {
                writer.WriteLine("StartPosition: " + fCards.startPostion1.ToString() + " " + fCards.startPostion2.ToString());
                writer.WriteLine("Back: " + fCards.backColor1.ToString() + " " + fCards.backColor2.ToString() + " " + fCards.backColor3.ToString());
                writer.WriteLine("Eng: " + fCards.engColor1.ToString() + " " + fCards.engColor2.ToString() + " " + fCards.engColor3.ToString());
                writer.WriteLine("Vi: "+ fCards.viColor1.ToString() + " " + fCards.viColor2.ToString() + " " + fCards.viColor3.ToString());
                writer.WriteLine("Time: " + fCards.timedigit.ToString());
            }
           
            this.Close();
        }
    }
}
