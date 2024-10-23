using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class volcano : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //when this gameobject collides
    {
        SceneManager.LoadSceneAsync(6); //load scene number 6
        Debug.Log("Colliderr Happening?"); //sends message to coonsole
    }
}
