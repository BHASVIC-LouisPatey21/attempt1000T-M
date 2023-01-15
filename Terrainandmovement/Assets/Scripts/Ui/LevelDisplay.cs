using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDisplay : MonoBehaviour
{
    public GameObject DisplayLevel;

    void Update()
    {
        if(GenerateEnemies.DispLevel == true)
        {
            DisplayLevel.SetActive(true);
        }
        else if (GenerateEnemies.DispLevel == false)
        {
            DisplayLevel.SetActive(false);
        }
    }
}
