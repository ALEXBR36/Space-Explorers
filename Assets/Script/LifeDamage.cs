using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDamage : MonoBehaviour
{
    private static bool playerInZone;
    private static float timer;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (SpacemanVenus.paused == false)
        {
            playerInZone = true;
            timer = 0;
            Debug.Log("in zone");
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        playerInZone = false;
    }

    public void Update()
    {

        if (playerInZone == true)
        {
            timer += Time.deltaTime;

            if (timer > 1 && SpacemanVenus.paused == false)
            {
                GameObject.Find("SpacemanMainCharacter").GetComponent<SpacemanVenus>().LifeDamage(-1);
                timer = 0;
                Debug.Log("timer 0");
            }
        }
    }
}
