using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TrussMe.TrussCreator;

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



        void DrawBridge()
        {
            //drawing the tester
            //width of screen is 16.25 + 1.75 * 2 inches
            float scale = bitBox.Width / 19.75f;

            float supportWidth = 1.75f * scale;
            float supportHeight = 0.5f * scale;
            gfx.Clear(Color.AliceBlue);
            gfx.FillRectangle(Brushes.DarkGray, new Rectangle(0, bitBox.Height - (int)supportHeight, (int)supportWidth, (int)supportHeight));
            gfx.FillRectangle(Brushes.DarkGray, new Rectangle(bitBox.Width - (int)supportWidth, bitBox.Height - (int)supportHeight, (int)supportWidth, (int)supportHeight));

            for (int i = 0; i < 20; i++)
            {
                gfx.FillRectangle(Brushes.Black, new Rectangle((int)(scale * i), bitBox.Height - 20, 5, 20));
            }

            List<Member> members = new List<Member>();
            members.AddRange(createArch((float)archHeightBox.Value, scale, supportWidth, supportHeight));


            foreach (var member in members)
            {
                gfx.DrawLine(new Pen(Color.Black, 3), member.Start, member.End);
            }

            bitBox.Image = map;
        }

        private List<Member> createArch(float height, float scale, float supportWidth, float supportHeight)
        {
            TrussType archType = (TrussType)archTrussBox.SelectedIndex;
            int archWebs = (int)archWebBox.Value;

            List<Member> bottomArch = new List<Member>();

            float startX = supportWidth;
            float startY = bitBox.Height;

            float xOriginal = bitBox.Width / 2;
            float yOriginal = (int)(-(scale * height) + (xOriginal * xOriginal) / (height * scale) / 2);

            float radius = (float)Math.Sqrt(Math.Pow(startX - xOriginal, 2) + Math.Pow(startY - yOriginal, 2));
            float chordLength = 2 * (bitBox.Width - supportWidth);
            float vertexAngle = (float)Math.Asin(chordLength / (2 * radius));

            //measured in radians
            // pi/2 - the angle of the chord start (sin-1[c/(2r)])
            float currentAngle = (1/2f) * (float)Math.PI - vertexAngle;
            ;

            Point lastPoint = new Point((int)(scale * 1.75f), bitBox.Height);
            for (int i = 1; i < archWebs + 1; i++)
            {
                //int x = (int)(scale * ((16.25f / (archWebs + 1) * i) + 1.75f));
                //Point nextPoint = new Point(x, -((int)Math.Sqrt((radius * radius) - Math.Pow(x - xOriginal, 2)) - (int)yOriginal));

                currentAngle += vertexAngle / (float)(archWebs + 1);
                Point nextPoint = new Point((int)(-radius * Math.Cos(currentAngle) + xOriginal), (int)(-radius * Math.Sin(currentAngle) + yOriginal));

                bottomArch.Add(new Member(lastPoint, nextPoint));
                lastPoint = nextPoint;
            }
            bottomArch.Add(new Member(lastPoint, new Point(bitBox.Width - (int)(scale * 1.75f), bitBox.Height)));

            int currentLength = bottomArch.Count();

            List<Member> topArch = new List<Member>();
            for (int i = 0; i < currentLength; i++)
            {
                Member member = bottomArch[i];
                topArch.Add(new Member(member.Start.X, member.Start.Y - (int)supportHeight, member.End.X, (int)(member.End.Y - supportHeight)));
            }


            return TrussCreator.CreateTruss(topArch, bottomArch, archType, (int)archExtraBox.Value);
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

        private void archExtraBox_ValueChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }
    }
}
