using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StarInsert2 : MonoBehaviour
{
    public GameObject star2;
    public GameObject star2a;
    public GameObject star2b;
    public GameObject star2c;
    public GameObject star2d;

    public GameObject starTemplate2;

    public Material Yellow;

    public bool star2Inserted;

    public AudioSource achievementSound;

    // Start is called before the first frame update
    void Start()
    {
        star2Inserted = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == star2 || collision.gameObject == star2a || collision.gameObject == star2b || collision.gameObject == star2c || collision.gameObject == star2d)
        {
            achievementSound.Play();
            star2.SetActive(false);
            star2a.SetActive(false);
            star2b.SetActive(false);
            star2c.SetActive(false);
            star2d.SetActive(false);
            starTemplate2.GetComponent<MeshRenderer>().material = Yellow;
            star2Inserted = true;
        }
    }
}
