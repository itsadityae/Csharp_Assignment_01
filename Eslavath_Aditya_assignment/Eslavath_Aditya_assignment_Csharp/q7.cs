using System;
using System.Collections.Generic;
using System.Text;

namespace Eslavath_Aditya_assignment_Csharp
{
    class Candidate
    {
        public string Name;
        public DateTime BirthDate;
        public string Email;
        public string Contact;
        public char Gender;

        public void Display()
        {
            Console.WriteLine(Name + " " + BirthDate.ToShortDateString() + " " + Email + " " + Contact + " " + Gender);
        }
    }

    class Manager
    {
        List<Candidate> candidates = new List<Candidate>();

        public Manager()
        {
            candidates.Add(new Candidate { Name = "Aditya", BirthDate = new DateTime(1998, 3, 15), Email = "anita@mail.com", Contact = "987654321", Gender = 'F' });
            candidates.Add(new Candidate { Name = "Ravi", BirthDate = new DateTime(1995, 12, 10), Email = "ravi@mail.com", Contact = "9876535342", Gender = 'M' });
            candidates.Add(new Candidate { Name = "Sita", BirthDate = new DateTime(1996, 7, 20), Email = "sita@mail.com", Contact = "997654321", Gender = 'F' });
            candidates.Add(new Candidate { Name = "Amit", BirthDate = new DateTime(2000, 3, 5), Email = "amit@mail.com", Contact = "9887654321", Gender = 'M' });
            candidates.Add(new Candidate { Name = "Neha", BirthDate = new DateTime(1999, 12, 25), Email = "neha@mail.com", Contact = "987666325", Gender = 'F' });
        }

        public void BornInMarch()
        {
            foreach (Candidate c in candidates)
                if (c.BirthDate.Month == 3)
                    c.Display();
        }

        public void BornBefore1997()
        {
            foreach (Candidate c in candidates)
                if (c.BirthDate.Year < 1997)
                    c.Display();
        }

        public void FemaleCandidates()
        {
            foreach (Candidate c in candidates)
                if (c.Gender == 'F')
                    c.Display();
        }

        public void CountBornInDecember()
        {
            int count = 0;
            foreach (Candidate c in candidates)
                if (c.BirthDate.Month == 12)
                    count++;
            Console.WriteLine("Born in December: " + count);
        }
    }

    internal class q7
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();

            Console.WriteLine("Born in March:");
            m.BornInMarch();

            Console.WriteLine("Born before 1997:");
            m.BornBefore1997();

            Console.WriteLine("Female candidates:");
            m.FemaleCandidates();

            m.CountBornInDecember();
        }
    }
}
