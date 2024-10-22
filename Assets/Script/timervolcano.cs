using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timervolcano : MonoBehaviour
{
    public float ChangeTime;

    private void Update()
    {
        ChangeTime -= Time.deltaTime;
        if (ChangeTime < 0)
        {
            SceneManager.LoadSceneAsync(7);
        }
    }
}
