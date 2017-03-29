using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentClassDemo
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Major { get; set; }
        private List<int> scores = new List<int>();

        public List<int> scoreS
        {
            get { return scores; }
            set
            {
                bool bValid = true;
                foreach (int score in value)
                {
                    if (score < 0 || score > 100)
                    {
                        bValid = bValid && false;
                    }
                }
                if (bValid) {
                    scores = value;
                    Calc();
                }
                else
                {
                    throw (new Exception("Invalid score."));
                }

            }
        }
        //private int score1;
        //public int Score1
        //{
        //    get { return score1; }
        //    set
        //    {
        //        score1 = value;
        //        Calc();
        //    }
        //}
        //private int score2;
        //public int Score2
        //{
        //    get { return score2; }
        //    set
        //    {
        //        score2 = value;
        //        Calc();
        //    }
        //}
        //private int score3;
        //public int Score3
        //{
        //    get { return score3; }
        //    set
        //    {
        //        score3 = value;
        //        Calc();
        //    }
        //}
        //private int average;

        public int Average { get; private set; }
        private void Calc()
        {
            //average = (Score1 + Score2 + Score3) / 3;
            int sum = 0;
            for (int i = 0; i < scores.Count; ++i)
            {
                sum = sum + scores[i];
            }
            Average = sum / scores.Count;
        }




        //public string GetMajor()
        //{
        //    return major;
        //}

        //public void SetMajor(string newMajor)
        //{
        //    if (major != "Underwater Basketweaving")
        //    {
        //        this.major = newMajor;
        //    }


    }
}
