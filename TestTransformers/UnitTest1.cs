using System;
using Transformers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTransformers
{
    [TestClass]
    public class UnitTest1
    {
        Camion optimusPrime;
        Bando autobotos, decepticons;
        SuperRobot optimusBumblebee;

        private void iniciar()
        {
            autobotos = new Bando("Autobots");
            decepticons = new Bando("Decepticons");
            optimusPrime = new Camion(autobotos, "Optimus Prime", 500, 750, 1000);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void optimusNoConvierte()
        {
            iniciar();
            optimusPrime.Destransformar();
        }
    }
}
