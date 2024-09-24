using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;

public class KarenVenus : MonoBehaviour
{
    public GameObject[] Dialogue;

    public int randomNumber;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Dialogue[1].gameObject.SetActive(false);
        DialogueRandomiser();
        Debug.Log(collision.name);
    }
    public void DialogueRandomiser()
    {
        int randomNumber = Random.Range(0, 3);

        Debug.Log(Dialogue[randomNumber]);
        Dialogue[randomNumber].gameObject.SetActive(true);

        StartCoroutine(Timeuntilfalse());
    }
    IEnumerator Timeuntilfalse()
    {
        yield return new WaitForSeconds(2);

        Dialogue[randomNumber].gameObject.SetActive(false);
        
        StopCoroutine(Timeuntilfalse());
    }

}
