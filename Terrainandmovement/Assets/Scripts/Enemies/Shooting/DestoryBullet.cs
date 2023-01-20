using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestoryBullet : MonoBehaviour
{

    void Start()
    {

    }
      
    void OnCollisionEnter(Collision collision){
    if(collision.gameObject.tag == "Player")
    {
        PlayerInfo.Health--;
        HurtSound.PlaySoundHurt = true;
        
    }
    Destroy(this.gameObject);
}
}
