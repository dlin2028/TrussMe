using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrussMe
{
    static class TrussCreator
    {
        public enum TrussType { Howe, Warren, Pratt, KTruss };

        public static List<Member> CreateTruss(List<Member> top, List<Member> bottom, TrussType trussType, int extraMembers)
        {
            if (top.Count < extraMembers * 2)
            {
                extraMembers = 0;
            }

            if (trussType == TrussType.Pratt)
            {
                return pratt(top, bottom, extraMembers);
            }
            else if(trussType == TrussType.Warren)
            {
                return warren(top, bottom, extraMembers);
            }
            else if (trussType == TrussType.Howe)
            {
                return howe(top, bottom, extraMembers);
            }
            else if (trussType == TrussType.KTruss)
            {
                return kTruss(top, bottom, extraMembers);
            }
            else
            {
                return new List<Member>();
                //throw new NotImplementedException();
            }
        }

        private static List<Member> howe(List<Member> top, List<Member> bottom, int extraMembers)
        {
            List<Member> output = new List<Member>();

            //add the vertical members
            output.Add(new Member(top[0].Start, bottom[0].Start));
            for (int i = 0; i < top.Count; i++)
            {
                output.Add(new Member(top[i].End, bottom[i].End));
            }

            //add the diagonal members
            for (int i = 0; i < (top.Count + 1) / 2 + extraMembers; i++)
            {
                //left
                output.Add(new Member(bottom[i].Start, top[i].End));
            }
            for (int i = top.Count / 2 - extraMembers; i < top.Count; i++)
            {
                //right
                output.Add(new Member(bottom[i].End, top[i].Start));
            }

            output.AddRange(top);
            output.AddRange(bottom);
            return output;
        }

        private static List<Member> warren(List<Member> top, List<Member> bottom, int extraMembers)
        {
            List<Member> output = new List<Member>();

            //add the diagonal members
            for (int i = 0; i < top.Count; i++)
            {
                if(i % 2 == 0)
                {
                    //up
                    output.Add(new Member(bottom[i].Start, top[i].End));
                }
                else
                {
                    //down
                    output.Add(new Member(bottom[i].End, top[i].Start));
                }
            }

            if(extraMembers > 0 && top.Count > 2)
            {
                //add the diagonal members
                for (int i = 0; i < (top.Count + 1) / 2 + extraMembers; i++)
                {
                    //left
                    output.Add(new Member(bottom[i].Start, top[i].Start));
                }
                for (int i = top.Count / 2 - extraMembers; i < top.Count; i++)
                {
                    //right
                    output.Add(new Member(bottom[i].End, top[i].End));
                }
            }
            
            output.AddRange(top);
            output.AddRange(bottom);
            return output;
        }

        private static List<Member> pratt(List<Member> top, List<Member> bottom, int extraMembers)
        {
            List<Member> output = new List<Member>();

            //add the vertical members
            output.Add(new Member(top[0].Start, bottom[0].Start));
            for (int i = 0; i < top.Count; i++)
            {
                output.Add(new Member(top[i].End, bottom[i].End));
            }

            //add the diagonal members
            for (int i = 0; i < (top.Count + 1) / 2 + extraMembers; i++)
            {
                //left
                output.Add(new Member(bottom[i].End, top[i].Start));
            }
            for (int i = top.Count / 2 - extraMembers; i < top.Count; i++)
            {
                //right
                output.Add(new Member(bottom[i].Start, top[i].End));
            }

            output.AddRange(top);
            output.AddRange(bottom);
            return output;
        }

        private static List<Member> kTruss(List<Member> top, List<Member> bottom, int extraMembers)
        {
            List<Member> output = new List<Member>();
            List<Member> verticals = new List<Member>();

            //add the vertical members
            verticals.Add(new Member(top[0].Start, bottom[0].Start));
            for (int i = 0; i < top.Count; i++)
            {
                verticals.Add(new Member(top[i].End, bottom[i].End));
            }

            if(top.Count > 0)
            {
                //add the diagonal members
                for (int i = 1; i < (verticals.Count + 2) / 2; i++)
                {
                    //left
                    output.AddRange(verticals[i].AddBisector(verticals[i - 1].Start));
                    output.AddRange(verticals[i].AddBisector(verticals[i - 1].End));
                }
                for (int i = (verticals.Count - 1) / 2; i < verticals.Count - 1; i++)
                {
                    //right
                    output.AddRange(verticals[i].AddBisector(verticals[i + 1].Start));
                    output.AddRange(verticals[i].AddBisector(verticals[i + 1].End));
                }
            }

            output.AddRange(top);
            output.AddRange(bottom);
            output.AddRange(verticals);
            return output;
        }
    }
}
