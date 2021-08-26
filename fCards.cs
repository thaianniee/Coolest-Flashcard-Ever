using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolestFlashCardAppEver
{
    public partial class fCards : Form
    {
        public static int startPostion1;
        public static int startPostion2;
        public static int backColor1;
        public static int backColor2;
        public static int backColor3;
        public static int engColor1;
        public static int engColor2;
        public static int engColor3;
        public static int viColor1;
        public static int viColor2;
        public static int viColor3;
        public static int timedigit;
        public static bool modified = false;
        public void ConfigurationFlashCard()
        {
            try
            {
                string[] configLines = System.IO.File.ReadAllLines("config.txt");

                string[] startPosition = configLines[0].Split(' ');
                string[] backColor = configLines[1].Split(' ');
                string[] engColor = configLines[2].Split(' ');
                string[] viColor = configLines[3].Split(' ');
                string[] time = configLines[4].Split(' ');

                startPostion1 = Int32.Parse(startPosition[1]);
                startPostion2 = Int32.Parse(startPosition[2]);

                this.Location = new Point(startPostion1, startPostion2);

                backColor1 = Int32.Parse(backColor[1]);
                backColor2 = Int32.Parse(backColor[2]);
                backColor3 = Int32.Parse(backColor[3]);

                this.BackColor = Color.FromArgb(backColor1, backColor2, backColor3);
                this.btClose.BackColor = Color.FromArgb(backColor1, backColor2, backColor3);
                this.btClose.ForeColor = Color.FromArgb(backColor1, backColor2, backColor3);
                this.btCustomize.BackColor = Color.FromArgb(backColor1, backColor2, backColor3);
                this.btCustomize.ForeColor = Color.FromArgb(backColor1, backColor2, backColor3);
                this.btEdit.BackColor = Color.FromArgb(backColor1, backColor2, backColor3);
                this.btEdit.ForeColor = Color.FromArgb(backColor1, backColor2, backColor3);

                engColor1 = Int32.Parse(engColor[1]);
                engColor2 = Int32.Parse(engColor[2]);
                engColor3 = Int32.Parse(engColor[3]);
                this.lblEng.ForeColor = Color.FromArgb(engColor1, engColor2, engColor3);



                viColor1 = Int32.Parse(viColor[1]);
                viColor2 = Int32.Parse(viColor[2]);
                viColor3 = Int32.Parse(viColor[3]);
                this.lblVi.ForeColor = Color.FromArgb(viColor1, viColor2, viColor3);

                timedigit = Int32.Parse(time[1]);
                timer.Interval = (1000) * timedigit;
            }
            catch
            {
                MessageBox.Show("config.txt is not exist!");
                this.Close();
            }


        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,    
            int nTopRect,      
            int nRightRect,    
            int nBottomRect,  
            int nWidthEllipse,
            int nHeightEllipse
        );
        
        static string[] words;
        public void GetData()
        {
            try
            {
                words = System.IO.File.ReadAllLines("data.txt");
                
            }         
             catch
            {
                MessageBox.Show("data.txt is not exist!");
                this.Close();
            }
        }
        public fCards()
        {
            InitializeComponent();          
            ConfigurationFlashCard();
            GetData();
            try
            {
                Random rnd = new Random();
                num = rnd.Next(0, words.Length);
            }
            catch
            {
                num = 0;
            }
            string[] data = words[num].Split(':');
            lblEng.Text = data[0];
            lblVi.Text = data[1];
            lblEng.Left = (this.ClientSize.Width - lblEng.Size.Width) / 2;
            lblVi.Left = (this.ClientSize.Width - lblVi.Size.Width) / 2;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                    
                                                  
        }
        
        static int num;
        void timer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            num = rnd.Next(0, words.Length);
            while (num >= words.Length)
            {                              
                num = rnd.Next(0, words.Length);
            }
            GC.Collect();
            GetData();
            string[] data = words[num].Split(':');
                lblEng.Text = data[0];
                lblVi.Text = data[1];
                lblEng.Left = (this.ClientSize.Width - lblEng.Size.Width) / 2;
                lblVi.Left = (this.ClientSize.Width - lblVi.Size.Width) / 2;
                
                   
        }
        static Timer timer = new Timer();
        private void fCards_Load(object sender, EventArgs e)
        {
             
            this.ShowInTaskbar = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            ShowIcon = false;          
            lblEng.Left = (this.ClientSize.Width - lblEng.Size.Width) / 2;
            lblVi.Left = (this.ClientSize.Width - lblVi.Size.Width) / 2;           
            timer.Tick += new EventHandler(timer_Tick);            
            timer.Enabled = true;
            timer.Start();
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCustomize_Click(object sender, EventArgs e)
        {
            fCustomize f  = new fCustomize();
            f.ShowDialog();
            ConfigurationFlashCard();
               
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", "data.txt");
            }
            catch
            {
                MessageBox.Show("data.txt is not exist!");
            }
        }
    }
}
