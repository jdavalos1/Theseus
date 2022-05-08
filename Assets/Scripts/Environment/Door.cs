using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : FieldItems
{
    // Update is called once per frame
    void Update()
    {
        ShowAndInteract(StartQuiz);
    }

    private void StartQuiz()
    {
        Debug.Log("Starting");
    }
}
