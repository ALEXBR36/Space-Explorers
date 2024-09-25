using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottella : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("SpacemanMainCharacter").GetComponent<SpacemanVenus>().Damage(-1);
        
        Destroy(this.gameObject);
        Debug.Log("GameObject Destroyed");
        

    }
}
