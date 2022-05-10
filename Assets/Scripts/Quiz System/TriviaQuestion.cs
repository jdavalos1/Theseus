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
    private string Question;

    /// <summary>
    /// Right answer to the question
    /// </summary>
    private string Answer;

    /// <summary>
    /// All potential answers in the game
    /// </summary>
    private List<string> AllAnswers;

    public string QuestionText { get { return Question; } }
    public List<string> PotentialAnswers { get { return AllAnswers; } }

    public TriviaQuestion(string _question, List<string> _allAnswers, string answer)
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
