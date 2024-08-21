using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karen : MonoBehaviour
{
    public GameObject dialogue;
    public void Start()
    {
        dialogue.SetActive(false);
    }
    public void DisplayDialogue()
    {
        dialogue.SetActive(true);
    }
}
