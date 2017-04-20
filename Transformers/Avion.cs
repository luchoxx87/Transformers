namespace Transformers
{
    public class Avion : TransformacionVehiculo
    {

        public override int Velocidad(Transformer transformer)
        {
            return transformer.VelocidadBase * 2;
        }

        public override int PoderDestructivo(Transformer transformer)
        {
            return transformer.PoderDestructivoBase / 2;
        }
        public static Transformer dameTransformer(Bando bando, string nombre, int peso, int poderDestructivo, int velocidad)
        {
            return new Transformer(bando, nombre, peso, poderDestructivo,
                                   new Avion().dameUnaTrasformacionSeteadaParaMi(), velocidad);
        }
    }
}
