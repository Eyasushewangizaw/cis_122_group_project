using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    public GameObject blackPistol;
    public bool isFiring = false;


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
        yield return new WaitForSeconds(0.25f);
        blackPistol.GetComponent<Animator>().Play("New State");
        isFiring=false;
    }
}
