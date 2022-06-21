using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    interface ICircle
    {
        double Inc(double percent);
        double Red(double percent);
        double AboutRadius();
        double AppendRadius(double percent);
        string Clength();
        string Carea();
        string diameter();
        string Sarea();

    }
    class Ratio : ICircle
    {
        public double radius;
        public string name;
        public Ratio() => radius = 0;
        public double AboutRadius() => radius;
        public void AppendRadius(double percent) => radius = percent;
        private Ratio(Ratio donor) => this.radius = donor.radius;
        public string Clength()
        {
            string str = " ";
            str = (radius * 2).ToString() + "П";
            return str;
        }
        public string Carea()
        {
            string str = " ";
            str = Math.Pow(radius, 2).ToString() + "П";
            return str;
        }
        public string diameter()
        {
            string str = " ";
            str = (radius * 2).ToString();
            return str;
        }
        public string Sarea()
        {
            string str = " ";
            str = (Math.Pow(radius, 2) / 2).ToString();
            return str;
        }

        public ICircle Clone() => new Ratio(this); // Prototype


    }
    interface IBuilder
    {
        Ratio Build();
    }
    class Builder : IBuilder
    {
        private double radius;
        private string name;
        public Builder SetRadius(double radius)
        {
            this.radius = radius;
            return this;
        }
        public Builder SetName(string name)
        {
            this.name = name;
            return this;
        }
        public Ratio Build()
        {
            Ratio ratio = new Ratio();
            ratio.name = name;
            ratio.radius = radius;

            return ratio;
        }
    }
}
