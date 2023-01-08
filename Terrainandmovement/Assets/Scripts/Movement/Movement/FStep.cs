using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FStep : MonoBehaviour
{
public AudioSource FootStep;

void Update() 
{
if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) ) {
    FootStep.enabled = true;
}
else
{
    FootStep.enabled = false;
}
}
}
