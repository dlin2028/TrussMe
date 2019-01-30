using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            members.AddRange(createDeck(bitBox.Height - ((float)archHeightBox.Value + (float)deckHeightBox.Value - 0.5f) * scale, scale, supportWidth, supportHeight));
            members.AddRange(createSpandrels(bitBox.Height - ((float)archHeightBox.Value + (float)deckHeightBox.Value - 0.5f) * scale, (float)archHeightBox.Value, scale, supportWidth, supportHeight));

            foreach (var member in members)
            {
                gfx.DrawLine(new Pen(Color.Black, 3), member.Start, member.End);
            }

            bitBox.Image = map;

            saveFile(members, scale);
        }

        struct Joint
        {
            public decimal X;
            public decimal Y;

            public Joint(decimal x, decimal y)
            {
                X = x;
                Y = y;
            }
        }

        private void saveFile(List<Member> members, float scale)
        {
            List<string> lines = File.ReadAllLines(@"C:\Users\Bobbapus\Desktop\dum.txt").ToList();
            List<Joint> uniqueJoints = new List<Joint>();
            List<Member> uniqueMembers = new List<Member>();
            foreach (var member in members)
            {
                Joint startPoint = new Joint(RoundToNearestEith(member.Start.X/ scale), RoundToNearestEith(member.Start.Y / scale));
                Joint endPoint = new Joint(RoundToNearestEith(member.End.X / scale), RoundToNearestEith(member.End.Y / scale));

                if (uniqueJoints.Where(x => startPoint.X == x.X && startPoint.Y == x.Y).Count() == 0)
                {
                    uniqueJoints.Add(startPoint);
                }
                if (uniqueJoints.Where(x => endPoint.X == x.X && endPoint.Y == x.Y).Count() == 0)
                {
                    uniqueJoints.Add(endPoint);
                }
            }

            List<string> jointLines = new List<string>();
            for (int i = 0; i < uniqueJoints.Count; i++)
            {
                jointLines.Add(i.ToString() + " "
                    + uniqueJoints[i].X.ToString("0.000000") + " "
                    + uniqueJoints[i].Y.ToString("0.000000") + " "
                    + "4.000000" + " 0 0 0 0 0 0 0 0");
                //z position is 4


                jointLines.Add(i.ToString() + " "
                    + uniqueJoints[i].X.ToString("0.000000") + " "
                    + uniqueJoints[i].Y.ToString("0.000000") + " "
                    + "6.000000" + " 0 0 0 0 0 0 0 0");
                //z position is 6
            }

            List<string> memberLines = new List<string>();
            for (int i = 0; i < members.Count; i++)
            {
                int start = uniqueJoints.IndexOf(
                    uniqueJoints.FirstOrDefault(joint =>
                        joint.X == RoundToNearestEith(members[i].Start.X/scale)
                        && joint.Y == RoundToNearestEith(members[i].Start.Y/scale)));
                int end = uniqueJoints.IndexOf(
                    uniqueJoints.FirstOrDefault(joint =>
                        joint.X == RoundToNearestEith(members[i].End.X / scale)
                        && joint.Y == RoundToNearestEith( members[i].End.Y /scale)));

                string length = Math.Sqrt(start * start + end * end).ToString("X.000000");

                memberLines.Add(i.ToString() + " " + start + " " + end + " " + length + " " + length + " 0 0 0.000000 0.000000 2 4 0 0.000000 1 1 1 1 1 0.741200 0.651000");
            }
            lines.InsertRange(3, memberLines);
            lines.InsertRange(3, jointLines);

            File.WriteAllLines(@"C:\Users\Bobbapus\Desktop\smrt.txt", lines);
        }
        public decimal RoundToNearestEith(float value)
        {
            return Math.Round((decimal)value * 8) / 8;
        }

        private List<Member> createSpandrels(float deckHeight, float archHeight, float scale, float supportWidth, float supportHeight)
        {
            //deck part
            List<Member> bottomDeck = new List<Member>();

            int deckWebs = (int)spandrelWebBox.Value;
            Point lastPoint = new Point((int)(scale * 1.75f), (int)(deckHeight));
            for (int i = 1; i < deckWebs + 1; i++)
            {
                int x = (int)(scale * ((16.25f / (deckWebs + 1) * i) + 1.75f));
                Point nextPoint = new Point(x, (int)deckHeight);

                bottomDeck.Add(new Member(lastPoint, nextPoint));
                lastPoint = nextPoint;
            }
            bottomDeck.Add(new Member(lastPoint, new Point(bitBox.Width - (int)(scale * 1.75f), (int)deckHeight)));

            List<Member> topDeck = new List<Member>();
            int currentLength = bottomDeck.Count();
            for (int i = 0; i < currentLength; i++)
            {
                Member member = bottomDeck[i];
                topDeck.Add(new Member(member.Start.X, member.Start.Y - (int)supportHeight, member.End.X, (int)(member.End.Y - supportHeight)));
            }
            //arch parts

            TrussType archType = (TrussType)archTrussBox.SelectedIndex;
            int archWebs = (int)spandrelWebBox.Value;

            List<Member> bottomArch = new List<Member>();

            float startX = supportWidth;
            float startY = bitBox.Height;

            float xOriginal = bitBox.Width / 2;
            float yOriginal = (int)(-(scale * archHeight) + (xOriginal * xOriginal) / (archHeight * scale) / 2);

            float radius = (float)Math.Sqrt(Math.Pow(startX - xOriginal, 2) + Math.Pow(startY - yOriginal, 2));
            float chordLength = (bitBox.Width - supportWidth * 2);
            float vertexAngle = 2 * (float)Math.Asin(chordLength / (2 * radius));

            //measured in radians
            // pi/2 - the angle of the chord start (sin-1[c/(2r)])
            float currentAngle = (1 / 2f) * (float)Math.PI - vertexAngle / 2;
            ;

            lastPoint = new Point((int)(scale * 1.75f), bitBox.Height);
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

            currentLength = bottomArch.Count();

            List<Member> topArch = new List<Member>();
            for (int i = 0; i < currentLength; i++)
            {
                Member member = bottomArch[i];
                topArch.Add(new Member(member.Start.X, member.Start.Y - (int)supportHeight, member.End.X, (int)(member.End.Y - supportHeight)));
            }

            return TrussCreator.CreateTruss(bottomDeck, topArch, (TrussType)spandrelTrussBox.SelectedIndex, 0);
        }

        private List<Member> createDeck(float height, float scale, float supportWidth, float supportHeight)
        {
            List<Member> bottomMembers = new List<Member>();

            int deckWebs = (int)deckWebBox.Value;
            Point lastPoint = new Point((int)(scale * 1.75f),(int)(height));
            for (int i = 1; i < deckWebs + 1; i++)
            {
                int x = (int)(scale * ((16.25f / (deckWebs + 1) * i) + 1.75f));
                Point nextPoint = new Point(x, (int)height);

                bottomMembers.Add(new Member(lastPoint, nextPoint));
                lastPoint = nextPoint;
            }
            bottomMembers.Add(new Member(lastPoint, new Point(bitBox.Width - (int)(scale * 1.75f), (int)height)));

            List<Member> topDeck = new List<Member>();
            int currentLength = bottomMembers.Count();
            for (int i = 0; i < currentLength; i++)
            {
                Member member = bottomMembers[i];
                topDeck.Add(new Member(member.Start.X, member.Start.Y - (int)supportHeight, member.End.X, (int)(member.End.Y - supportHeight)));
            }
            return CreateTruss(bottomMembers, topDeck, (TrussType)deckTrussBox.SelectedIndex, (int)extraDeckMembers.Value);
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
            float chordLength = (bitBox.Width - supportWidth * 2);
            float vertexAngle = 2 * (float)Math.Asin(chordLength / (2 * radius));

            //measured in radians
            // pi/2 - the angle of the chord start (sin-1[c/(2r)])
            float currentAngle = (1/2f) * (float)Math.PI - vertexAngle/2;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void deckHeightBox_ValueChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }

        private void deckTrussBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }

        private void deckWebBox_ValueChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }

        private void thiccBox_ValueChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }

        private void extraDeckMembers_ValueChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }

        private void spandrelTrussBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }

        private void spandrelWebBox_ValueChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }

        private void spandrelExtraMembers_ValueChanged(object sender, EventArgs e)
        {
            DrawBridge();
        }
    }
}
