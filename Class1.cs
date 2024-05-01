using System.Text;

namespace Clases
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string destino, string origen)
        {
            this.duracion = duracion;
            this.nroOrigen = origen;
            this.nroDestino = destino;
        }

        public float Duracion { get => this.duracion; }
        public string Destino { get => this.nroDestino; }
        public string Origen { get => this.nroOrigen; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.duracion.ToString());
            sb.AppendLine(this.nroDestino);
            sb.AppendLine(this.nroOrigen);

            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return 1;
        }

    }


    public class Local : Llamada
    {
        float costo;
        
        public Local(string origen, float duracion, string destino, float costo): base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo): this(llamada.Destino, llamada.Duracion, llamada.Origen, costo) { }


        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        public float CostoLlamada
        {
            get => CalcularCosto();
        }

        public string Mostrar()
        {
            string infoBase = base.Mostrar();
            StringBuilder sb = new StringBuilder(infoBase);
            sb.AppendLine(this.costo.ToString());

            return sb.ToString();
        }

    }


    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja1 = 99,
            Franja2 = 125,
            Franja3 = 66,
        }

        Franja franja;

        public Provincial(string origen, Franja miFranja, float duracion, string destino): base(duracion, destino, origen)
        {
            this.franja = franja;
        }

        public Provincial(Franja franja, Llamada llamada): this(llamada.Origen, franja, llamada.Duracion, llamada.Destino) { }


        public string Mostar()
        {
            string infoBase = base.Mostrar();
            StringBuilder sb = new StringBuilder(infoBase);
            sb.AppendLine(franja.ToString());
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.duracion * Convert.ToSingle(this.franja);
        }

    }

}
