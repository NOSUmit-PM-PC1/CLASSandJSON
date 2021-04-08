using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndJSON
{
    class Subject
    {
        public string Name { get;}
        public int NumberOfHours { get; set; }
        public int Semestr { get; set; }

        public Subject(string name, int numberOfHours, int semestr)
        {
            Name = name;
            NumberOfHours = numberOfHours;
            Semestr = semestr;
        }

        public override string ToString()
        {
            return Name + ": часов " + NumberOfHours + " в семестре " + Semestr;
        }
    }

    class Employee
    {
        static int hourOfStavka = 900;
        static int countofEmployee = 0;
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public double Stavka { get; set; }

        int hour;
        public int HourOfStavka
        {
            set 
            {
                if (value < Stavka * hourOfStavka)
                    hour = value;
                else
                    throw new Exception("Слишком много часов");
            }

            get { return hour; }
        }

        public List<Subject> ListSubjects = new List<Subject>();

        public Employee(string lastName, string firstName, double stavka)
        {
            LastName = lastName;
            FirstName = firstName;
            Stavka = stavka;
        }

        public void AddSubject(Subject s)
        {
            try
            {
                HourOfStavka += s.NumberOfHours;
                ListSubjects.Add(s);
            }
            catch
            {
                Debug.WriteLine("Exception: не удалось добавить предмет, так как слишком много часов ");
            }
        }
    }
}
