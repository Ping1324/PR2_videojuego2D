using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource m_audioSource;
    public AudioClip bandaSonora;
    public AudioClip moneda;
    public AudioClip s_Fantasma;

    public GameObject musicObj; 

    AudioSource audioMusic;

    public static AudioManagerScript Instance;
    // Start is called before the first frame update
       //* para que en cuanto se despierte el objeto no destruya este objeto (la musica,  así seguirá la música mientras juegas)
     void Awake()
    {
       //* Verifica si ya existe una instancia y no es esta misma
       if(Instance != null && Instance != this){
        Destroy(this.gameObject); //destruye el duplicado
       }else{
        Instance = this;
        DontDestroyOnLoad(this.gameObject);// Asigna esta instancia como la principal y // No destruir al cargar nuevas escenas
       }

       DontDestroyOnLoad(this.gameObject); 
    }
    void Start()
    {
      m_audioSource = GetComponent<AudioSource>(); 


      audioMusic = musicObj.GetComponent<AudioSource>();
      
      //* cuando comience el juego el clip va a ser la banda sonora
      audioMusic.clip = bandaSonora;
      audioMusic.Play();
    
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
 

  //*método para hacer el sonido
    public void SuenaClip(AudioClip miClipDeAudio){
      m_audioSource.PlayOneShot(miClipDeAudio);
    }
}
