using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChequePorExtenso;
using System;

namespace ChequePorExtensoTestes
{
    [TestClass]
    public class ChequeTestes
    {
        [TestMethod]
        public void AvaliarConverterTotalParaCentavos()
        {
            //cenário
            double x = 23.16;

            //ação
            Cheque teste = new Cheque(x);

            //verificação
            Assert.AreEqual(16, teste.ConverterTotalParaCentavos());
        }

        [TestMethod]
        public void AvaliarConversaoTotalParaReais()
        {
            //cenário
            double x = 1023.16;

            //ação
            Cheque teste = new Cheque(x);

            //verificação
            Assert.AreEqual(1023, teste.ConverterTotalParaReais());
        }

        [TestMethod]
        public void AvaliarObterCentavosPorExtensoEntre10e19()
        {
            //cenário        
            double x = 00.16;
            double y = 323.11;
            double z = 2.19;

            //ação
            Cheque teste1 = new Cheque(x);
            Cheque teste2 = new Cheque(y);
            Cheque teste3 = new Cheque(z);

            //verificação
            Assert.AreEqual("dezesseis centavos de real", teste1.ObterCentavosPorExtenso());
            Assert.AreEqual("onze centavos", teste2.ObterCentavosPorExtenso());
            Assert.AreEqual("dezenove centavos", teste3.ObterCentavosPorExtenso());
        }

        [TestMethod]
        public void AvaliarObterCentavosPorExtensoEntre0e9()
        {
            //cenário
            double x = 0.04;
            double y = 323.0;
            double z = 2.01;

            //ação
            Cheque teste1 = new Cheque(x);
            Cheque teste2 = new Cheque(y);
            Cheque teste3 = new Cheque(z);

            //verificação
            Assert.AreEqual("quatro centavos de real", teste1.ObterCentavosPorExtenso());
            Assert.AreEqual("", teste2.ObterCentavosPorExtenso());
            Assert.AreEqual("um centavo", teste3.ObterCentavosPorExtenso());
        }

        [TestMethod]
        public void AvaliarObterCentavosPorExtensoEntre20e99()
        {
            //cenário
            double a = 1.24;
            double b = 2.30;
            double c = 3.42;
            double d = 4.56;
            double e = 5.63;
            double f = 6.78;
            double g = 7.81;
            double h = 8.99;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);
            Cheque teste4 = new Cheque(d);
            Cheque teste5 = new Cheque(e);
            Cheque teste6 = new Cheque(f);
            Cheque teste7 = new Cheque(g);
            Cheque teste8 = new Cheque(h);

            //verificação
            Assert.AreEqual("vinte e quatro centavos", teste1.ObterCentavosPorExtenso());
            Assert.AreEqual("trinta centavos", teste2.ObterCentavosPorExtenso());
            Assert.AreEqual("quarenta e dois centavos", teste3.ObterCentavosPorExtenso());
            Assert.AreEqual("cinquenta e seis centavos", teste4.ObterCentavosPorExtenso());
            Assert.AreEqual("sessenta e três centavos", teste5.ObterCentavosPorExtenso());
            Assert.AreEqual("setenta e oito centavos", teste6.ObterCentavosPorExtenso());
            Assert.AreEqual("oitenta e um centavos", teste7.ObterCentavosPorExtenso());
            Assert.AreEqual("noventa e nove centavos", teste8.ObterCentavosPorExtenso());
        }

        [TestMethod]
        public void AvaliarObterReaisPorExtensoEntre0e9()
        {
            //cenário
            double a = 0.24;
            double b = 1.30;
            double c = 7.42;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);

            //verificação
            Assert.AreEqual("Vinte e quatro centavos de real", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Um real e trinta centavos", teste2.ObterChequePorExtenso());
            Assert.AreEqual("Sete reais e quarenta e dois centavos", teste3.ObterChequePorExtenso());
        }

        [TestMethod]
        public void AvaliarObterReaisPorExtensoEntre10e19()
        {
            //cenário
            double a = 10.24;
            double b = 15.30;
            double c = 16.42;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);

            //verificação
            Assert.AreEqual("Dez reais e vinte e quatro centavos", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Quinze reais e trinta centavos", teste2.ObterChequePorExtenso());
            Assert.AreEqual("Dezesseis reais e quarenta e dois centavos", teste3.ObterChequePorExtenso());
        }

        [TestMethod]
        public void AvaliarObterReaisPorExtensoEntre20e99()
        {
            //cenário
            double a = 21.00;
            double b = 30.00;
            double c = 43.00;
            double d = 54.00;
            double e = 69.00;
            double f = 70.00;
            double g = 87.00;
            double h = 98.00;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);
            Cheque teste4 = new Cheque(d);
            Cheque teste5 = new Cheque(e);
            Cheque teste6 = new Cheque(f);
            Cheque teste7 = new Cheque(g);
            Cheque teste8 = new Cheque(h);

