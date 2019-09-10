using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hot_topic_logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // graphics
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Pen drawPen = new Pen(Color.White);
            Font drawFont = new Font("Thunderbird BT", 16, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            //clear the screen 
            g.Clear(Color.Gray);
            // stuff on screen
            g.FillRectangle(drawBrush, 300, 200, 300, 85);
            g.DrawRectangle(drawPen, 300, 200, 300, 85);

            // code for text
            g.DrawString("HotTopic", drawFont, whiteBrush, 325, 230);
        }
    }
}
