using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal : MonoBehaviour
{
    public string LevelName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        SceneManager.LoadScene(LevelName);
    }
}
