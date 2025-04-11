using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int vidas = 4;//a las variables estáticas se puede acceder desde cualquier lado
    public static int score = 0;
    public static bool estoyMuerto = false;
    public static int marcador = 0; 
    private GameObject vidasText;
    private GameObject scoreText;


    // Start is called before the first frame update
    void Start()
    {
        vidasText = GameObject.Find("TextVidas");
        scoreText = GameObject.Find("TextScore");
    }

    // Update is called once per frame
    void Update()
    {

        vidasText.GetComponent<TextMeshProUGUI> ().text = vidas.ToString();
        scoreText.GetComponent<TextMeshProUGUI> ().text = marcador.ToString();

        Debug.Log("Monedas"+ marcador);
    }
}
