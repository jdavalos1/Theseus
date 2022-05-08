using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<Question> allQuestions;
    private Quiz quiz;
    public static GameManager SharedInstance;
    // Start is called before the first frame update
    void Start()
    {
        if (SharedInstance == null) SharedInstance = this;
        // TODO: Load quiz from all jsons in quiz resources
    }

    // Update is called once per frame
    void Update()
    {

    }

}
