using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformers
{
    public class Transformacion
    {
        Transformacion siguiente;

        public Transformacion Siguiente
        {
            get { return siguiente; }
        }
        public void vaACambiarA(Transformacion unaTransformacion)
        {
            siguiente = unaTransformacion;
        }

        public virtual int Velocidad(Transformer transformer)
        {
            return transformer.VelocidadBase;
        }

        public virtual int PoderDestructivo(Transformer transformer)
        {
            return transformer.PoderDestructivoBase;
        }

        public virtual int Peso(Transformer transformer)
        {
            return transformer.PesoBase;
        }

        public virtual void Destransformar(Transformer transformer)
        {
            throw new Exception("No esta transformado");
        }

        public virtual void Transformar(Transformer transformer)
        {
            transformer.TransformaEn(this.siguiente);
        }

        public override string ToString()
        {
            return ("Base");
        }
    }
}
