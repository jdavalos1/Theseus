using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager SharedInstance;

    [SerializeField]
    private GameObject dialogObject;
    [SerializeField]
    private TextMeshProUGUI speakerTitleText;
    [SerializeField]
    private TextMeshProUGUI descriptionText;

    private void Start()
    {
        if(SharedInstance == null) SharedInstance = this;
    }

    // TODO: Need to create a way for the inventory to be seen by
    // the player along with the rest of the items interacted with

    /// <summary>
    /// Handles how the text will be displayed on screen
    /// </summary>
    /// <param name="text">Description of the item</param>
    public void ShowDialog(DialogBuilder db)
    {
        StartCoroutine(DisplayBlocksText(db));
    }

    private IEnumerator DisplayBlocksText(DialogBuilder db)
    {
        // TODO: Need to push characters page by page.
        Player player = FindObjectOfType<Player>();
        player.CanMove = false;
        dialogObject.SetActive(true);
        speakerTitleText.text = db.Dialog.Title;
        descriptionText.text = "";
        descriptionText.pageToDisplay = 1;

        string description = db.Dialog.Description;

        int i = 0;

        while(i < description.Length)
        {
            descriptionText.text = "";

            while (!descriptionText.isTextTruncated && i < description.Length)
            {
                descriptionText.text += description[i];
                i++;
                yield return new WaitForSeconds(0.01f);
            }

            while (!Input.GetKeyDown(KeyCode.Space)) yield return null;
            yield return null;
            descriptionText.text = "";
            descriptionText.ForceMeshUpdate();
        }

        speakerTitleText.text = "";
        descriptionText.text = "";
        dialogObject.SetActive(false);
        player.CanMove = true;
        descriptionText.pageToDisplay = 1;
    }
}
