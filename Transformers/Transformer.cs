using System;
namespace Transformers
{
    public abstract class Transformer : IRobot
    {

        private Bando bando;
        private string nombre;
        private int velocidad;
        private int peso;
        private int poderDestructivo;
        private bool transformado;
        private SuperRobot superRobot;
        public Transformer(Bando unBando, string unNombre, int unaVelocidad, int unPeso, int unPoderDestructivo)
        {
            bando = unBando;
            nombre = unNombre;
            velocidad = unaVelocidad;
            peso = unPeso;
            poderDestructivo = unPoderDestructivo;
            transformado = false;
            superRobot = null;
            bando.AgregarALista(this);
        }

        public string Nombre()
        {
            return nombre;
        }

        public virtual int Velocidad()
        {
            return velocidad;
        }

        public virtual int PoderDestructivo()
        {
            return poderDestructivo;
        }

        public virtual int Peso()
        {
            return peso;
        }

        public void Transformar()
        {
            if (!transformado)
            {
                transformado = true;
            }
            else
            {
                throw new Exception("Ya estoy transformado");
            }
        }

        public void Destransformar()
        {
            if (transformado)
            {
                transformado = false;
            }
            else
            {
                throw new Exception("No estoy transformado");
            }
        }

        public bool Transformado()
        {
            return transformado;
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
    }
}