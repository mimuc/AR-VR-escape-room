using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCeilingPuzzle : MonoBehaviour
{
    public GameObject Sphericals;
    public GameObject BlinkingLEDs;
    public GameObject passwordCanvas;

    public bool ceilingPuzzleWon = false;

    [SerializeField] StarInsert1 insert1;
    [SerializeField] StarInsert2 insert2;
    [SerializeField] StarInsert3 insert3;

    // Start is called before the first frame update
    void Start()
    {
        Sphericals.SetActive(false);
        BlinkingLEDs.SetActive(false);
        passwordCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (insert1.star1Inserted == true && insert2.star2Inserted == true && insert3.star3Inserted == true) 
        { 
            Sphericals.SetActive(true);
            BlinkingLEDs.SetActive(true);
            passwordCanvas.SetActive(true);

            ceilingPuzzleWon = true;
        }
    }
}
