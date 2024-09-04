using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VenusCollider : MonoBehaviour
{
    KarenVenus karen;
    // Start is called before the first frame update
    void Start()
    {
        karen = GetComponent<KarenVenus>();
    }

    // Update is called once per frame

    public void OnTriggerEnter2D(Collider2D collision)
    {
        karen.DialogueRandomiser();
    }
}
