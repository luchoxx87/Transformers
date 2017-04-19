namespace Transformers
{

    public class Auto : TransformacionVehiculo
    {
        public override int Velocidad(Transformer transformer)
        {
            return base.Velocidad(transformer)*2;
        }

        public override int Peso(Transformer transformer)
        {
            return base.Peso(transformer)/2;
        }
    }
}