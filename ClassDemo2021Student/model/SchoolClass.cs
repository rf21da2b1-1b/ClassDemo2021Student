using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021Student.model
{
    class SchoolClass
    {
        private string _name;
        private string _classRoom;

        private List<Studerende> _students;

        public SchoolClass()
        {
            _students = new List<Studerende>();
        }

        public SchoolClass(string name, string classRoom)
        {
            _name = name;
            _classRoom = classRoom;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string ClassRoom
        {
            get => _classRoom;
            set => _classRoom = value;
        }

        public void Add(Studerende item)
        {
            _students.Add(item);
        }

        public void Clear()
        {
            _students.Clear();
        }

        public bool Remove(Studerende item)
        {
            return _students.Remove(item);
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(ClassRoom)}: {ClassRoom}, Students: [{String.Join(',', _students)}]";
        }
    }
}
