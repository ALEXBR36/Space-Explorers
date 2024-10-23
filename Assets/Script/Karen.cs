using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karen : MonoBehaviour
{
    Animator animator; //refernces the animator and allows me to access it

    public GameObject dialogue; //allows me to put in what dialogue gameobject I want in the inspector as it is public

    public void Start() //on start
    {
        dialogue.SetActive(false); //set the dialogue to be unseen in the scene

        animator = GetComponent<Animator>(); //attatch the animator to gameobject
    }
    public void DisplayDialogue() //when this function is called
    {
        dialogue.SetActive(true); //set the dialogue to be visible in scene

        animator.SetBool("karen", true); //set the bool karen to be true in the animator so the animation plays
    }
  
}
