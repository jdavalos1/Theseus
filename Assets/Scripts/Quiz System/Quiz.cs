using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz 
{
    private List<TriviaQuestion> allQuestions;
    private List<TriviaQuestion> currentQuestions;

    /// <summary>
    /// The number of current right questions
    /// </summary>
    private int numberRight;
    /// <summary>
    /// The number of current wrong questions
    /// </summary>
    private int numberWrong;

    /// <summary>
    /// The current question being asked
    /// </summary>
    private TriviaQuestion currentQuestion;

    public TriviaQuestion CurrentQuestion { get { return currentQuestion; } }

    /// <summary>
    /// Start the quiz by loading all questions
    /// </summary>
    /// <param name="_questions"></param>
    public Quiz()
    {
        numberRight = numberWrong = 0;

        // TODO: Load up all questions from the questions folder
        allQuestions = new List<TriviaQuestion>();
        TextAsset[] tas = Resources.LoadAll<TextAsset>(QuizConstants.QuestionsBaseFolder);

        foreach(TextAsset ta in tas)
        {
            allQuestions.Add(JsonUtility.FromJson<TriviaQuestion>(ta.text));
        }

        // Get Random range in all questions
        int randomLocation = Random.Range(0, allQuestions.Count - QuizConstants.NumQRightThreshhold);

        currentQuestions = allQuestions.GetRange(randomLocation, QuizConstants.NumQRightThreshhold);

        // Get random question to start
        randomLocation = Random.Range(0, currentQuestions.Count);
        currentQuestion = currentQuestions[randomLocation];

        Debug.Log(currentQuestion.Question);
    }

    /// <summary>
    /// Verify the answer passed in
    /// </summary>
    /// <param name="selectedAnswer"></param>
    public void VerifyAnswer(string selectedAnswer)
    {
        // If the question is right check if we've hitpdenough rights
        // else check if we've hit too many wrongs
        if (currentQuestion.SelectedIsCorrect(selectedAnswer))
        {
            numberRight++;
            if (QuizConstants.NumQRightThreshhold >= numberRight)
            {
                Debug.Log("We did it");
            }
            else
            {
                currentQuestion = currentQuestions[Random.Range(0, currentQuestions.Count)];
            }
        }
        else
        {
            numberWrong++;
            if(QuizConstants.NumQWrongThreshhold >= numberWrong)
            {
                Debug.Log("Oh oh");
            }
            else
            {
                currentQuestion = currentQuestions[Random.Range(0, currentQuestions.Count)];
            }
        }
    }
}
