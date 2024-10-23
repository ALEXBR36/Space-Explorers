    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //when the player collides with this gameobject
    {
        SceneManager.LoadSceneAsync(3); //lload scene 3 as per project settings
        Debug.Log("Colliderr Happening?"); //send message to console
    }
}
