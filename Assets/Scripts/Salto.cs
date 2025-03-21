using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{

    //variables
    public int miEdad=8;
    public float miAltura = 6.5f;
    public string miNombre = "Mo hali ña";
    public bool tengoMelena    = false;

    public GameObject miCubo;




    // Start is called before the first frame update
    void Start()
    {
            Debug.Log("Hola mi nombre es "+miNombre+" y tengo "+miEdad+" años");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
