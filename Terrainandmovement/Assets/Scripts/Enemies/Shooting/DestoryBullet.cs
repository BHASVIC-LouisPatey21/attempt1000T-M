using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestoryBullet : MonoBehaviour
{
    public AudioSource TakeDamage;
      
    public void OnCollisionEnter(Collision collision){
    if(collision.gameObject.tag == "Player")
    {
        PlayerInfo.Health--;
        TakeDamage.Play();
    }
    Destroy(this.gameObject);
    }
    
}
