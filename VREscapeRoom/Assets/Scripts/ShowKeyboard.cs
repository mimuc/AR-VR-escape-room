using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;

public class ShowKeyboard : MonoBehaviour
{

    private TMP_InputField inputField;

    public AudioSource achievementSound;
    public AudioSource wrongSound;

    public GameObject winUI;
    public GameObject input;

    public bool gameWon = false;


    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        inputField.onSelect.AddListener(x => OpenKeyboard());

        winUI.SetActive(false);
        input.SetActive(true);
    }

    // Update is called once per frame
    public void OpenKeyboard()
    {
        NonNativeKeyboard.Instance.InputField = inputField;
        NonNativeKeyboard.Instance.PresentKeyboard(inputField.text);

        SetCaretColorAlpha(1);

        NonNativeKeyboard.Instance.OnClosed += Instance_OnClosed;
        NonNativeKeyboard.Instance.OnTextSubmitted += CheckPassword;
    }

    private void Instance_OnClosed(object sender, System.EventArgs e)
    {
        SetCaretColorAlpha(0);
        NonNativeKeyboard.Instance.OnClosed -= Instance_OnClosed;
    }

    public void SetCaretColorAlpha(float value)
    {
        inputField.customCaretColor = true;
        Color caretColor = inputField.caretColor;
        caretColor.a = value;
        inputField.caretColor = caretColor;
    }

    public void CheckPassword(object sender, System.EventArgs e)
    {

        if(NonNativeKeyboard.Instance.InputField.text == "02031991")
        {
            achievementSound.Play();
            winUI.SetActive(true);
            input.SetActive(false);
            gameWon = true;
        }
        else
        {
            Debug.Log("Wrong!");
            wrongSound.Play();
        }
    }
}
