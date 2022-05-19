using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LevelTransition : UnityEngine.MonoBehaviour

{
    public string SceneToLoad;

    // Start is called before the first frame update
      void OnTriggerEnter(UnityEngine.Collider other)

    {

        if (other.tag == "Player")

        {

            SceneManager.LoadScene(SceneToLoad);
                    }

    }

}
