using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottella : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //when the bottle collides with anything (used collison matrix to make sure it was only the player)
    {
        GameObject.Find("SpacemanMainCharacter").GetComponent<SpacemanVenus>().Damage(-1); //find the spaceman main character gameobject and get the script and call the damage function with the amount -1. In this case it takes one away from the flame which is good for the player
        
        Destroy(this.gameObject); //destroy this gameobject so player cannot repeatingly claim this bottle
        Debug.Log("GameObject Destroyed"); //show in console
        

    }
}
