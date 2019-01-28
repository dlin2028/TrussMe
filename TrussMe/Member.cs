using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrussMe
{
    class Member
    {
        public Point Start;
        public Point End;

        public Member(Point start)
            : this(start.X, start.Y)
        {

        }
        public Member(int startX, int startY)
            :this(startX, startY, -1, -1)
        {

        }
        public Member(int startX, int startY, int endX, int endY)
        {
            Start = new Point(startX, startY);
            End = new Point(endX, endY);
        }
        public Member(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public List<Member> AddBisector(Point end)
        {
            Point middle = new Point((Start.X + End.X)/2, (Start.Y + End.Y) / 2);
            return new List<Member>()
            {
                new Member(Start, middle),
                new Member(middle, end),
                new Member(middle, End)
            };
        }
    }
}
