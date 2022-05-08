using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    private List<Question> questions;

    // Start is called before the first frame update
    void Start()
    {
        questions = new List<Question>();
        LoadQuestions();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // TODO: Load all questions based on json files
    private void LoadQuestions()
    {

    }

    public Question ReturnQuestion()
    {
        int randomLocation = Random.Range(0, questions.Count + 1);
        return questions[randomLocation];
    }
}
