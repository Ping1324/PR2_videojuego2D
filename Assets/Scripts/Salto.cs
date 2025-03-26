using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

//using System.Numerics;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public float numero1 =20.76f;
    public float numero2 = 80f;
    public Vector3 posInicial;
    public Color micolor;

    public float velocidad = 0.0001f;
    


    void Start() //devuleve void (nada) y no le pasamos ningún argumento
    {
        this.GetComponent<Transform>().position = posInicial;     
        this.GetComponent<SpriteRenderer>().flipX = true;
    }


    void Update(){

        if(Input.GetKey(KeyCode.A)){
            transform.Translate(velocidad*-1,0,0 ) ;
        }

        if(Input.GetKey(KeyCode.D)){
            transform.Translate(velocidad,0,0) ;
        }

        // float positionActual = this.GetComponent<Transform>().position.x; //x,y,z
        // transform.position = new Vector3(positionActual+0.001f, 0, 0); //acede desde el transform al posicion y se le asigna un valor, que es el nuw vector 3
        // this.GetComponent<SpriteRenderer>().color = micolor;

        //transform.Translate(velocidad,velocidad,0);
        //transform.Rotate(0,0,velocidad);

        //transform.localScale = new Vector3(velocidad, 1.0f, 0);
    }


       
 }





        

