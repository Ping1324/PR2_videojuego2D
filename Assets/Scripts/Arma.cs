using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //*al pulsar tecla e, se clona desde la posición del jugador, para no rotarlo se añade quaternion.identity
        if(Input.GetKeyDown(KeyCode.E)){
            Instantiate(bala, transform.position, Quaternion.identity);
            // Quaternion.identity es la rotacion que tenga la bola
        }



    }
}
