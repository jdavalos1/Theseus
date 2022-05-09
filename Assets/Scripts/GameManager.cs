using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<Question> allQuestions;
    private Quiz quiz;
    private bool quizStarted;

    public static GameManager SharedInstance;
    // Start is called before the first frame update
    void Start()
    {
        if (SharedInstance == null) SharedInstance = this;
        allQuestions = new List<Question>();
        // TODO: Load all questions from JSON
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void StartQuiz()
    {
        // At least 5 questions will be needed. 3 can be wrong/right 2 right/wrong
        //List<Question> quizQuestions = allQuestions.GetRange(Random.Range(0, allQuestions.Count - 5), 5);

        //quiz = new Quiz(quizQuestions);
        Debug.Log("Starting the quiz");
    }
}
