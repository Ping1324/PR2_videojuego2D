using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour
{
     
    public int valor = 1;
    GameObject audioManajerObj;
    
    // Start is called before the first frame update
    void Start()
    {
        audioManajerObj = GameObject.Find("AudioManajerObj");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
         if(col.tag == "Player"){

            GameManager.marcador = GameManager.marcador+valor;

            this.GetComponent<Animator>().SetBool("destruirMoneda", true);

        
            AudioManagerScript.Instance.SuenaClip(AudioManagerScript.Instance.moneda);

             Destroy(this.gameObject, 1.0f);
              // hace referencia al mismo script y se destruye en 1segundo
        }

    }
    
    } 


