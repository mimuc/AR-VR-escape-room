using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableIntro : MonoBehaviour
{
    public GameObject introMenu;

    float TimeAmount;

    // Start is called before the first frame update
    void Start()
    {
        introMenu.SetActive(true);

        StartCoroutine(ToggleIntro(TimeAmount));
    }

    IEnumerator ToggleIntro(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(0);
            introMenu.SetActive(true);

            yield return new WaitForSeconds(10);
            introMenu.SetActive(false);
        }
    }
}
