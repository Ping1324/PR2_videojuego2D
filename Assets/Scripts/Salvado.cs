using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salvado : MonoBehaviour
{

    private GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Ot2D(Collider2D collision)
    {
        spawn.transform.position = transform.position;
        GameManager.vidas = GameManager.vidas -1;

    }
}
