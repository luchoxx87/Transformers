using System;
namespace Transformers
{
    public class Transformer : IRobot
    {

        private Bando bando;
        private string nombre;
        private int velocidad;

        internal int VelocidadBase
        {
            get { return velocidad; }
        }
        private int peso;

        internal int PesoBase
        {
            get { return peso; }
        }
        private int poderDestructivo;

        internal int PoderDestructivoBase
        {
            get { return poderDestructivo; }
        }
        private SuperRobot superRobot;
        private Transformacion transformacion;
        public Transformer(Bando unBando, string unNombre, int unPeso, int unPoderDestructivo, Transformacion unaTransformacion, int unaVelocidad)
        {
            bando = unBando;
            nombre = unNombre;
            velocidad = unaVelocidad;
            peso = unPeso;
            poderDestructivo = unPoderDestructivo;
            transformacion = unaTransformacion;
            superRobot = null;
            bando.AgregarALista(this);
        }

        public Transformacion Transformacion
        {
            get
            {
                return transformacion;
            }
        }

        public Bando Bando1
        {
            get
            {
                return bando;
            }
        }

        public string Nombre()
        {
            return nombre;
        }

        public int Velocidad()
        {
            return transformacion.Velocidad(this);
        }

        public int PoderDestructivo()
        {
            return transformacion.PoderDestructivo(this);
        }

        public int Peso()
        {
            return transformacion.Peso(this);
        }

        public void Transformar()
        {
            transformacion.Transformar(this);
        }

        public void Destransformar()
        {
            transformacion.Destransformar(this);
        }

        public Bando Bando()
        {
            return bando;
        }

        public bool Acoplado()
        {
            return superRobot != null;
        }

        public void Desacoplar()
        {
            superRobot = null;
        }

        internal void TransformaEn(Transformacion unaTransformacion)
        {
            this.transformacion = unaTransformacion;
        }
    }
}