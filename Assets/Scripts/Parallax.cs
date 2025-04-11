using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    GameObject player;
    GameObject caamara;
    public float velocidadParallax =0.3f;
    private Vector3 positionInicial;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        caamara = GameObject.FindWithTag("MainCamera");
        positionInicial= transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //** el fondo se mueve la mitad de lento que el personaje. 
        //transform.position = new Vector3(caamara.transform.position.x / velocidadParallax,0,0);
        //transform.position = new Vector3(caamara.transform.position.x / velocidadParallax,0,0);
        
        //transform.position= positionInicial + caamara.transform.position;
        // transform.position = new Vector3(
        //     positionInicial.x + (caamara.transform.position.x*velocidadParallax),0,0);

        transform.position = new Vector3(
            positionInicial.x + (caamara.transform.position.x * velocidadParallax),
            positionInicial.y,
            0);

    }

}
