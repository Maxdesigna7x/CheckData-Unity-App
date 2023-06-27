using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CheckProgram
{
    public class program
    {
        private float gbTotal;
        private float gbConsumidos;
        private int diaMes;

        public float GbTotal
        {
            get { return gbTotal; }
            set { gbTotal = value; }
        }

        public float GbConsumidos
        {
            get { return gbConsumidos; }
            set { gbConsumidos = value; }
        }

        public int DiaMes
        {
            get { return diaMes; }
            set { diaMes = value; }
        }

        public string CalcularConsumo()
        {
            Logic scriptLogic = new Logic();

            return scriptLogic.CalcularConsumo(gbTotal, gbConsumidos, diaMes);
        }
        /*
        public string CalcularConsumoEsperadoDelDia()
        {
            Logic scriptLogic = new Logic();

            return scriptLogic.CalcularConsumoEsperadoDelDia(gbTotal, gbConsumidos, diaMes);
        }
        */
        public bool VariablesEstablecidas()
        {
            if (GbTotal != 0 && GbConsumidos != 0 && DiaMes != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
   
