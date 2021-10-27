using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021Student.model
{
    public class Studerende:Person
    {

        /*
         * Instance Fields  -- attributter
         *
         * ALTID Private 
         */
        //private string _navn; -- findes i person
        //private string _adresse; -- findes i person
        private int _tlf;
        private string _email;
        private int _semester;

        private Computer _computer; // svarer tit streg mellem Studerende og Computer

        /*
         * Properties - gør attributter tilgængelige udenfor klasssen
         *
         * ALTID Public
         */

        /*
         * Findes i Person (navn + adresse
         */
        //public string Navn
        //{
        //    get { return _navn; }
        //    set { _navn = value;  }
        //}

        
        //public string Adresse
        //{
        //    get { return _adresse; }
        //    set { _adresse = value; }
        //}

        // ... ligeså for tlf og email

        public int Semester
        {
            get { return _semester; }
        }

        public Computer Computer
        {
            get { return _computer; }
            set { _computer = value; }
        }

        /*
         * Konstruktør  - kaldes nå et nyt objekt laves
         * benyttes til at tildele nye værdier
         *
         *
         * INGEN returværdi - NAVN = KLASSENAVN
         */
        public Studerende(): base("peter", "vejnavn")
        {
            // standard værdier
            //_navn = "Peter";
            //_adresse = "vejnavn";
            _tlf = 12345678;
            _email = "peter@dummymail.dk";
            _semester = 0;

            _computer = null;
        }



        /*
         * METODE
         */
        public void BeståetSemester()
        {
            _semester = _semester + 1;
        }









    }
}
