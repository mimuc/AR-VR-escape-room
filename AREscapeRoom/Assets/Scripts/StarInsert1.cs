using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarInsert1 : MonoBehaviour
{
    public GameObject star1;

    public GameObject starTemplate1;

    public Material Yellow;

    public bool star1Inserted;

    public AudioSource achievementSound;

    // Start is called before the first frame update
    void Start()
    {
        star1Inserted = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == star1)
        {
            achievementSound.Play();
            star1.SetActive(false);
            starTemplate1.GetComponent<MeshRenderer>().material = Yellow;
            star1Inserted = true;
        }
    }
}
