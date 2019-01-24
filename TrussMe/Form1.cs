using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrussMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics gfx;
        Bitmap map;

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(bitBox.Width, bitBox.Height);
            gfx = Graphics.FromImage(map);

            DrawBridge();
        }

        enum TrussType { Howe, Howe2, Warren, Pratt, Pratt2, Childs, Childs2 };


        void DrawBridge()
        {
            //drawing the tester
            //width of screen is 16.25 + 1.75 * 2 inches
            float scale = bitBox.Width / 19.75f;

            int supportWidth = (int)(1.75f * scale);
            int supportHeight = (int)(0.5f * scale);
            gfx.Clear(Color.AliceBlue);
            gfx.FillRectangle(Brushes.DarkGray, new Rectangle(0, bitBox.Height - supportHeight, supportWidth, supportHeight));
            gfx.FillRectangle(Brushes.DarkGray, new Rectangle(bitBox.Width - supportWidth, bitBox.Height - supportHeight, supportWidth, supportHeight));

            for (int i = 0; i < 20; i++)
            {
                gfx.FillRectangle(Brushes.Black, new Rectangle((int)(scale * i), bitBox.Height - 20, 5, 20));
            }


            TrussType archType = (TrussType)archTrussBox.SelectedIndex;
            float archHeight = (float)archHeightBox.Value;
            int archWebs = (int)archWebBox.Value;

            List<Member> members = new List<Member>();
            if (archType == TrussType.Howe)
            {
                float xOriginal = bitBox.Width / 2;
                float yOriginal = (int)((scale * archHeight) - (xOriginal * xOriginal) / (archHeight * scale) / 2);
                int radius = (int)Math.Sqrt(xOriginal * xOriginal + yOriginal * yOriginal);

                Point lastPoint = new Point((int)(scale * 1.75f), bitBox.Height);
                for (int i = 1; i < archWebs + 1; i++)
                {
                    int x = (int)(scale * 16.25f / archWebs) * i;
                    Point nextPoint = new Point(x, radius - (int)Math.Sqrt((radius * radius) - (x * x)));
                    members.Add(new Member(lastPoint, nextPoint));
                    lastPoint = nextPoint;
                }
                members.Add(new Member(lastPoint, new Point(bitBox.Width - (int)(scale * 1.75f), bitBox.Height)));
            }

            foreach (var member in members)
            {
                gfx.DrawLine(new Pen(Color.Black, 3), member.Start, member.End);
            }

            bitBox.Image = map;
        }


        private void archTrussBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }

        private void archHeightBox_ValueChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }

        private void archWebBox_ValueChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }
    }
}
