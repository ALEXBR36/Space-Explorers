using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarenVenus : MonoBehaviour
{
    public GameObject[] Dialogue; //creates an array which can be accessed in the inspector to contain different gameObjects

    private int randomNumber; //creates a new integer called randomNumber

    public void OnTriggerEnter2D(Collider2D collision) //on collison with anything 
    {
        Dialogue[0].gameObject.SetActive(false); //set the dialgoue number 0 to be false
        DialogueRandomiser(); //call the function
        Debug.Log(collision.name); //send message to console saying what it collided with
    }
    public void DialogueRandomiser() //said function
    {
        randomNumber = Random.Range(1, 3); //finds a random number between 1 and 2 as 0 has already been set to false

        Debug.Log(Dialogue[randomNumber]); //send to console what number was picked
        Dialogue[randomNumber].gameObject.SetActive(true); //set that random number gameobject in the arrow to be true

        StartCoroutine(TimeUntilFalse()); //start the coroutine

       
    }
    IEnumerator TimeUntilFalse() // Coroutine to handle timed deactivation
    {
        yield return new WaitForSeconds(2); // Wait for two seconds

        Dialogue[randomNumber].gameObject.SetActive(false); // Deactivate the dialogue

        // No need to stop the coroutine as it ends automatically
    }


}
