using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitLevel : MonoBehaviour
{
    GameObject ButtonQuit;
    // Start is called before the first frame update
    void Start()
    {
       GameObject.Find("ButtonQuit"); 
    }

    public void ExitScene(){
        SceneManager.LoadScene("3_Lobby01");
    }
}
