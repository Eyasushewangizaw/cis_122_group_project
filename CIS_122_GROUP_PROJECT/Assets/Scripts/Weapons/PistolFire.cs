using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    public GameObject blackPistol;
    public bool isFiring = false;
    public GameObject muzzleflash;
    public AudioSource pistolShot;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FireThePistol());
            }
        }
        
    }
    IEnumerator FireThePistol()
    {
        isFiring = true;
        blackPistol.GetComponent<Animator>().Play("FirePistol");
        pistolShot.Play();
        muzzleflash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        muzzleflash.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        blackPistol.GetComponent<Animator>().Play("New State");
        isFiring=false;
    }
}
