using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NewStarOnGrab : MonoBehaviour
{
    public GameObject star;

    public bool starSpawned;

    // Start is called before the first frame update
    void Start()
    {
        starSpawned = false;
        star.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(star.activeSelf == true)
        {
            starSpawned=true;
        }
    }
}
