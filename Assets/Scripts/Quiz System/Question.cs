using System.Collections.Generic;
using System.Linq;
using System;
/// <summary>
/// Represents a question entry in the quiz system.
/// </summary>
[Serializable]
public class Question
{
    private string questionText;
    private Dictionary<string, bool> answers;

    public string QuestionText { get { return questionText; } }
    public List<string> PotentialAnswers { get{ return answers.Keys.ToList(); } }

    public Question(string _question, Dictionary<string, bool> _answer)
    {
        questionText = _question;
        answers = new Dictionary<string, bool>();

    }
    
    public bool SelectedIsCorrect(string answer)
    {
        return answers[answer];
    }
}