            //verificação
            Assert.AreEqual("Vinte e um reais", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Trinta reais", teste2.ObterChequePorExtenso());
            Assert.AreEqual("Quarenta e três reais", teste3.ObterChequePorExtenso());
            Assert.AreEqual("Cinquenta e quatro reais", teste4.ObterChequePorExtenso());
            Assert.AreEqual("Sessenta e nove reais", teste5.ObterChequePorExtenso());
            Assert.AreEqual("Setenta reais", teste6.ObterChequePorExtenso());
            Assert.AreEqual("Oitenta e sete reais", teste7.ObterChequePorExtenso());
            Assert.AreEqual("Noventa e oito reais", teste8.ObterChequePorExtenso());
        }

        [TestMethod]
        public void AvaliarObterReaisPorExtensoEntre100e999()
        {
            //cenário
            double a = 100.00;
            double b = 230.00;
            double c = 343.00;
            double d = 454.00;
            double e = 569.00;
            double f = 670.00;
            double g = 787.00;
            double h = 998.00;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);
            Cheque teste4 = new Cheque(d);
            Cheque teste5 = new Cheque(e);
            Cheque teste6 = new Cheque(f);
            Cheque teste7 = new Cheque(g);
            Cheque teste8 = new Cheque(h);

            //verificação
            Assert.AreEqual("Cem reais", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Duzentos e trinta reais", teste2.ObterChequePorExtenso());
            Assert.AreEqual("Trezentos e quarenta e três reais", teste3.ObterChequePorExtenso());
            Assert.AreEqual("Quatrocentos e cinquenta e quatro reais", teste4.ObterChequePorExtenso());
            Assert.AreEqual("Quinhentos e sessenta e nove reais", teste5.ObterChequePorExtenso());
            Assert.AreEqual("Seiscentos e setenta reais", teste6.ObterChequePorExtenso());
            Assert.AreEqual("Setecentos e oitenta e sete reais", teste7.ObterChequePorExtenso());
            Assert.AreEqual("Novecentos e noventa e oito reais", teste8.ObterChequePorExtenso());
        }

        [TestMethod]
        public void AvaliarObterReaisPorExtensoEntre1000e9999()
        {
            //cenário
            double a = 1100.00;
            double b = 2230.00;
            double c = 3343.00;
            double d = 4454.00;
            double e = 5569.00;
            double f = 6670.00;
            double g = 7787.15;
            double h = 8998.29;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);
            Cheque teste4 = new Cheque(d);
            Cheque teste5 = new Cheque(e);
            Cheque teste6 = new Cheque(f);
            Cheque teste7 = new Cheque(g);
            Cheque teste8 = new Cheque(h);

            //verificação
            Assert.AreEqual("Mil e cem reais", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Dois mil duzentos e trinta reais", teste2.ObterChequePorExtenso());
            Assert.AreEqual("Três mil trezentos e quarenta e três reais", teste3.ObterChequePorExtenso());
            Assert.AreEqual("Quatro mil quatrocentos e cinquenta e quatro reais", teste4.ObterChequePorExtenso());
            Assert.AreEqual("Cinco mil quinhentos e sessenta e nove reais", teste5.ObterChequePorExtenso());
            Assert.AreEqual("Seis mil seiscentos e setenta reais", teste6.ObterChequePorExtenso());
            Assert.AreEqual("Sete mil setecentos e oitenta e sete reais e quinze centavos", teste7.ObterChequePorExtenso());
            Assert.AreEqual("Oito mil novecentos e noventa e oito reais e vinte e nove centavos", teste8.ObterChequePorExtenso());
        }

        [TestMethod]
        public void AvaliarObterReaisPorExtensoEntre10000e99999()
        {
            //cenário
            double a = 11100.00;
            double b = 22230.00;
            double c = 33343.00;
            double d = 44454.00;
            double e = 55569.00;
            double f = 66670.00;
            double g = 77787.15;
            double h = 88998.29;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);
            Cheque teste4 = new Cheque(d);
            Cheque teste5 = new Cheque(e);
            Cheque teste6 = new Cheque(f);
            Cheque teste7 = new Cheque(g);
            Cheque teste8 = new Cheque(h);

