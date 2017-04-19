﻿using System;
using Transformers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTransformers
{
    [TestClass]
    public class UnitTest1
    {
        Transformer optimusPrime;
        Bando autobotos, decepticons;
        SuperRobot optimusBumblebee;

        private void iniciar()
        {
            autobotos = new Bando("Autobots");
            decepticons = new Bando("Decepticons");
            Transformacion basicaCamion = Fixture.DameCamionSeteado();

            optimusPrime = new Transformer(autobotos, "Optimus Prime", 750,1000,basicaCamion, 500);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void optimusNoConvierte()
        {
            iniciar();
            optimusPrime.Destransformar();
        }
        [TestMethod]
        public void optimusSinTransformar()
        {
            iniciar();
            Assert.AreEqual(750, optimusPrime.Peso());
            Assert.AreEqual(1000, optimusPrime.PoderDestructivo());
            Assert.AreEqual(500, optimusPrime.Velocidad());
        }
        
        [TestMethod]
        public void optimusTransformado()
        {
            iniciar();
            optimusPrime.Transformar();
            Assert.AreEqual(2000, optimusPrime.PoderDestructivo());        
        }       
    }
}
