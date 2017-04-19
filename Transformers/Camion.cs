namespace Transformers
{
    public class Camion : TransformacionVehiculo
    {
        public override int PoderDestructivo(Transformer transformer)
        {
            return base.PoderDestructivo(transformer) * 2;
        }
        public override int Peso(Transformer transformer)
        {
            return base.Peso(transformer) * 2;
        }        
        public override string ToString()
        {
            return "Camion";
        }

    }
}