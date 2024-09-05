using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;

public class KarenVenus : MonoBehaviour
{
    public GameObject[] Dialogue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       DialogueRandomiser();
       Debug.Log(collision.name);
    }
    public void DialogueRandomiser()
    {
        int randomNumber = Random.Range(0, 3);

        Dialogue[randomNumber].gameObject.SetActive(true);  

        Debug.Log(Dialogue[randomNumber]);

    }
}
