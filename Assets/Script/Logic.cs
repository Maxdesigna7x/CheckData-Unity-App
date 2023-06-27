using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic
{
    public string CalcularConsumo(float GbTotal, float GbConsumidos, int diaMes)
    {
        if (diaMes > 30)
        {
            return "Error: día del mes inválido.";
        }

        float consumoEsperado = (GbTotal / 30) * diaMes;
        float consumoReal = GbConsumidos;

        if (consumoReal < consumoEsperado)
        {
            return ("Estás por debajo del consumo esperado para este día del mes." + Environment.NewLine + 
                "El consumo esperado para el día " + diaMes + " es de " + consumoEsperado.ToString("F2") + " GB.");
        }
        else
        {
            return ("Estás por encima del consumo esperado para este día del mes." + Environment.NewLine +
                "El consumo esperado para el día " + diaMes + " es de " + consumoEsperado.ToString("F2") + " GB.");             
        }
    }
    /*
    public string CalcularConsumoEsperadoDelDia(float GbTotal, float GbConsumidos, int diaMes)
    {
        if (diaMes > 30)
        {
            return null; // o devolver una cadena de error: return "Error: día del mes inválido."
        }

        float consumoEsperado = GbTotal / (30 * GbConsumidos);
        float consumoEsperadoDelDia = consumoEsperado * diaMes;

        return "El consumo esperado para el día " + diaMes + " es de " + consumoEsperadoDelDia.ToString("F2") + " GB.";
    }
    */
}
