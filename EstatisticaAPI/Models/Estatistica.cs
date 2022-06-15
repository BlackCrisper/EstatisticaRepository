using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstatisticaAPI.Models
{
    public class Estatistica
    {
       
        public double CalcularMedia(string[] m)
        {
            double n1, n2 ,n3, n4, soma, me;

            try
            {
                n1 = double.Parse(m[0]);
                n2 = double.Parse(m[1]);
                n3 = double.Parse(m[2]);
                n4 = double.Parse(m[3]);
                
            }
            catch (System.Exception)
            {
                
                return -1;
            }

            soma = n1+n2+n3+n4;
            me = soma / 4;
            return me;

        }


      

        
    }
}