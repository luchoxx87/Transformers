namespace Transformers
{
    public class Camion : Transformer
    {

        public Camion(Bando unBando, string unNombre, int unaVelocidad, int unPeso, int unPoderDestructivo)
            : base(unBando, unNombre, unaVelocidad, unPeso, unPoderDestructivo)
        { }

        public override int PoderDestructivo()
        {
            return this.Transformado() ? base.PoderDestructivo() * 2 : base.PoderDestructivo();
        }

        public override int Peso()
        {
            return this.Transformado() ? base.Peso() * 2 : base.Peso();
        }
    }
}