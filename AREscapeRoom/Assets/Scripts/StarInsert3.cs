using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarInsert3 : MonoBehaviour
{
    public GameObject star3;

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
        if (collision.gameObject == star3)
        {
            achievementSound.Play();
            star3.SetActive(false);
            starTemplate3.GetComponent<MeshRenderer>().material = Yellow;
            star3Inserted = true;
        }
    }
}
