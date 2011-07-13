using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFactorKata;

namespace PrimeFactorKataTest
{
    [TestClass]
    public class PrimerFactorTest
    {
        private PrimeFactors _primeFactors;

        public PrimerFactorTest()
        {
            _primeFactors = new PrimeFactors();
        }

        [TestMethod]        
        public void dado_el_numero_uno_devuelvo_una_lista_que_contiene_solo_el_numero_uno()
        {
            var numerosPrimos = _primeFactors.Generate(1);

            Assert.AreEqual(1, numerosPrimos.Count);
            Assert.AreEqual(1, numerosPrimos[0]);
        }

        [TestMethod]
        public void dado_el_numero_tres_devuelvo_una_lista_de_dos_numeros_que_son_uno_y_tres()
        {
            var numerosPrimos = _primeFactors.Generate(3);
            Assert.AreEqual(2, numerosPrimos.Count);
            Assert.AreEqual(1, numerosPrimos[0]);
            Assert.AreEqual(3, numerosPrimos[1]);

        }

        [TestMethod]
        public void dado_elNumero_cuatro_devuelvo_una_lista_de_tres_numeros_que_son_uno_y_dos_y_dos()
        {
            var numerosPrimos = _primeFactors.Generate(4);
            Assert.AreEqual(3, numerosPrimos.Count);
            Assert.AreEqual(1,numerosPrimos[0]);
            Assert.AreEqual(2, numerosPrimos[1]);
            Assert.AreEqual(2, numerosPrimos[2]);
        }

            
        [TestMethod]
        public void dado_elNumero_cinco_devuelvo_una_lista_de_dos_numeros_que_son_uno_y_cinco()
        {
            var numerosPrimos = _primeFactors.Generate(5);
            Assert.AreEqual(2, numerosPrimos.Count);
            Assert.AreEqual(1, numerosPrimos[0]);
            Assert.AreEqual(5, numerosPrimos[1]);
        }
    }
}
