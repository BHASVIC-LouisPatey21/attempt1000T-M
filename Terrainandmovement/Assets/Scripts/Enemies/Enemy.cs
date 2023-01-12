using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject paintballPrefab;
    private GameObject _paintball;
    void Start()
    {
        
    }

    
    void Update()
    {
        Ray ray = new Ray (transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.SphereCast (ray, 0.75f, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;

            if(hitObject.GetComponent<PlayerInfo>()) 
            {
                if(_paintball == null)
                {
                    _paintball = Instantiate (paintballPrefab) as GameObject;
                    _paintball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                    _paintball.transform.rotation = transform.rotation;
                }
            }
            else if (hit.distance < 1000) {
                float angle = Random.Range (-180, 180);
                transform.Rotate(0, angle , 0);
            }
        }
    }
}
