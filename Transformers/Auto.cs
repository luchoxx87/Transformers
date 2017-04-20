namespace Transformers
{

    public class Auto : TransformacionVehiculo
    {
        public override int Velocidad(Transformer transformer)
        {
            return transformer.PesoBase * 2;
        }

        public override int Peso(Transformer transformer)
        {
            return transformer.PesoBase / 2;
        }
        public static Transformer dameTransformer(Bando bando, string nombre, int peso, int poderDestructivo, int velocidad)
        {
            return new Transformer(bando, nombre, peso, poderDestructivo,
                                   new Auto().dameUnaTrasformacionSeteadaParaMi() , velocidad);
        }
    }
}