namespace Transformers
{
    public class Tanque : TransformacionVehiculo
    {
        public override int Velocidad(Transformer transformer)
        {
            return base.Velocidad(transformer) / 2;
        }

        public override int PoderDestructivo(Transformer transformer)
        {
            return base.PoderDestructivo(transformer) * 2;
        }
        
    }
}