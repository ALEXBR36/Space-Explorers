using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;

public class KarenVenus : MonoBehaviour
{
    public GameObject[] Dialogue;
    public void OnTriggerEnter2D(Collider2D collision)
    {
       DialogueRandomiser();
       Debug.Log(collision.name);
    }
    public void DialogueRandomiser()
    {
        int randomNumber = Random.Range(0, 3);

        Dialogue[randomNumber].gameObject.SetActive(true);
        


        if (Dialogue[randomNumber = 1])
        {
            Dialogue[randomNumber = 1].gameObject.SetActive(false);
            
        }

        Debug.Log(Dialogue[randomNumber]);

    }
}
