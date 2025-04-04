using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    private GameObject personaje; //acceder al obeto para poder acceder a su componente (el script de movPersonaje)
    private MovPersonaje movPersonaje; //acceder al script de movim de pj (script hecho de tipo MovPersonaje) y la llamas mov personaje. Aquí te da el tipo de dato, falta llamarlo en el start
                                       // Start is called before the first frame update


    void Start()
    {
        personaje = GameObject.Find("mage"); //acceder a personaje
        movPersonaje = personaje.GetComponent<MovPersonaje>(); //llamada en general
        //movPersonaje.Respawnear(); // comento para que funcione el codigo llamada a la función de Respawnear previamente hecha


    }

    //Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Colisión detectada con: " + col.name);

        if (col.name == "mage")
        {
            movPersonaje.Respawnear();
            Debug.Log(col.name);
        }
    }

}
