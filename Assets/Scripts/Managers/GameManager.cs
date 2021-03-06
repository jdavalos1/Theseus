using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player player;
    public Door currentDoor;
    

    public static GameManager SharedInstance;
    // Start is called before the first frame update
    void Start()
    {
        if (SharedInstance == null) SharedInstance = this;
        player = FindObjectOfType<Player>();
    }

    public void StartQuiz(Door d)
    {
        if (currentDoor == null) currentDoor = d;
        player.CanMove = false;
    }

    public void PassedQuiz()
    {
        // TODO: show success text, set door to null
        
    }

    // TODO: once the player has continued open the door
    // Potentially have the door move itself and have a door object
    // in here to know who's asking questions and moving
    // Once moved allow the player to move

    public void FailedQuiz()
    {
        // TODO: show failure text
    }

    // TODO: once the player has continued summon the minotaur
    // Have the minotaur object in the game manager.
    // If it's taken too much damage have it run
    // If theseus has taken one damage check if the pomegranate is with them
    // if it is then survive attack else die
}
