using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Figura
    {
        public virtual string Dibujar()
        {
            return "Dibujando forma";
        }

        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();
    }

    public class Rectangulo : Figura
    {
        public float lado1;
        public float lado2;

        public Rectangulo(float lado1, float lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }


        public override string Dibujar()
        {
            return "Dibujando rectangulo";
        }

        public override double CalcularSuperficie()
        {
            return lado1 * lado2;
        }

        public override double CalcularPerimetro()
        {
            return (lado1 * 2) + (lado2 * 2);
        }
    }

    public sealed class Circulo : Figura
    {
        float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando circulo";
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return Math.Pow(Math.PI, 2) * radio;
        }
    }

    public sealed class Cuadrado : Rectangulo
    {

        public Cuadrado(float lado) : base(lado, lado) { }

        public override string Dibujar()
        {
            return "Dibujando cuadrado";
        }

        public override double CalcularSuperficie()
        {
            return lado1 * lado2;
        }

        public override double CalcularPerimetro()
        {
            return (lado1 * 2) + (lado2 * 2);
        }
    }

}
