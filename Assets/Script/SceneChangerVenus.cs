using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerVenus : MonoBehaviour
{
    public float ChangeTime;
    public string SceneName;

    private void Update()
    {
        ChangeTime -= Time.deltaTime;

        if (ChangeTime < 0)
            SceneManager.LoadScene(SceneName);

        
    }
}
