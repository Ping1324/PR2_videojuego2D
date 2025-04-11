using System;
using System.Collections;
using System.Collections.Generic;
// using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FantasmaScript : MonoBehaviour
{

    public int vidaFantasma = 10;
    public float velocidad = 2f;


    public float limiteDerecha = 3f;
    public float limiteIzquierda = 3f;
    private Vector3 posLimitDcha;
    private Vector3 posLimitIzda;
    private bool dirFantasmaDerecha = true;
    private Vector3 posInicial;


    private string estadoFantasma = "Patrol";
    private GameObject player;
    private float distancia;
    public float distanciaAtaque = 5f;
    public float distanciaPatrol = 15;
    public float velocidadAtaque = 2f;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;

        posLimitDcha = posInicial + new Vector3(limiteDerecha, 0, 0);
        posLimitIzda = posInicial - new Vector3(limiteIzquierda, 0, 0);


        // posLimitDcha = posInicial +  new Vector3(posInicial.x + limiteDerecha, posInicial.y, 0);
        // posLimitIzda = posInicial -  new Vector3(posInicial.x - limiteIzquierda, posInicial.y, 0);

        player = GameObject.FindWithTag("Player");


    }

    // Update is called once per frame
    void Update()
    {
        if (vidaFantasma <= 0)
        {
            Destroy(this.gameObject);
        }


        distancia = Vector3.Distance(transform.position, player.transform.position);

        if (distancia <= distanciaAtaque)
        {
            estadoFantasma = "Ataque";
        }


            Debug.Log(distancia + estadoFantasma);
        //////////
        /// /////
        /// // ///



        if (estadoFantasma == "Patrol")
        {
            //*** * estamos flotando hacia la drecha**/
            if (dirFantasmaDerecha == true)
            {
                transform.Translate(velocidad * Time.deltaTime, 0, 0);
            }



            //*** * estamos flotando hacia la izquierda**/
            if (dirFantasmaDerecha == false)
            {
                transform.Translate((velocidad * Time.deltaTime) * -1, 0, 0);
            }


            //*** comprobar si nos hemos salido del limite derecho**/
            if (transform.position.x >= posLimitDcha.x)
            {
                dirFantasmaDerecha = false;
                this.GetComponent<SpriteRenderer>().flipX = true;
            }

            //*** comprobar si nos hemos salido del limite izquierda**/
            if (transform.position.x <= posLimitIzda.x)
            {
                dirFantasmaDerecha = true;
                this.GetComponent<SpriteRenderer>().flipX = false;
            }
        }

         


        if(estadoFantasma == "Ataque"){
            transform.position = Vector3.MoveTowards
            (transform.position, player.transform.position, velocidadAtaque *Time.deltaTime
            );

            // ***fantasma gira en el ataque
            if(player.transform.position.x <= transform.position.x){
                this.GetComponent<SpriteRenderer>().flipX = false;
            }else{
                 this.GetComponent<SpriteRenderer>().flipX = true;
 
            }


            // *** si estoy muy lejos (15) el fantasma vuelve a patrullar
            if(distancia >= distanciaPatrol){
                estadoFantasma = "Patrol";
            }
        }

    }

// *** squita una vida si colisiona
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player"){
            
            GameManager.vidas -= 1;
        }
    }


}