            //verificação
            Assert.AreEqual("Onze mil e cem reais", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Vinte e dois mil duzentos e trinta reais", teste2.ObterChequePorExtenso());
            Assert.AreEqual("Trinta e três mil trezentos e quarenta e três reais", teste3.ObterChequePorExtenso());
            Assert.AreEqual("Quarenta e quatro mil quatrocentos e cinquenta e quatro reais", teste4.ObterChequePorExtenso());
            Assert.AreEqual("Cinquenta e cinco mil quinhentos e sessenta e nove reais", teste5.ObterChequePorExtenso());
            Assert.AreEqual("Sessenta e seis mil seiscentos e setenta reais", teste6.ObterChequePorExtenso());
            Assert.AreEqual("Setenta e sete mil setecentos e oitenta e sete reais e quinze centavos", teste7.ObterChequePorExtenso());
            Assert.AreEqual("Oitenta e oito mil novecentos e noventa e oito reais e vinte e nove centavos", teste8.ObterChequePorExtenso());
        }

        [TestMethod]
        public void AvaliarObterReaisPorExtensoEntre100000e999999()
        {
            //cenário
            double a = 111100.00;
            double b = 222230.00;
            double c = 333343.00;
            double d = 444454.00;
            double e = 555569.00;
            double f = 666670.00;
            double g = 777787.15;
            double h = 888998.29;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);
            Cheque teste4 = new Cheque(d);
            Cheque teste5 = new Cheque(e);
            Cheque teste6 = new Cheque(f);
            Cheque teste7 = new Cheque(g);
            Cheque teste8 = new Cheque(h);

            //verificação
            Assert.AreEqual("Cento e onze mil e cem reais", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Duzentos e vinte e dois mil duzentos e trinta reais", teste2.ObterChequePorExtenso());
            Assert.AreEqual("Trezentos e trinta e três mil trezentos e quarenta e três reais", teste3.ObterChequePorExtenso());
            Assert.AreEqual("Quatrocentos e quarenta e quatro mil quatrocentos e cinquenta e quatro reais", teste4.ObterChequePorExtenso());
            Assert.AreEqual("Quinhentos e cinquenta e cinco mil quinhentos e sessenta e nove reais", teste5.ObterChequePorExtenso());
            Assert.AreEqual("Seiscentos e sessenta e seis mil seiscentos e setenta reais", teste6.ObterChequePorExtenso());
            Assert.AreEqual("Setecentos e setenta e sete mil setecentos e oitenta e sete reais e quinze centavos", teste7.ObterChequePorExtenso());
            Assert.AreEqual("Oitocentos e oitenta e oito mil novecentos e noventa e oito reais e vinte e nove centavos", teste8.ObterChequePorExtenso());
        }

        [TestMethod]
        public void AvaliarObterReaisPorExtensoMilhoes()
        {
            //cenário
            double a = 1111100.00;
            double b = 2222230.00;
            double c = 3333343.00;
            double d = 4444454.00;
            double e = 5555569.00;
            double f = 6666670.00;
            double g = 7777787.15;
            double h = 8888998.29;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);
            Cheque teste4 = new Cheque(d);
            Cheque teste5 = new Cheque(e);
            Cheque teste6 = new Cheque(f);
            Cheque teste7 = new Cheque(g);
            Cheque teste8 = new Cheque(h);

            //verificação
            Assert.AreEqual("Um milhão cento e onze mil e cem reais", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Dois milhões duzentos e vinte e dois mil duzentos e trinta reais", teste2.ObterChequePorExtenso());
            Assert.AreEqual("Três milhões trezentos e trinta e três mil trezentos e quarenta e três reais", teste3.ObterChequePorExtenso());
            Assert.AreEqual("Quatro milhões quatrocentos e quarenta e quatro mil quatrocentos e cinquenta e quatro reais", teste4.ObterChequePorExtenso());
            Assert.AreEqual("Cinco milhões quinhentos e cinquenta e cinco mil quinhentos e sessenta e nove reais", teste5.ObterChequePorExtenso());
            Assert.AreEqual("Seis milhões seiscentos e sessenta e seis mil seiscentos e setenta reais", teste6.ObterChequePorExtenso());
            Assert.AreEqual("Sete milhões setecentos e setenta e sete mil setecentos e oitenta e sete reais e quinze centavos", teste7.ObterChequePorExtenso());
            Assert.AreEqual("Oito milhões oitocentos e oitenta e oito mil novecentos e noventa e oito reais e vinte e nove centavos", teste8.ObterChequePorExtenso());
        }

        [TestMethod]
        public void AvaliarObterReaisPorExtensoBilhoes()
        {
            //cenário
            double a = 1111111100.00;
            double b = 2222222230.00;
            double c = 3333333343.00;
            double d = 4444444454.00;
            double e = 5555555569.00;
            double f = 6666666670.00;
            double g = 7777777787.15;
            double h = 8888888998.29;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);
            Cheque teste4 = new Cheque(d);
            Cheque teste5 = new Cheque(e);
            Cheque teste6 = new Cheque(f);
            Cheque teste7 = new Cheque(g);
            Cheque teste8 = new Cheque(h);

