using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour
{

    GameObject panelSettings;
    GameObject AudioManagerObj;

    //*llama al scrip de AudioManager desde InicoScript, se llamará audioManagerScript. (un objeto de tipo audioManager)
    public AudioManagerScript audioManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        panelSettings = GameObject.Find("PanelSettings");
        panelSettings.SetActive(false);

        AudioManagerObj = GameObject.Find("AudioManagerObj");
        //*esto es para llamar al audio audiomangermusica que está dentro del AudioManagerObj
        audioManagerScript = AudioManagerObj.GetComponent<AudioManagerScript>();
    }
    
    public void SuenaBoton(){
        audioManagerScript.m_audioSource.PlayOneShot(audioManagerScript.moneda);
    }


    public void InicioStart(){
        SceneManager.LoadScene("Escena1");
    }

    public void MuestraSettings(){
         panelSettings.SetActive (true);      
          
    }

    public void OcultarSettings(){
        panelSettings.SetActive (false);     
       
    }

    public void SalirJuego(){
         Application.Quit();
    }

    
}
