using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : FieldItems
{
    private Quiz doorQuiz;

    [SerializeField]
    private float DoorOpenTimer;

    void Start()
    {
        doorQuiz = new Quiz();
    }
    // Update is called once per frame
    void Update()
    {
        ShowAndInteract(StartQuiz);
    }

    private void StartQuiz()
    {
        UIManager.SharedInstance.ShowDialog(new DialogBuilder("Door", "Do you wish to proceed?"));
        GameManager.SharedInstance.StartQuiz();
    }

    public void ContinueToNextSection()
    {
    }

    private IEnumerator OpenDoor()
    {
        float t = 0.0f;

        while(t < DoorOpenTimer)
        {
            t += Time.deltaTime;
            yield return null;
        }
    }
}
