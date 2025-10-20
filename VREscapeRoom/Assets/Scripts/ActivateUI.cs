using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUI : MonoBehaviour
{
    public GameObject player;
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        ui.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == player)
        {
            ui.SetActive(true);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject == player)
        {
            ui.SetActive(false);
        }
    }
}
