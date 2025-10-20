using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CompleteCeilingPuzzle : MonoBehaviour
{
    public GameObject Sphericals;
    public GameObject BlinkingLEDs;

    public GameObject wrongBulb1;
    public GameObject wrongBulb2;
    public GameObject wrongBulb3;
    public GameObject wrongBulb4;

    public Material Black;

    public bool ceilingPuzzleWon;

    public AudioSource shimmer;
    public bool shimmersoundPlayed;

    [SerializeField] StarInsert1 insert1;
    [SerializeField] StarInsert2 insert2;
    [SerializeField] StarInsert3 insert3;

    // Start is called before the first frame update
    void Start()
    {
        Sphericals.SetActive(false);
        BlinkingLEDs.SetActive(false);
        ceilingPuzzleWon = false;
        shimmersoundPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (insert1.star1Inserted == true && insert2.star2Inserted == true && insert3.star3Inserted == true) 
        { 
            Sphericals.SetActive(true);
            BlinkingLEDs.SetActive(true);
            ceilingPuzzleWon = true;
            playShimmerSound();

            wrongBulb1.GetComponent<MeshRenderer>().material = Black;
            wrongBulb2.GetComponent<MeshRenderer>().material = Black;
            wrongBulb3.GetComponent<MeshRenderer>().material = Black;
            wrongBulb4.GetComponent<MeshRenderer>().material = Black;
        }
    }

    public void playShimmerSound()
    {
        if (shimmersoundPlayed == false)
        {
            shimmer.Play();
            shimmersoundPlayed = true;
        }
    }
}
