using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021Student.model
{
    public class Computer
    {

        /*
         * Attributter
         */

        /*
         * Instans Felter
         */

        private String _fabrikat;
        private String _beskrivelse;
        private String _model;


        /*
         * Properties
         */

        public String Fabrikat
        {
            get { return _fabrikat; }
            set { _fabrikat = value; }
        }

        public String Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public String Model
        {
            get { return _model; }
            set { _model = value; }
        }


        /*
         * Konstruktøre
         */
        public Computer() // default konstruktør
        {
            _fabrikat = "";
            _beskrivelse = "";
            _model = "";
        }

        public Computer(String fabrikat, String beskrivelse, String model) 
        {
            _fabrikat = fabrikat;
            _beskrivelse = beskrivelse;
            _model = model;
        }

        /*
         * Metoder
         */

        // ingen metoder her

        // men vi har ToString
        public override String ToString()
        {
            return $"Computer Fabrikat={_fabrikat} Model={_model} Beskrivelse={_beskrivelse}";
        }
    }
}
