using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    public Text getScore;
    public Text getLevel;
    public int totalScore;
    public int totalLevel;
    void Start()
    {
        
    }

    
    void Update()
    {
        totalLevel = GenerateEnemies.Level;
        getLevel.text = totalLevel.ToString();
        totalScore = Weapon.Score;
        getScore.text = totalScore.ToString();
    }
}
