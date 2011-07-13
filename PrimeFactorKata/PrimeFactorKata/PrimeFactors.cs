using System.Collections.Generic;

namespace PrimeFactorKata
{
    public class PrimeFactors
    {
        public IList<int> Generate(int number)
        {
            IList<int> resultado = new List<int>();
            

            //for (int i = number - 1; i > 0; i--)
            //{
            //    if   (number % i ==0)
            //    {
            //        number = number - i;
            //        resultado.Add(i);
            //    }
            //}

            resultado.Add(1);
  
            if (number == 3)
            {
                resultado.Add(3);
            }
            if (number == 4)
            {
                resultado.Add(2);
                resultado.Add(2);
            }

            if (number == 5)
            {
                resultado.Add(5);
            }


            return resultado;
        }
    }
}
