using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Weapon : MonoBehaviour
{

[Header("Ammunition")]
public int ammoCount = 30;
public Text ammoDisplay;
public float reloadTime = 1f;
private bool isReloading = false;

[Header("Game Feel")]
[SerializeField] ParticleSystem muzzleFlash;
[SerializeField] AudioSource ShootSound;
public AudioSource ReloadSound;

[Header("Raycast")]
[SerializeField] float weaponRange;
[SerializeField] float fireRate ;
public static int Score;


public Animator animator;
Camera mainCam;
bool canShoot = true;
float thresholdTime;



void Start()
{   

}
void Awake()
{
	//fetches the main camera and stores it in a variable
	mainCam = Camera.main; 
    

 
}




void Update()
{

    if(Input.GetMouseButton(0) && canShoot && GetAmmoCount() > 0 )
{
    Shoot();
    
}



ammoDisplay.text = ammoCount.ToString();



if (isReloading) {
    return;
    }
if (thresholdTime <= Time.time)
{
        canShoot = true;
        thresholdTime = Time.time + fireRate;
}
else
{
    canShoot = false;
}




if(ammoCount <=0 || Input.GetKey(KeyCode.R) && ammoCount <= 29)
    {
        StartCoroutine(Reload());
        return;
    }
}




IEnumerator Reload()
{
    isReloading = true;
    animator.SetBool("Reloading", true);
    ReloadSound.enabled = true;
    yield return new WaitForSeconds(reloadTime);
    animator.SetBool("Reloading", false);
    ReloadSound.enabled = false;
    ammoCount = 30;
    isReloading = false;
}

private void Shoot() 
{
HandleRaycast();
HandleMuzzleFlash();
GunSound();
ReduceAmmoCount();

}


public int GetAmmoCount()
{
    return ammoCount;
}



public void ReduceAmmoCount()
{
    ammoCount--;
}



private void HandleRaycast()
{
    RaycastHit hit;
if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit,100f))
{
if(hit.transform.tag == "enemy")
    {
        Destroy(hit.collider.gameObject);
        GenerateEnemies.TempScore++;
        Score++;
    }
}
}





private void HandleMuzzleFlash()
{
    if (muzzleFlash.isPlaying)
    muzzleFlash.Stop();
    muzzleFlash.Play();
}




private void GunSound()
{
    ShootSound = GetComponent<AudioSource>();
    ShootSound.Play();
}



private void SoundReload()
{
    ReloadSound = GetComponent<AudioSource>();
    ReloadSound.Play();


}




}
