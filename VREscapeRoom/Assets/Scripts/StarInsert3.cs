using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StarInsert3 : MonoBehaviour
{
    public GameObject star3;
    public GameObject star3a;
    public GameObject star3b;
    public GameObject star3c;
    public GameObject star3d;

    public GameObject starTemplate3;

    public Material Yellow;

    public bool star3Inserted;

    public AudioSource achievementSound;

    // Start is called before the first frame update
    void Start()
    {
        star3Inserted = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == star3 || collision.gameObject == star3a || collision.gameObject == star3b || collision.gameObject == star3c || collision.gameObject == star3d)
        {
            achievementSound.Play();
            star3.SetActive(false);
            star3a.SetActive(false);
            star3b.SetActive(false);
            star3c.SetActive(false);
            star3d.SetActive(false);
            starTemplate3.GetComponent<MeshRenderer>().material = Yellow;
            star3Inserted = true;
        }
    }
}
