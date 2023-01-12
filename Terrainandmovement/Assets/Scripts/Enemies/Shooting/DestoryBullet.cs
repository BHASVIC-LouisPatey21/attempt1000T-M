using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBullet : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision){
    


    if(collision.gameObject.tag == "Player")
    {
        PlayerInfo.Health = PlayerInfo.Health-1;
    }




    Destroy(this.gameObject);
    }
}
