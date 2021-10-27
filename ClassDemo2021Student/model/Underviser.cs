using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021Student.model
{
    public class Underviser:Person
    {
        private List<String> _kanUnderviserIfagene;

        public Underviser(string navn, string adresse, List<string> kanUnderviserIfagene) : base(navn, adresse)
        {
            _kanUnderviserIfagene = kanUnderviserIfagene;
        }

        public List<string> KanUnderviserIfagene
        {
            get => _kanUnderviserIfagene;
            set => _kanUnderviserIfagene = value;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(KanUnderviserIfagene)}: {String.Join(',', _kanUnderviserIfagene)}";
        }
    }
}
