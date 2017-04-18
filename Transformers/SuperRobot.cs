using System;
using System.Collections.Generic;
using System.Linq;
namespace Transformers
{
    public class SuperRobot : IRobot
    {
        private Bando bando;
        private List<Transformer> robots;

        private SuperRobot(Transformer unRobot, Transformer otroRobot)
        {
            robots = new List<Transformer>();
            robots.Add(unRobot);
            robots.Add(otroRobot);
            bando = unRobot.Bando();
            bando.AgregarALista(this);
        }

        public string Nombre()
        {
            string nombres = "";
            robots.ForEach(robot=>nombres=nombres + robot.Nombre() + " ");
            return nombres;
        }

        public int Velocidad()
        {
            return robots.Sum(robot => robot.Velocidad());
        }

        public int PoderDestructivo()
        {
            return robots.Sum(robot => robot.PoderDestructivo());
        }

        public int Peso()
        {
            return robots.Sum(robot => robot.Peso());
        }

        public Bando Bando()
        {
            return bando;
        }

        /// 
        /// <param name="unTransformer"></param>
        public static SuperRobot DameSuperRobot(Transformer unRobot, Transformer otroRobot)
        {
            if (unRobot.Bando()==otroRobot.Bando())
            {
                if (!unRobot.Acoplado() && !otroRobot.Acoplado())
                {
                    return new SuperRobot(unRobot, otroRobot);
                }
                else
                {
                    throw new Exception("Uno de los transformers ya esta acoplado");
                }
            }
            else
            {
                throw new Exception("No se pueden acoplar, distinto bando");
            }
        }

        public void unir(Transformer robot)
        {
      
        }
        public void Desacoplar(Transformer unRobot)
        {
            if (robots.Contains(unRobot))
            {
                robots.Remove(unRobot);
                unRobot.Desacoplar();
                if (robots.Count==0)
                {
                    bando.Sacar(this);                    
                }
            }
            else
            {
                throw new Exception("El robot no se encuentra aqui");
            }
        }

    }
}