using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class monedas : MonoBehaviour { 

    public int Aumento; 
    int Puntaje; 
    public Text Texto; 
    private int EffectID = 0; // Id del efecto

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Puntaje =+ Aumento;
        puntaje();



        Destroy(gameObject);

    }
    private void Update()
    {

        puntaje();
    }
    void puntaje()
    {
       
        Texto.text = "Puntos: " + Puntaje;
    }
    /*-----------Area de Mods------------
    Aca es donde se añadiran mas modificadores de items. Meter el codigo dentro de los case, en caso de necesitar mas mods cree nuevos case.*/
    private void MODS()
    {
        switch (EffectID)
        {
            case 0:
                //Codigo
                Debug.Log("Mod 0 = ¨Super Salto¨");
                break;
            case 1:
                //Codigo
                Debug.Log("Mod 1 = ¨Resistencia a ataques I¨");
                break;
            default:
                Debug.Log("Introduce un Modificador Valido");
                break;
        }
    }
}