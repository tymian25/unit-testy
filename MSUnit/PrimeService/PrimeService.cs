using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)                                                  //Dla liczb -1, 0, 1
            {
                return false;
            }

            for (var divisor =2; divisor <= Math.Sqrt(candidate); divisor++)    //Dodanie fragmentu kodu do przykładu dla liczb większych od 1
            {
                if (candidate % divisor == 0)
                {
                   return false;                                                 //Zwrot wartość bool false
                }
            }

            return true;                                                        //Zwrot wartość bool true
        }
    }
}
