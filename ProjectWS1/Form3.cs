using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWS1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            int move = 0, moveX = 0, moveY = 0;
            panelTop.MouseDown += (s, e) => { move = 1; moveX = e.X; moveY = e.Y; };
            panelTop.MouseDown += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY); };
            panelTop.MouseUp += (s, e) => { move = 0; };

            btn_close.Click += (s, e) => { Close(); };
        }
    }
}
