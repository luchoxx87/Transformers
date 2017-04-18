namespace Transformers
{
    public interface IRobot
    {

        string Nombre();

        int Velocidad();

        int PoderDestructivo();

        int Peso();

        Bando Bando();
    }
}