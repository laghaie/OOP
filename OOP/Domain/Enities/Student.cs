using OOP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.Enities
{
    internal class Student
    {
        public string Name;
        public string LastName;
        public string NationalId;
        public FeildOfStudy FeildOfStudy;
        public bool Gender;
        public DateOnly DateOfBirth;
        public DateTime YearOfArrival;
        public float Height;
        public List<string> Interest;
        public List<double> Score;

        public Student(string name, string lastName, List<double> score)
        {
            Name = name;
            LastName = lastName;
            Score = score;
        }

        public Student(string name, string lastName, string nationalId)
        {
            Name = name;
            LastName = lastName;
            NationalId = nationalId;
        }

        public double GetAverage()
        {
            var averge = 0.0;
            foreach (var item in Score) {
                averge += item;
            }

            return averge / Score.Count;
        }
    }
}
