using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public static DialogManager SharedInstance;

    private void Start()
    {
        if(SharedInstance == null) SharedInstance = this;
    }

    public void ShowTextUI()
    {

    }
}
