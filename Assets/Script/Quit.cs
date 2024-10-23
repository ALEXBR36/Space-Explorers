using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void Quitter() //when button pressed
    {
        SceneManager.LoadSceneAsync(9); //loads scene 2
    }
}
