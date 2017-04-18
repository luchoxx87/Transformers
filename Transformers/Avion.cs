namespace Transformers
{
    public class Avion : Transformer
    {

        public Avion(Bando unBando, string unNombre, int unaVelocidad, int unPeso, int unPoderDestructivo)
            : base(unBando, unNombre, unaVelocidad, unPeso, unPoderDestructivo)
        { }

        public override int Velocidad()
        {
            if (this.Transformado())
            {
                return base.Velocidad() * 2;
            }
            else
            {
                return base.Velocidad();
            }
        }

        public override int PoderDestructivo()
        {
            if (this.Transformado())
            {
                return base.PoderDestructivo() / 2;
            }
            else
            {
                return base.PoderDestructivo();
            }
        }
    }
}
