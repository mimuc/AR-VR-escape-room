using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameUIManager : MonoBehaviour
{
    public GameObject ui;

    public Transform head;
    public float spawnDistance = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ui.transform.LookAt(new Vector3(head.position.x, ui.transform.position.y, head.position.z));
        ui.transform.forward *= -1;
    }
}
