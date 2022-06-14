using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstatisticaAPI.Models
{
    public interface IEstatisticaMetodos
    {
        double CalcularModa(string[] m);
        double CalcularMedia(string[] m);
        double CalcularMediana(string[] m);
        double CalcularMediaPonderada(string[] m);
        double CalcularDesvioPadrao(string[] m);
        double CalcularMaximo(string[] m);
        double CalcularMinimo(string[] m);
    }
}