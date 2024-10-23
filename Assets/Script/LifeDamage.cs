using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDamage : MonoBehaviour
{
    private static bool playerInZone; //a true or false that is whether or not the player is in the zone
    private static float timer; //set a timer 

    public void OnTriggerEnter2D(Collider2D collision) //when this gameobject collides
    {
        if (SpacemanVenus.paused == false) //checks if the pause menu is active
        {
            playerInZone = true; //if not active set player to be in zone so they take damage
            timer = 0; //reset timer so the player doesn't repeatably take damage
            Debug.Log("in zone"); //sends message to console which can be viewed in game
        }
    }

    public void OnTriggerExit2D(Collider2D collision) //on collison (gameobject must be set to a trigger)
    {
        playerInZone = false; //set player in zone to be false meaning that the game is in pause menu
    }

    public void Update() //every frame
    {

        if (playerInZone == true) //if player is in zone
        {
            timer += Time.deltaTime; //adds a value of time each frame that can be tracked to allow the code to know when to function

            if (timer > 1 && SpacemanVenus.paused == false) //if the timer is more than one, and the game isn't paused do whats below
            {
                GameObject.Find("SpacemanMainCharacter").GetComponent<SpacemanVenus>().LifeDamage(-1); //find the spaceman script and take away one amount from life
                timer = 0; //reset timer to zero so this doesn't continuously happen
                Debug.Log("timer 0"); //send message to console
            }
        }
    }
}
