using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cssbs_ex13
{
    class HQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public string[] FalseAs { get; set; }
        public HQuestion(string Q, string A, string[] FalseAs)
        {
            this.Question = Q;
            this.Answer = A;
            this.FalseAs = FalseAs;
        }
        public override string ToString()
        {
            var strB = new StringBuilder($"{Question}\n");
            var Answers = new List<string>();
            Answers.Add(Answer);
            foreach (string s in FalseAs)
                Answers.Add(s);
            Answers.Shuffle();
            foreach (string s in Answers)
            {
                strB.Append($" - {s}\n");
            }
            return strB.ToString();
        }
    }
}
