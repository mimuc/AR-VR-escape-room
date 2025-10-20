using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateID : MonoBehaviour
{
    public int id = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Saving ID for each game
        id = PlayerPrefs.GetInt("ID", 0);
        id = id + 1;
        PlayerPrefs.SetInt("ID", id);
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
