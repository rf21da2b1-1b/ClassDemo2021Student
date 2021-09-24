using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDemo2021Student.model;

namespace ClassDemo2021Student
{
    public class InsertCodeHere
    {

        public void Run()
        {
            Studerende studerende1 = new Studerende();
            studerende1.Navn = "Oliver";


            Studerende studerende2 = new Studerende();
            studerende2.Navn = "Jonathan";
            studerende2.Adresse = "Greve";
            studerende2.BeståetSemester();

            Console.WriteLine($"Studerende 1 {studerende1.Navn} adresse {studerende1.Adresse} semester {studerende1.Semester}");
            Console.WriteLine($"Studerende 2 {studerende2.Navn} adresse {studerende2.Adresse} semester {studerende2.Semester}");

        }
    }
}
