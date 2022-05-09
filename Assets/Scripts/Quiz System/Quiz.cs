using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz 
{
    private List<Question> questions;

    public Quiz(List<Question> _questions)
    {
        questions.AddRange(_questions);
    }

    public Question ReturnQuestion()
    {
        int randomLocation = Random.Range(0, questions.Count + 1);
        return questions[randomLocation];
    }
}
