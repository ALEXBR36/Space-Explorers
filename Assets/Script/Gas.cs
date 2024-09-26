using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    Rigidbody2D body;
    Animator animators;
    public void Start()
    {
        animators = GetComponent<Animator>(); 
        body = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided");
        GameObject.Find("SpacemanMainCharacter").GetComponent<SpacemanVenus>().LifeDamage(5);

        animators.SetBool("OXYGEM", true);
        Debug.Log("triggereD");
    }
}
