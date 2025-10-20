using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarInsert2 : MonoBehaviour
{
    public GameObject star2;

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
        if (collision.gameObject == star2)
        {
            achievementSound.Play();
            star2.SetActive(false);
            starTemplate2.GetComponent<MeshRenderer>().material = Yellow;
            star2Inserted = true;
        }
    }
}
