using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DebugFile : MonoBehaviour
{
    [SerializeField] CreateID id;
    string filename = "";

    void OnEnable()
    {
        Application.logMessageReceived += Log;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= Log;
    }

    void Start()
    {
        filename = Application.dataPath + "/LogFileVR.text";
        Debug.Log(id.id);
        Debug.Log("Game started");
    }

    public void Log(string logString, string stackTrace, LogType type)
    {
        TextWriter tw = new StreamWriter(filename, true);

        tw.WriteLine("[" + System.DateTime.Now + "]" + logString);

        tw.Close();
    }
}
