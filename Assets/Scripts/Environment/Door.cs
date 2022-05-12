using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : FieldItems
{
    private Quiz doorQuiz;
    private bool doorOpen;
    private Coroutine currentRoutine;

    [SerializeField]
    private bool quizBeat;

    [SerializeField]
    private string sectionFolder;

    [SerializeField]
    private Vector3 movementAmount;
    

    [SerializeField]
    private float DoorOpenTimer;

    void Start()
    {
        doorOpen = false;
        quizBeat = false;
        doorQuiz = new Quiz(sectionFolder);
    }
    // Update is called once per frame
    void Update()
    {
        ShowAndInteract(StartQuiz);

        // TODO: Deactivate the script for interact until close
        /*if(Vector3.Distance(player.position, transform.position) > 5f && doorOpen)
        {
            Debug.Log("Closing");
            if(currentRoutine != null) StopCoroutine(currentRoutine);
            currentRoutine = StartCoroutine(CloseDoor());
        }*/
    }

    private void StartQuiz()
    {
        if (quizBeat)
        {
            if(currentRoutine != null) StopCoroutine(currentRoutine);
            StartCoroutine(OpenDoor());
            return;
        }
        UIManager.SharedInstance.ShowDialog(new DialogBuilder("Door Dialogs/Start Door"));
        GameManager.SharedInstance.StartQuiz(this);
    }

    /// <summary>
    /// Expose the door opening function
    /// </summary>
    public void ContinueToNextSection()
    {
        currentRoutine = StartCoroutine(OpenDoor());
    }

    private IEnumerator CloseDoor()
    {
        // TODO: need to change to based on distance with og position
        float t = 0.0f;
        Vector3 startPos = transform.position;
        Vector3 endPos = transform.position - movementAmount;
        while(t < DoorOpenTimer)
        {
            t += Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, endPos, t / DoorOpenTimer);
            yield return null;
        }

        doorOpen = false;
    }
    /// <summary>
    /// Open the door by moving it x amount of space around.
    /// </summary>
    /// <returns></returns>
    private IEnumerator OpenDoor()
    {
        doorOpen = true;
        Player p = FindObjectOfType<Player>();
        p.CanMove = false;
        float t = 0.0f;

        Vector3 startPos = transform.position;
        Vector3 endPos = transform.position + movementAmount;
        while(t < DoorOpenTimer)
        {
            t += Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, endPos, t / DoorOpenTimer);
            yield return null;
        }
        p.CanMove = true;
    }
}
