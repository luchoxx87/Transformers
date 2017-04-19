using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transformers;

namespace TestTransformers
{
    class Fixture
    {
        private static Transformacion DameElBasicoPara(Transformacion final)
        {
            Transformacion basico = new Transformacion();
            basico.vaACambiarA(final);
            final.vaACambiarA(basico);
            return basico;
        }
        public static Transformacion DameAutoSeteado()
        {
            Auto final = new Auto();
            return Fixture.DameElBasicoPara(final);
        }
        public static Transformacion DameAvionSeteado()
        {
            Avion final = new Avion();
            return Fixture.DameElBasicoPara(final);
        }
        public static Transformacion DameCamionSeteado()
        {
            Camion final = new Camion();
            return Fixture.DameElBasicoPara(final);
        }
        public static Transformacion DameTanqueSeteado()
        {
            Tanque final = new Tanque();
            return Fixture.DameElBasicoPara(final);
        }
    }
}
