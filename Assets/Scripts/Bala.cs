using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Bala : MonoBehaviour
{
    public float velocidadFinal = 6f;
    public float velocidad = 7;

    GameObject player;

    public int potenciaArma= 4;
    // Start is called before the first frame update
    void Start()
    {
         // *La variable del juego con la etiqueta player se almacenará en la etiqueta player//
        player = GameObject.FindWithTag("Player");


        //* acceder al al player para acceder a la direccion bala derecha. si va hacia la derecha la velocidad será positiva 
        // *( hacia la x, si es falso hacia -x//
        //*se pone en start para pq si no en cada fotograma irá a la izq o dcha en función hacia oonde mires
        //*al ponerlo en start lanza la bala y no dependerá de hacia donde mire el pj desués

      if(player.GetComponent<MovPersonaje>().direccionBalaDcha == true){
            velocidad =velocidad *1;
        }

        if(player.GetComponent<MovPersonaje>().direccionBalaDcha == false){
            velocidad =velocidad *-1;
        }


    }

    // Update is called once per frame
    void Update()
    {

         //*TimeDeltaTime para que no vaya a tirones y no dependa de los fps. sino en m&s
        float velocidadFinal = velocidad * Time.deltaTime;
        transform.Translate(velocidadFinal, 0f,0f);

       
    }
    
     //*Comporbar collision, col es el objeto que guarda con lo que colisiona, en este caso el fantasma
        void OnTriggerEnter2D(Collider2D col)
        {


            if(col.gameObject.name.StartsWith("enemigo_fantasma")){

                Destroy(this.gameObject);

                //*cada vez que un objeto colisione cn el fantasma, se llama al scriptVida, al comonente de vida Fantasma y le resta 1. (=- 1 para restar, si no se iguala)
                col.gameObject.GetComponent<FantasmaScript>().vidaFantasma -= 3;
            }
        }


    }
    
    
    
