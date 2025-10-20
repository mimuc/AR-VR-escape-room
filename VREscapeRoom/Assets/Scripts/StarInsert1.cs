using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarInsert1 : MonoBehaviour
{
    public GameObject star1;
    public GameObject star1a;
    public GameObject star1b;
    public GameObject star1c;
    public GameObject star1d;

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
        if (collision.gameObject == star1 || collision.gameObject == star1a || collision.gameObject == star1b || collision.gameObject == star1c || collision.gameObject == star1d)
        {
            achievementSound.Play();
            star1.SetActive(false);
            star1a.SetActive(false);
            star1b.SetActive(false);
            star1c.SetActive(false);
            star1d.SetActive(false);
            starTemplate1.GetComponent<MeshRenderer>().material = Yellow;
            star1Inserted = true;
        }
    }
}
