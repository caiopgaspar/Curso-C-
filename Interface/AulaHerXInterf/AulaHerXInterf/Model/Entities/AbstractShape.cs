using AulaHerXInterf.Model.Enums;

namespace AulaHerXInterf.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
