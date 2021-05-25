using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso
{
    public class Cheque
    {
        private double valorTotal;
        private int centavos;
        private long reais;

        public Cheque(double valorTotal) 
        {
            this.valorTotal = valorTotal;
            //centavos = ConverterTotalParaCentavos();
            //reais = ConverterTotalParaReais();
        }

        public int ConverterTotalParaCentavos() 
        {
            centavos = Convert.ToInt32((valorTotal - Math.Truncate(valorTotal))*100);
            return centavos;
        }

        public long ConverterTotalParaReais()
        {
            reais = Convert.ToInt64(Math.Truncate(valorTotal));
            return reais;
        }

        public string ConverterUnidadeParaExtenso(int unidade)
        {
            string resultado = "";
            switch (unidade)
            {
                case 0: 
                    {
                        resultado = "";
                        break;
                    }
                case 1:
                    {
                        resultado = "um";
                        break;
                    }
                case 2:
                    {
                        resultado = "dois";
                        break;
                    }
                case 3:
                    {
                        resultado = "três";
                        break;
                    }
                case 4:
                    {
                        resultado = "quatro";
                        break;
                    }
                case 5:
                    {
                        resultado = "cinco";
                        break;
                    }
                case 6:
                    {
                        resultado = "seis";
                        break;
                    }
                case 7:
                    {
                        resultado = "sete";
                        break;
                    }
                case 8:
                    {
                        resultado = "oito";
                        break;
                    }
                case 9:
                    {
                        resultado = "nove";
                        break;
                    }
            }
            return resultado;
        }

        public string ConverterValores10a19(int valor)
        {
            string resultado = "";
            switch (valor)
            {
                case 10:
                    {
                        resultado = "dez";
                        break;
                    }
                case 11:
                    {
                        resultado = "onze";
                        break;
                    }
                case 12:
                    {
                        resultado = "doze";
                        break;
                    }
                case 13:
                    {
                        resultado = "treze";
                        break;
                    }
                case 14:
                    {
                        resultado = "catorze";
                        break;
                    }
                case 15:
                    {
                        resultado = "quinze";
                        break;
                    }
                case 16:
                    {
                        resultado = "dezesseis";
                        break;
                    }
                case 17:
                    {
                        resultado = "dezessete";
                        break;
                    }
                case 18:
                    {
                        resultado = "dezoito";
                        break;
                    }
                case 19:
                    {
                        resultado = "dezenove";
                        break;
                    }
            }
            return resultado;
        }

        public string ConverterDezenaParaExtenso(int dezena) 
        {
            string resultado = "";
            switch(dezena)
            {
                case 1:
                    {
                        resultado = "dez";
                        break;
                    }
                case 2:
                    {
                        resultado = "vinte";
                        break;
                    }
                case 3:
                    {
                        resultado = "trinta";
                        break;
                    }
                case 4:
                    {
                        resultado = "quarenta";
                        break;
                    }
                case 5:
                    {
                        resultado = "cinquenta";
                        break;
                    }
                case 6:
                    {
                        resultado = "sessenta";
                        break;
                    }
                case 7:
                    {
                        resultado = "setenta";
                        break;
                    }
                case 8:
                    {
                        resultado = "oitenta";
                        break;
                    }
                case 9:
                    {
                        resultado = "noventa";
                        break;
                    }
            }
            return resultado;
        }

        public string ConverterCentenaParaExtenso(int centena, int dezena, int unidade)
        {
            string resultado = "";
            switch (centena)
            {
                case 0:
                    {
                        resultado = "";
                        break;
                    }
                case 1:
                    {
                        if (dezena == 0 && unidade == 0)
                            resultado = "cem";
                        else
                            resultado = "cento";
                        break;
                    }
                case 2:
                    {
                        resultado = "duzentos";
                        break;
                    }
                case 3:
                    {
                        resultado = "trezentos";
                        break;
                    }
                case 4:
                    {
                        resultado = "quatrocentos";
                        break;
                    }
                case 5:
                    {
                        resultado = "quinhentos";
                        break;
                    }
                case 6:
                    {
                        resultado = "seiscentos";
                        break;
                    }
                case 7:
                    {
                        resultado = "setecentos";
                        break;
                    }
                case 8:
                    {
                        resultado = "oitocentos";
                        break;
                    }
                case 9:
                    {
                        resultado = "novecentos";
                        break;
                    }
                
            }
            return resultado;
        }

        public string ObterCentavosPorExtenso() 
        {
            string resposta = "";
            long totalReais = ConverterTotalParaReais();
            int totalCentavos = ConverterTotalParaCentavos();
            int unidade = totalCentavos % 10;
            int dezena = totalCentavos / 10;
            
            if(dezena == 0 && unidade==0)
            {
                resposta = "";
            }
            else 
            {
                if (dezena == 0 && unidade == 1)
                {
                    resposta = ConverterUnidadeParaExtenso(unidade);
                    resposta += " centavo";
                }
                else
                {
                    if (totalCentavos >= 10 && totalCentavos <= 19)
                    {
                        resposta = ConverterValores10a19(totalCentavos);
                    }
                    else if (dezena != 0 && unidade != 0)
                    {
                        resposta = ConverterDezenaParaExtenso(dezena);
                        resposta += " e ";
                        resposta += ConverterUnidadeParaExtenso(unidade);
                    }
                    else
                    {
                        resposta = ConverterDezenaParaExtenso(dezena);
                        resposta += ConverterUnidadeParaExtenso(unidade);
                    }
                    resposta += " centavos";
                }
                if (totalReais == 0)
                {
                    resposta += " de real";
                }
            }
            

            return resposta;
        }

        public bool ObterRegraDoE()
        {
            bool resposta = false;
            long totalReais = ConverterTotalParaReais();

            List<int> listaReais = new List<int>();
            listaReais = GetListDeInt(totalReais);

            int unidade = listaReais[0];
            int dezena = listaReais[1];
            int centena = listaReais[2];

            if ((centena == 0)||(unidade == 0 && dezena == 0 && centena != 0))
            {
                resposta = true;
            }

            return resposta;
        }

        public string ObterReaisPorExtenso0a999()
        {
            string resposta = "";
            long totalReais = ConverterTotalParaReais();

            List<int> listaReais = new List<int>();
            listaReais = GetListDeInt(totalReais);

            int unidade = listaReais[0];
            int dezena = listaReais[1];
            int centena = listaReais[2];

            if (unidade == 0 && dezena == 0 && centena == 0)
            {
                resposta = "";
            }
            else if (totalReais == 1)
            {
                resposta = ConverterUnidadeParaExtenso(unidade);
                resposta += " real";
            }
            else
            {
                if (dezena==1)
                {
                    if (ConverterCentenaParaExtenso(centena, dezena, unidade) != "")
                    {
                        resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                        resposta += " e ";
                    }
                    resposta += ConverterValores10a19((dezena*10)+unidade);
                }
                else if (centena != 0 && dezena != 0 && unidade != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterDezenaParaExtenso(dezena);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else if (centena != 0 && dezena != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterDezenaParaExtenso(dezena);
                }
                else if (centena != 0 && unidade != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else if (dezena != 0 && unidade != 0)
                {
                    resposta = ConverterDezenaParaExtenso(dezena);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += ConverterDezenaParaExtenso(dezena);
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                resposta += " reais";
            }

            return resposta;
        }

        public string ObterReaisPorExtenso1000a999999()
        {
            string resposta = "";
            long totalReais = ConverterTotalParaReais();
            
            List<int> listaReais = new List<int>(); 
            listaReais = GetListDeInt(totalReais);

            int unidade = listaReais[3];
            int dezena = listaReais[4];
            int centena = listaReais[5];
            if (unidade == 0 && dezena == 0 && centena == 0)
            {
                resposta = "";
            }
            else
            {
                if (centena == 0 && dezena == 0 && unidade == 1)
                {
                    resposta = "mil";
                    return resposta;
                }
                else if (centena!= 0 && dezena == 1)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterValores10a19((dezena * 10) + unidade);
                }
                else if (centena == 0 && dezena == 1)
                {
                    resposta += ConverterValores10a19((dezena * 10) + unidade);
                }
                else if (centena != 0 && dezena != 0 && unidade != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterDezenaParaExtenso(dezena);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else if (centena != 0 && dezena != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterDezenaParaExtenso(dezena);
                }
                else if (centena != 0 && unidade != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else if (dezena != 0 && unidade != 0)
                {
                    resposta = ConverterDezenaParaExtenso(dezena);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += ConverterDezenaParaExtenso(dezena);
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                resposta += " mil";
            }

            return resposta;
        }

        public string ObterReaisPorExtenso1000000a999999999()
        {
            string resposta = "";
            long totalReais = ConverterTotalParaReais();

            List<int> listaReais = new List<int>();
            listaReais = GetListDeInt(totalReais);

            int unidade = listaReais[6];
            int dezena = listaReais[7];
            int centena = listaReais[8];
            if (unidade==0 && dezena==0 && centena==0)
            {
                resposta = "";
            }
            else
            {
                if (centena == 0 && dezena == 0 && unidade == 1)
                {
                    resposta = ConverterUnidadeParaExtenso(unidade);
                    resposta += " milhão";
                    return resposta;
                }
                else if (centena != 0 && dezena == 1)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterValores10a19((dezena * 10) + unidade);
                }
                else if (centena == 0 && dezena == 1)
                {
                    resposta += ConverterValores10a19((dezena * 10) + unidade);
                }
                else if (centena != 0 && dezena != 0 && unidade != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterDezenaParaExtenso(dezena);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else if (centena != 0 && dezena != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterDezenaParaExtenso(dezena);
                }
                else if (centena != 0 && unidade != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else if (dezena != 0 && unidade != 0)
                {
                    resposta = ConverterDezenaParaExtenso(dezena);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += ConverterDezenaParaExtenso(dezena);
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                resposta += " milhões";
            }

            return resposta;
        }

        public string ObterReaisPorExtenso1000000000a999999999999()
        {
            string resposta = "";
            long totalReais = ConverterTotalParaReais();

            List<int> listaReais = new List<int>();
            listaReais = GetListDeInt(totalReais);

            int unidade = listaReais[9];
            int dezena = listaReais[10];
            int centena = listaReais[11];
            if (unidade == 0 && dezena == 0 && centena == 0)
            {
                resposta = "";
            }
            else
            {
                if (centena == 0 && dezena == 0 && unidade == 1)
                {
                    resposta = ConverterUnidadeParaExtenso(unidade);
                    resposta += " bilhão";
                    return resposta;
                }
                else if (centena != 0 && dezena == 1)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterValores10a19((dezena * 10) + unidade);
                }
                else if (centena == 0 && dezena == 1)
                {
                    resposta += ConverterValores10a19((dezena * 10) + unidade);
                }
                else if (centena != 0 && dezena != 0 && unidade != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterDezenaParaExtenso(dezena);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else if (centena != 0 && dezena != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterDezenaParaExtenso(dezena);
                }
                else if (centena != 0 && unidade != 0)
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else if (dezena != 0 && unidade != 0)
                {
                    resposta = ConverterDezenaParaExtenso(dezena);
                    resposta += " e ";
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                else
                {
                    resposta = ConverterCentenaParaExtenso(centena, dezena, unidade);
                    resposta += ConverterDezenaParaExtenso(dezena);
                    resposta += ConverterUnidadeParaExtenso(unidade);
                }
                resposta += " bilhões";
            }

            return resposta;
        }

        public string ObterChequePorExtenso() 
        {
            string resultado = "";
            resultado = ObterReaisPorExtenso1000000000a999999999999();

            if (resultado != "" && ObterReaisPorExtenso1000000a999999999() != "")
                resultado += " ";
            resultado += ObterReaisPorExtenso1000000a999999999();
           
            if (resultado != "" && ObterReaisPorExtenso1000a999999() != "")
                resultado += " ";
            resultado += ObterReaisPorExtenso1000a999999();


            if (resultado != "" && ObterReaisPorExtenso0a999() != "")
            { 
                if(ObterRegraDoE())
                    resultado += " e ";
                else
                    resultado += " ";
            }
            resultado += ObterReaisPorExtenso0a999();

            if (resultado!="" && ObterCentavosPorExtenso() != "")
                resultado += " e ";
            resultado += ObterCentavosPorExtenso();

            resultado = RetornarStringPrimeiraLetraMaiuscula(resultado);

            return resultado;
        }

        public string RetornarStringPrimeiraLetraMaiuscula(string numeroPorExtenso)
        {
            string resultado = char.ToUpper(numeroPorExtenso[0]) + numeroPorExtenso.Substring(1);

            return resultado;
        }

        public List<int> GetListDeInt(long numeroInteiro)
        {
            List<int> listOfInts = new List<int>();

            while (numeroInteiro > 0 )
            {
                listOfInts.Add(Convert.ToInt32(numeroInteiro % 10));
                numeroInteiro = numeroInteiro / 10;
            }

            while (listOfInts.Count < 15)
            {
                listOfInts.Add(0);
            }

            //listOfInts.Reverse();
            return listOfInts;
        }
    }
}
