using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{

    public int vidaFantasma =10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaFantasma <= 0){
            Destroy(this.gameObject);
        }
    }
}
