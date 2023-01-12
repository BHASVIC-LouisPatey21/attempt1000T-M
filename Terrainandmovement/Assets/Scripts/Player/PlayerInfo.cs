using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    
    public static int Health;
    void Start()
    {
        Health = 10;
    }

    public void Hurt()
    {
        Health -=1;

    }
    void Update()
    {
        Debug.Log("Health: " + Health);
    }
    

}
