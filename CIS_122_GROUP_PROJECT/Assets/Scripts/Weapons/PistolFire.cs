using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    public GameObject blackPistol;
    public bool isFiring = false;
    public GameObject muzzleflash;
    public AudioSource pistolShot;
    public Camera fpsCam;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FireThePistol());
            }
            Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 10);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                // lOG
                Debug.Log("You hit " + objectHit.gameObject.name);
                if (objectHit.gameObject.tag == "Enemy")
                {
                    Destroy(objectHit.gameObject);
                }
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
        isFiring = false;
    }
}