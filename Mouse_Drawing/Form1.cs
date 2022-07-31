using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_Drawing
{
    public partial class Form1 : Form
    {
        int x;
        int y;         

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;    
            }
        }       

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button b =  new Button();        
                            
                if (e.X > x && e.Y > y)
                {
                    b.Location = new Point(x, y);                   
                }
                else if (e.X > x && e.Y < y)
                {
                    b.Location = new Point(x, e.Y);
                }
                else if (e.X < x && e.Y < y)
                {
                    b.Location = new Point(e.X, e.Y);
                }
                else
                {
                    b.Location = new Point(e.X, y);
                }          
                  
                b.Size = new Size(Math.Abs(e.X - x), Math.Abs(e.Y - y));
                Controls.Add(b);                    
                            
            }           
        }
    }
}
