using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CheckProgram;

public class UnityScript : MonoBehaviour
{
    [SerializeField]
    public program scriptProgram;

    [SerializeField]
    public Text infoText;

    [SerializeField]
    public GameObject boton;

    private void Start()
    {
        scriptProgram = new program();
    }

    public void SetValorGbTotal(string nuevoGbTotalString)
    {
        float nuevoGbTotal;        

        // Intenta convertir el valor de strings a float.
        bool exitoGbTotal = float.TryParse(nuevoGbTotalString, out nuevoGbTotal);        

        // Si se pudo convertir el valor, establece la variable de la instancia de ConsumoMensual.
        if (exitoGbTotal)
        {
            scriptProgram.GbTotal = nuevoGbTotal;            
        }
    }
    public void SetValorGbConsumidos(string nuevoGbConsumidosString)
    {        
        float nuevoGbConsumidos;

        // Intenta convertir el valor de strings a float.
        bool exitoGbConsumidos = float.TryParse(nuevoGbConsumidosString, out nuevoGbConsumidos);

        // Si se pudo convertir el valor, establece la variable de la instancia de ConsumoMensual.
        if (exitoGbConsumidos)
        {            
            scriptProgram.GbConsumidos = nuevoGbConsumidos;
        }
    }

    public void SetValorDiaMes(string nuevoDiaMesString)
    {       
        int nuevoDiaMes;

        // Intenta convertir el valor de strings a float.
        bool exitoDiaMes = int.TryParse(nuevoDiaMesString, out nuevoDiaMes);

        // Si se pudo convertir el valor, establece la variable de la instancia de ConsumoMensual.
        if (exitoDiaMes)
        {
            scriptProgram.DiaMes = nuevoDiaMes;
        }
    }

    public void ActualizarInfoText()
    {        
        infoText.text = scriptProgram.CalcularConsumo();
        infoText.gameObject.SetActive(true); // ACTIVA EL COMPONENTE Text
    }

    public void ActivarBoton() 
    {
        boton.SetActive(scriptProgram.VariablesEstablecidas());
        Debug.Log("boton es: " + scriptProgram.VariablesEstablecidas() + scriptProgram.GbTotal.ToString() + " " + scriptProgram.GbConsumidos.ToString() + " " + scriptProgram.DiaMes.ToString());
    }
}
