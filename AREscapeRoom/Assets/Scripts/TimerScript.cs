using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Varjo.XR;

public class TimerScript : MonoBehaviour
{
    public bool timePuzzleOneStopped = false;
    public bool timePuzzleTwoStopped = false;
    public bool timePuzzleThreeStopped = false;
    public bool timeWholeGameStopped = false;

    public bool gameWon = false;

    public float timePuzzleOne;
    public float timePuzzleTwo;
    public float timePuzzleThree;
    public float timeWholeGame;

    [SerializeField] VarjoMarkerManger qr;
    [SerializeField] Countdown cd;
    [SerializeField] CompleteCeilingPuzzle p2;

    // Start is called before the first frame update
    void Start()
    {
        timePuzzleOne = 0;
        timePuzzleTwo = 0;
        timePuzzleThree = 0;
        timeWholeGame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var marker in qr.markers)
        {
            for (var i = 0; i < qr.trackedObjects.Length; i++)
            {
                if (qr.trackedObjects[i].id == marker.id)
                {
                    if (qr.trackedObjects[i].id == 201 && timePuzzleOneStopped == false)
                    {
                        timePuzzleOne = Time.time;
                        Debug.Log("Time for puzzle one: " + timePuzzleOne);
                        timePuzzleOneStopped = true;
                    }

                    if (p2.ceilingPuzzleWon == true && timePuzzleTwoStopped == false && timePuzzleOneStopped == true)
                    {
                        timePuzzleTwo = Time.time - timePuzzleOne;
                        Debug.Log("Time for puzzle two: " + timePuzzleTwo);
                        timePuzzleTwoStopped = true;
                    }

                    if (qr.trackedObjects[i].id == 210 && timePuzzleThreeStopped == false && timePuzzleTwoStopped == true)
                    {
                        timePuzzleThree = Time.time - timePuzzleTwo;
                        Debug.Log("Time for puzzle three: " + timePuzzleThree);
                        timePuzzleThreeStopped = true;
                    }
                }
            }
        }
        if (p2.ceilingPuzzleWon == true && timePuzzleTwoStopped == false && timePuzzleOneStopped == true)
        {
            timePuzzleTwo = Time.time - timePuzzleOne;
            Debug.Log("Time for puzzle two: " + timePuzzleTwo);
            timePuzzleTwoStopped = true;
        }

        if (timeWholeGameStopped == false && timePuzzleThreeStopped == true)
        {
            timeWholeGame = timePuzzleOne + timePuzzleTwo + timePuzzleThree;
            Debug.Log("Time for whole game: " + timeWholeGame);
            Debug.Log("Game Completed");
            timeWholeGameStopped = true;
            gameWon = true;
            cd.countdownStopped = true;
        }
        
    }
}
