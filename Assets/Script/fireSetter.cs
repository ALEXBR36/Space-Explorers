using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSetter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("SpacemanMainCharacter").GetComponent<SpacemanVenus>().Damage(-3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
