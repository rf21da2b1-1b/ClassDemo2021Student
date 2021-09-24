using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021Student.model
{
    public class Studerende
    {

        /*
         * Instance Fields  -- attributter
         *
         * ALTID Private 
         */
        private string _navn;
        private string _adresse;
        private int _tlf;
        private string _email;
        private int _semester;

        /*
         * Properties - gør attributter tilgængelige udenfor klasssen
         *
         * ALTID Public
         */
        public string Navn
        {
            get { return _navn; }
            set { _navn = value;  }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        // ... ligeså for tlf og email

        public int Semester
        {
            get { return _semester; }
        }

        /*
         * Konstruktør  - kaldes nå et nyt objekt laves
         * benyttes til at tildele nye værdier
         *
         *
         * INGEN returværdi - NAVN = KLASSENAVN
         */
        public Studerende()
        {
            // standard værdier
            _navn = "Peter";
            _adresse = "vejnavn";
            _tlf = 12345678;
            _email = "peter@dummymail.dk";
            _semester = 0;
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
