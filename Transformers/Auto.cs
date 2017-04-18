namespace Transformers
{

    public class Auto : Transformer
    {

        public Auto(Bando unBando, string unNombre, int unaVelocidad, int unPeso, int unPoderDestructivo)
            : base(unBando, unNombre, unaVelocidad, unPeso, unPoderDestructivo)
        { }
        public override int Velocidad()
        {
            int velocidad = base.Velocidad();
            if (this.Transformado())
            {
                velocidad *= 2;
            }
            return velocidad;
        }

        public override int Peso()
        {
            int peso = base.Peso();
            return this.Transformado() ? peso / 2 : peso;
        }
    }
}