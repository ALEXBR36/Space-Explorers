using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSetterEarth : MonoBehaviour
{
    GameObject.Find("SpacemanMainCharacter").GetComponent<SpacemanVenus>().Damage(-3);
}
