using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    interface Ilanguage
    {
        string L5();
        string L6();
        string L7();
        string B1();
        string ST();
        string DT();
        string IT();
        string RT();
        string CT();
        string CLT();
    }
    class FactoryUkr : Ilanguage
    {
        public string L5() => "Зміна мови";
        public string L6() => "";
        public string L7() => "-";
        public string B1() => "Масив радіусів";
        public string ST() => "Площа квадрату";
        public string DT() => "Діаметр";
        public string IT() => "Збільшити %";
        public string RT() => "Зменшити %";
        public string CT() => "Площа круга";
        public string CLT() => "Довжина круга";
    }
    class FactoryEng : Ilanguage
    {
        public string L5() => "Language change";
        public string L6() => "-";
        public string L7() => "";
        public string B1() => "Radius array";
        public string ST() => "Square area";
        public string DT() => "Diameter";
        public string IT() => "Increase %";
        public string RT() => "Reduce %";
        public string CT() => "Circle area";
        public string CLT() => "Circle length";
    }

    interface ICreator
    {
        Ilanguage Realize();
    }
    class UkrCreator : ICreator
    {
        public Ilanguage Realize() => new FactoryUkr();
    }
    class EngCreator : ICreator
    {
        public Ilanguage Realize() => new FactoryEng();
    }
}
