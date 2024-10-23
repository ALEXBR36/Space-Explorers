using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public static bool playerInZone; //true or false whether player is in zone or not
    private static float timer; //sets a float which is a number 


    public void OnTriggerEnter2D(Collider2D collision) //when this gameobject collides when something and is triggered
    {
        if (SpacemanVenus.paused == false) //check if the pause menu is active
        {
            playerInZone = true; //if not set the player to be in zone, so that theu continue to take damage
            timer = 0; //resets timer
            Debug.Log("in zone"); //show in console
        }
    }

    public void OnTriggerExit2D(Collider2D collision) //on collison with the gameobject (damage zone)
    {
        playerInZone = false; //since we already checked if it is false, we can now be sure that the pause menu is active so set the playerInZone to be false and player cannot be damaged
    }

    public void Update() //every frame
    {

        if (playerInZone == true) //if player is in the zone as determined above
        {
            timer += Time.deltaTime; //adds a value of time each frame that can be tracked to allow the code to know when to function

            if (timer > 12 && SpacemanVenus.paused == false) //if this timer is above 12 and the pause menu isn't active, it does what's below
            {
                GameObject.Find("SpacemanMainCharacter").GetComponent<SpacemanVenus>().Damage(1); //initiates the function to damage the player in Spaceman Venus. What this actaully does is add one value to the flame bar, whcih is bad for the player
                timer = 0; //set timer to zero so code begins again and player isn't constantly being damaged
                Debug.Log("timer 0"); //show in console that timer has been reset
            }
        }
    }
}
