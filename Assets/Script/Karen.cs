using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karen : MonoBehaviour
{
    Animator animator;

    public GameObject dialogue;

    public void Start()
    {
        dialogue.SetActive(false);

        animator = GetComponent<Animator>();
    }
    public void DisplayDialogue()
    {
        dialogue.SetActive(true);

        animator.SetBool("karen", true);
    }
}
