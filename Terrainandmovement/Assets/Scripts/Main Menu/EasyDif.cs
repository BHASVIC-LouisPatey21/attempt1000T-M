using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyDif : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void EasyModeSelect()
    {
        GenerateEnemies.EasyMode = true;
    }
    public void MediumModeSelect()
    {
        GenerateEnemies.MediumMode = true;
    }
    public void HardModeSelect()
    {
        GenerateEnemies.HardMode = true;
    }
}
