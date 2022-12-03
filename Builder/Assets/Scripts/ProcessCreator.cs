using System;
using System.Diagnostics;
using UnityEngine;

public class ProcessCreator : MonoBehaviour
{
    private void Start()
    {
        using (Process myProcess = new Process())
        {
            myProcess.StartInfo.FileName = "C:/Users/Ivan/Desktop/SomeTest.txt";
            myProcess.Start();
        }
    }
}