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
    /// <param name="subFolder">Folder to read the questions from</param>
    public Quiz(string subFolder)
    {
        numberRight = numberWrong = 0;

        allQuestions = new List<TriviaQuestion>();
        TextAsset[] tas = Resources.LoadAll<TextAsset>(QuizConstants.QuestionsBaseFolder + subFolder);

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
                GameManager.SharedInstance.PassedQuiz();
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
                GameManager.SharedInstance.FailedQuiz();
            }
            else
            {
                currentQuestion = currentQuestions[Random.Range(0, currentQuestions.Count)];
            }
        }
    }
}
