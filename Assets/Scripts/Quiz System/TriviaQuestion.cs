using System.Collections.Generic;
using System.Linq;
using System;
/// <summary>
/// Represents a question entry in the quiz system.
/// </summary>
[Serializable]
public class TriviaQuestion
{
    /// <summary>
    /// Question itself
    /// </summary>
    public string Question;

    /// <summary>
    /// Right answer to the question
    /// </summary>
    public string Answer;

    /// <summary>
    /// All potential answers in the game
    /// </summary>
    public string[] AllAnswers;

    public TriviaQuestion(string _question, string[] _allAnswers, string answer)
    {
        Question = _question;
        AllAnswers = _allAnswers;
        Answer = answer;
    }

    public bool SelectedIsCorrect(string selectedAnswer)
    {
        return Answer.Equals(selectedAnswer);
    }
}