            //verificação
            Assert.AreEqual("Um bilhão cento e onze milhões cento e onze mil e cem reais", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Dois bilhões duzentos e vinte e dois milhões duzentos e vinte e dois mil duzentos e trinta reais", teste2.ObterChequePorExtenso());
            Assert.AreEqual("Três bilhões trezentos e trinta e três milhões trezentos e trinta e três mil trezentos e quarenta e três reais", teste3.ObterChequePorExtenso());
            Assert.AreEqual("Quatro bilhões quatrocentos e quarenta e quatro milhões quatrocentos e quarenta e quatro mil quatrocentos e cinquenta e quatro reais", teste4.ObterChequePorExtenso());
            Assert.AreEqual("Cinco bilhões quinhentos e cinquenta e cinco milhões quinhentos e cinquenta e cinco mil quinhentos e sessenta e nove reais", teste5.ObterChequePorExtenso());
            Assert.AreEqual("Seis bilhões seiscentos e sessenta e seis milhões seiscentos e sessenta e seis mil seiscentos e setenta reais", teste6.ObterChequePorExtenso());
            Assert.AreEqual("Sete bilhões setecentos e setenta e sete milhões setecentos e setenta e sete mil setecentos e oitenta e sete reais e quinze centavos", teste7.ObterChequePorExtenso());
            Assert.AreEqual("Oito bilhões oitocentos e oitenta e oito milhões oitocentos e oitenta e oito mil novecentos e noventa e oito reais e vinte e nove centavos", teste8.ObterChequePorExtenso());
        }

        [TestMethod]
        public void AvaliarResultadosDaRegraDoE()
        {
            //cenário
            double a = 251364102;
            double b = 5800906012;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);

            //verificação
            Assert.AreEqual("Duzentos e cinquenta e um milhões trezentos e sessenta e quatro mil cento e dois reais", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Cinco bilhões oitocentos milhões novecentos e seis mil e doze reais", teste2.ObterChequePorExtenso());
        }

        [TestMethod]
        public void TesteFinal() 
        {
            double a = 0.05;
            double b = 2.25;
            double c = 7.00;
            double d = 37.00;
            double e = 637.00;
            double f = 1637.00;
            double g = 15415.16;
            double h = 61637.00;
            double i = 961637.00;
            double j = 1852700.00;
            double k = 5961637.00;
            double l = 25961637.00;
            double m = 425961637.00;
            double n = 8425961637.00;

            //ação
            Cheque teste1 = new Cheque(a);
            Cheque teste2 = new Cheque(b);
            Cheque teste3 = new Cheque(c);
            Cheque teste4 = new Cheque(d);
            Cheque teste5 = new Cheque(e);
            Cheque teste6 = new Cheque(f);
            Cheque teste7 = new Cheque(g);
            Cheque teste8 = new Cheque(h);
            Cheque teste9 = new Cheque(i);
            Cheque teste10 = new Cheque(j);
            Cheque teste11 = new Cheque(k);
            Cheque teste12 = new Cheque(l);
            Cheque teste13 = new Cheque(m);
            Cheque teste14 = new Cheque(n);

            //verificação
            Assert.AreEqual("Cinco centavos de real", teste1.ObterChequePorExtenso());
            Assert.AreEqual("Dois reais e vinte e cinco centavos", teste2.ObterChequePorExtenso());
            Assert.AreEqual("Sete reais", teste3.ObterChequePorExtenso());
            Assert.AreEqual("Trinta e sete reais", teste4.ObterChequePorExtenso());
            Assert.AreEqual("Seiscentos e trinta e sete reais", teste5.ObterChequePorExtenso());
            Assert.AreEqual("Mil seiscentos e trinta e sete reais", teste6.ObterChequePorExtenso());
            Assert.AreEqual("Quinze mil quatrocentos e quinze reais e dezesseis centavos", teste7.ObterChequePorExtenso());
            Assert.AreEqual("Sessenta e um mil seiscentos e trinta e sete reais", teste8.ObterChequePorExtenso());
            Assert.AreEqual("Novecentos e sessenta e um mil seiscentos e trinta e sete reais", teste9.ObterChequePorExtenso());
            Assert.AreEqual("Um milhão oitocentos e cinquenta e dois mil e setecentos reais", teste10.ObterChequePorExtenso());
            Assert.AreEqual("Cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", teste11.ObterChequePorExtenso());
            Assert.AreEqual("Vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", teste12.ObterChequePorExtenso());
            Assert.AreEqual("Quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", teste13.ObterChequePorExtenso());
            Assert.AreEqual("Oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais", teste14.ObterChequePorExtenso());
        }
    }
}
