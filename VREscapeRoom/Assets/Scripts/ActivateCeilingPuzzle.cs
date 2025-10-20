using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCeilingPuzzle : MonoBehaviour
{
    public GameObject ceilingPuzzle;
    public GameObject lamp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lamp.activeInHierarchy == false)
        {
            ceilingPuzzle.SetActive(true);
        }
        else if (lamp.activeInHierarchy == true)
        {
            ceilingPuzzle.SetActive(false);
        }
    }
}
