using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    Rigidbody2D body; //refernces the rigidbody and allows me to access it easily 
    Animator animators;//refernces the animator and allows me to access it easily 

    public void Start() //on start
    {
        animators = GetComponent<Animator>(); //essentially attatches the two components to the gameobject
        body = GetComponent<Rigidbody2D>();

        
    }
    void OnTriggerEnter2D(Collider2D collision) //when this gameobject is collided with do whats below
    {
        Debug.Log("Collided"); //send to console the message that it has collided
        GameObject.Find("SpacemanMainCharacter").GetComponent<SpacemanVenus>().LifeDamage(5); //find the spaceman character and it's script and call the lifeDamage fucntion and add five to it.

        animators.SetBool("OXYGEM", true); //sets the bool is the animations to be true meaning the animation changes
        Debug.Log("triggereD"); //sends message to console

        StartCoroutine(TimeUntilDestroy()); //starts a coroutine
    }
    IEnumerator TimeUntilDestroy() //said coroutine
    {
        yield return new WaitForSeconds(2); //waits for two seconds so the animation can be seen
        Destroy(this.gameObject); //then destroy this gameobject
    }
}
