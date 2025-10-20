using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WindowCurtainScript : MonoBehaviour
{
    public GameObject blindchain;
    public GameObject cube;
    public GameObject hint;

    public bool curtainOpened;


    // Start is called before the first frame update
    void Start()
    {
        curtainOpened = false;
    }
}
