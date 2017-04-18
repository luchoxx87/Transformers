using System.Collections.Generic;
using System.Linq;
namespace Transformers
{
    public class Bando
    {

        private List<IRobot> robots;
        private string nombre;

        public Bando(string unNombre)
        {
            nombre = unNombre;
            robots = new List<IRobot>();
        }

        /// 
        /// <param name="unRobot"></param>
        public void AgregarALista(IRobot unRobot)
        {
            robots.Add(unRobot);
        }
        public void Sacar(IRobot robot)
        {
            robots.Remove(robot);
        }

        public int PoderTotal()
        {
            return robots.Sum(robot => robot.PoderDestructivo());
        }
    }
}