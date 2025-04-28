using System.Collections;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    private bool isPlayerinRange;
    private GameObject personaje;

    [SerializeField] private GameObject dialogueMark; //marca de dialogo
    [SerializeField, TextArea(4,6)] private string[] dialogueLines;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;


    private bool didDialogueStart;
    private int lineIndex;

    [SerializeField] private float typingTime = 0.05f;

    void Start()
    {
       
        personaje = GameObject.Find("mage");
    }
    void Update()
    {
       if(isPlayerinRange && Input.GetKeyDown(KeyCode.F)){ //si el personaje está en el rango del trigguer y pulsas f
        if(!didDialogueStart){ //y el dialogo no ha empezado
            StartDialogue(); //se abre el panel y se escribe la primera linea
        }else if(dialogueText.text == dialogueLines[lineIndex]){//si el ya se ha iniciado, pasa a la sig. linea
            NextDialogueLine();
        }else{//si no se mostró la linea entera la muestra
            StopAllCoroutines();
            dialogueText.text = dialogueLines[lineIndex];
        }
       }
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.name == "mage"){
            isPlayerinRange = true;
            dialogueMark.SetActive(true);
        }
       
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.name == "mage"){
            isPlayerinRange = false;
            dialogueMark.SetActive(false);


        }
    }

    private void StartDialogue(){
        didDialogueStart= true;
        dialoguePanel.SetActive(true);
        dialogueMark.SetActive(false);
        lineIndex = 0;
        StartCoroutine(ShowLine());
        Time.timeScale = 0f;
    }

    private void NextDialogueLine(){
        lineIndex++;
        if(lineIndex < dialogueLines.Length){
            StartCoroutine(ShowLine());
        }else{
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
            dialogueMark.SetActive(true);
            Time.timeScale = 1f;
        }
    }
    private IEnumerator ShowLine(){
        dialogueText.text = string.Empty;
        foreach(char ch in dialogueLines[lineIndex]){ //loop, characteres escritos de uno a uno y que tarden un pelin en aparecer
            dialogueText.text += ch;
            yield return new WaitForSecondsRealtime(typingTime);
        }
    }


}
