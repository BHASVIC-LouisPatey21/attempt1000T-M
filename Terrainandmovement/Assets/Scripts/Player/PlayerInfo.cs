using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerInfo : MonoBehaviour
{
    
    public static int Health =3;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;

    void Update()
    {
        if(GenerateEnemies.TempScore == 0)
        {
            Health = 3;
        }
        numOfHearts = Health;
        if(Health > numOfHearts)
        {
            Health = numOfHearts;
        }
        
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }


            else 
            {
                hearts[i].enabled = false;
            }
        }

    if (Health == 0)
    {
        FindObjectOfType<GameManager>().EndGame();
        
    }
    }
    
    

}