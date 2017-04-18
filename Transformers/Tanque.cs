namespace Transformers
{
    public class Tanque : Transformer
    {

        public Tanque(Bando unBando, string unNombre, int unaVelocidad, int unPeso, int unPoderDestructivo)
            : base(unBando, unNombre, unaVelocidad, unPeso, unPoderDestructivo)
        { }
        public override int Velocidad()
        {
            return this.Transformado() ? base.Velocidad() / 2 : base.Velocidad();
        }

        public override int PoderDestructivo()
        {
            return this.Transformado() ? base.PoderDestructivo() * 2 : base.PoderDestructivo();
        }

    }
}