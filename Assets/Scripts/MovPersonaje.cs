using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    public float multiplicador = 5f;
    public float multiplicadorSalto = 5f;
    private Rigidbody2D rb; //clase de tipo rigidbody2d
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//coge los componentes del elemeento del tipo rigidbody

    
    }

    // Update is called once per frame
    void Update()
    {
        float movTeclas = Input.GetAxis("Horizontal");

        float miDeltaTime = Time.deltaTime;

        transform.Translate(movTeclas * Time.deltaTime * multiplicador,0,0);

        if(Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(new Vector2 (0,multiplicadorSalto),ForceMode2D.Impulse);
        }
        
        
        



    }
}
