using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioNivel1 : MonoBehaviour
{
    private GameObject personaje;
    private bool isPlayerinRange;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("mage");
    }

    void Update()
    {
        if (isPlayerinRange && Input.GetKeyDown(KeyCode.F)){
            
            SceneManager.LoadScene("4_Escena1");// Asegúrate que el nombre sea exacto
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
            isPlayerinRange = true;
            //dialogueMark.SetActive(true);
        
    }

    void OnTriggerExit2D(Collider2D col){
        if(col.name == "mage"){
            isPlayerinRange = false;}
            //dialogueMark.SetActive(false);
        
    }

    public void InicioStart(){
        SceneManager.LoadScene("4_Escena1");
    }
}

