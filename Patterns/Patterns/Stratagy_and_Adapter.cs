using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    interface IReader
    {
        string Erorr(string er);
    }

    class Reader
    {
        private IReader reader;
        public Reader(IReader reader) => this.reader = reader;
        public void SetStrategy(IReader reder) => this.reader = reder;
        public string read(string er) => reader.Erorr(er);
    }
    class UkrReader : IReader
    {
        public string Erorr(string er) => er = "Помилка";

    }
    class EngReader
    {
        public string ReturnErorr(string er) => er = "Erorr";
    }
    class Adapter : IReader
    {
        EngReader eng;
        public Adapter(EngReader eng) : base() { this.eng = eng; }
        public string Erorr(string er)
        {
            return eng.ReturnErorr(er);
        }
    }
}
