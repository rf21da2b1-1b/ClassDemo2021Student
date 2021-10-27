using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ClassDemo2021Student.model;

namespace ClassDemo2021Student
{
    public class InsertCodeHere
    {

        public void Run()
        {
            //Studerende studerende1 = new Studerende();
            //studerende1.Navn = "Oliver";


            //Studerende studerende2 = new Studerende();
            //studerende2.Navn = "Jonathan";
            //studerende2.Adresse = "Greve";
            //studerende2.BeståetSemester();

            //Console.WriteLine($"Studerende 1 {studerende1.Navn} adresse {studerende1.Adresse} semester {studerende1.Semester}");
            //Console.WriteLine($"Studerende 2 {studerende2.Navn} adresse {studerende2.Adresse} semester {studerende2.Semester}");


            //Computer c1 = new Computer();
            //c1.Fabrikat = "HP";
            //c1.Model = "Tja";
            //c1.Beskrivelse = "fin computer med 8 kerner og .....";

            //Console.WriteLine($"Computer {c1.Fabrikat} ....");
            //Console.WriteLine(c1.ToString());
            //Console.WriteLine(c1);

            //Computer c2 = c1;
            //Console.WriteLine(c2);

            //c2.Fabrikat = "Microsoft";
            //Console.WriteLine(c1);

            //Computer c3 = new Computer();
            //c3.Fabrikat = "Apple";

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);

            //Console.WriteLine("Benytter konstruktør MED værdier");
            //Computer c4 = new Computer("Dell", "dette er en beskrivelse", "DellBook");
            //Console.WriteLine(c4);

            //studerende2.Computer = c4;
            //Console.WriteLine($"Studerende {studerende2.Navn} har computeren {studerende2.Computer}");

            List<String> fag = new List<string>(){"SWC", "TEK"};
            Underviser uv = new Underviser("peter", "Roskilde",fag);
            Console.WriteLine(uv);

        }
    }
}
