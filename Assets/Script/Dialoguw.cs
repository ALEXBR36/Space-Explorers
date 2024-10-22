using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialoguw : MonoBehaviour
{
    public TextMeshProUGUI text; //naimg the variables
    public string[] lines; //array which holds dialogue
    public float textspeed; //contols speed of text

    private int index; //tracks the line being displayed

    // Start is called before the first frame update
    void Start() 
    {
        text.text = string.Empty; //starts text by being empty
        StartDialogue(); //calls this function
    }

    // Update is called once per frame
    public void Work() //used to register button click
    {
        {
            if (text.text == lines[index]) //checks if line is fully finsihed
            {
                NextLine(); //if so calls the next line
            }
            else
            {
                StopAllCoroutines(); //if not it stops all
                text.text = lines[index]; //displays current line immedietly
            }
        }
    }

    void StartDialogue()
    {
        index = 0; //sets to first line
        StartCoroutine(TypeLine()); //starts coroutine
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray()) //all this adds a charcter to the text and waits in between whatever the text speed is
        {
            text.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }
    void NextLine()
    {
        if (index < lines.Length - 1) //advances to next if more lines are left to go
        {
            index++; //next
            text.text = string.Empty; //clears the previous line of text
            StartCoroutine(TypeLine()); //starts next line
        }
        else
        {
            gameObject.SetActive(false); //ends dialogue
        }
    }
}
