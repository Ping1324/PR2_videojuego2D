using System.Collections;
using System.Collections.Generic;
using UnityEditor;

//using System.Numerics;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    public float velocidad = 5f;
    public float multiplicador = 5f;
    public float multiplicadorSalto = 5f; //Controla la fuerza del salto.
    private bool puedoSaltar = true;
    private Rigidbody2D rb; //clase de tipo rigidbody2d
    private Animator animatorController;
    GameObject respawn;
    
    public bool direccionBalaDcha = true;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();//Aquí se obtiene el componente Rigidbody2D del GameObject al que está adjunto este script y se almacena en la variable rb.

        animatorController = this.GetComponent<Animator>();

        respawn = GameObject.Find("Respawn"); //acede al objeto

        transform.position = respawn.transform.position;
    


    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.estoyMuerto) return;


        //MOVIMIENTO
        float movTeclas = Input.GetAxis("Horizontal"); //Aquí se obtiene la entrada del jugador para mover el personaje a la izquierda o a la derecha. Si el jugador presiona la tecla "A" o la flecha izquierda, movTeclas será negativo. Si presiona "D" o la flecha derecha, será positivo. Devuelve un valor entre -1 y 1.
        rb.velocity = new Vector2(movTeclas * multiplicador, rb.velocity.y);



        // ***MOV IZQ <--- ***//
        //* imput.get axit devuelve valores negativos o positivos, por ello si es <0 mirara a la izquierda y la drección de la bala será hacia la izq//
        if (movTeclas < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true; 
            direccionBalaDcha = false;                                          
                                                
        }
        else if (movTeclas > 0)
        {
         // ***MOV DERE ---> ***//
            this.GetComponent<SpriteRenderer>().flipX = false; // Voltea a la derecha 
            direccionBalaDcha =true;   
        }


         // ***ANIM WALKING ---> ***//
        if (movTeclas != 0)
        {
            animatorController.SetBool("activaCaminar", true);
        }
        else
        {
            animatorController.SetBool("activaCaminar", false);
        }






        // ***SALTO ---> ***//
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 2f); //En hit se guarda la ino. En Physics2D.Raycast → Lanza un rayo en 2D.(desde la pos.pj haacia abajo con una dist de 2 unidades)
        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        if (hit)
        {
            puedoSaltar = true;
            //Debug.Log(hit.collider.name);
        }
        else
        {
            puedoSaltar = false;
        }


        if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar)
        {
            rb.AddForce(new Vector2(0, multiplicadorSalto), ForceMode2D.Impulse);
        }

        // ***COMPROBAR SI ME HE SALIDO DE LA PANTALLA (POR ABAJO)  ***//
        if(transform.position.y <= -12){
            Respawnear();
        }




        // *** 0 VIDAS ***//
        if(GameManager.vidas <= 0){
            GameManager.estoyMuerto = true;
        }




    }



  // *** RESPAWN ***//
    public void Respawnear(){

        Debug.Log("vidas: "+GameManager.vidas);

        GameManager.vidas = GameManager.vidas -1;

        Debug.Log("vidas: "+GameManager.vidas);

        transform.position = respawn.transform.position;
    }

  

}
