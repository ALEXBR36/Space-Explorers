using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarenVenus : MonoBehaviour
{
    public GameObject[] Dialogue;
    public void DialogueRandomiser()
    {
        int randomNumber = Random.Range(0,3);
        Debug.Log(Dialogue[randomNumber]);

    }
}
