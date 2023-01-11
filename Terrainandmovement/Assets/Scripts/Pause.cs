using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            CursorHandle();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void CursorHandle()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
