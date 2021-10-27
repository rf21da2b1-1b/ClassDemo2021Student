using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021Student.model
{
    public class Person
    {

        private String _navn;
        private String _adresse;

        public Person()
        {
        }

        public Person(string navn, string adresse)
        {
            _navn = navn;
            _adresse = adresse;
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public string Adresse
        {
            get => _adresse;
            set => _adresse = value;
        }

        public override string ToString()
        {
            return $"{nameof(Navn)}: {Navn}, {nameof(Adresse)}: {Adresse}";
        }
    }
}
