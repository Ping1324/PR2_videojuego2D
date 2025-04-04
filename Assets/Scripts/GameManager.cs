using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int vidas = 3;//a las variables estáticas se puede acceder desde cualquier lado
    public static int score = 0;
    public static bool estoyMuerto = false;
    public static int marcador = 0; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        Debug.Log("Monedas"+ marcador);
    }
}
