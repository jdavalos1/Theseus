using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Quiz CurrentQuiz;
    private bool quizStarted;

    public static GameManager SharedInstance;
    // Start is called before the first frame update
    void Start()
    {
        if (SharedInstance == null) SharedInstance = this;
        StartQuiz();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void StartQuiz()
    {
        if(CurrentQuiz == null) CurrentQuiz = new Quiz();
        Debug.Log("Starting the quiz");
    }
}
