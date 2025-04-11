using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaEstado : MonoBehaviour
{

    private GameObject miPanel;

    void Start()
    {
        miPanel = GameObject.Find("Panel");
        miPanel.SetActive(false);
    }
    public void ActivaPanel(){
        if(miPanel.activeSelf == true){
            miPanel.SetActive(false);
            }else{
                miPanel.SetActive(true);
            }
    }


}
