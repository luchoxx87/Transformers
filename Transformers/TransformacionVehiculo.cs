using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformers
{
    public abstract class TransformacionVehiculo: Transformacion
    {
        public override void Transformar(Transformer transformer)
        {
            throw new Exception("Ya esta transformado");
        }

        public override void Destransformar(Transformer transformer)
        {
            transformer.TransformaEn(this.Siguiente);
        }        
    }
}
