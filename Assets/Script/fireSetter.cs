using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("SpacemanMainCharacter").GetComponent<SpacemanVenus>().Damage(-3); //this is purely used to set the value of the flame on venus, it is purely visual for the player to see what hotness level venus is. Does this by called the damage function and minusing ine and setting it to 2
    }

}
