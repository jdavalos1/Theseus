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

    /// <summary>
    /// Handles how the text will be displayed on screen
    /// </summary>
    /// <param name="text">Description of the item</param>
    public void ShowDialog(DialogBuilder db)
    {
        // TODO: Handle how dialog is displayed.
        // Make sure the text doesn't go past the box.
        // Make sure there is a way to speed up text and go to the next
        // chunk of text.
        // Make sure the dialog disappears after all text is read.
        // Best to put this in an coroutine
        StartCoroutine(DisplayBlocksText(db));
    }

    private IEnumerator DisplayBlocksText(DialogBuilder db)
    {
        dialogObject.SetActive(true);
        speakerTitleText.text = db.GetTitle();
        if (speakerTitleText.text.Length == 0) speakerTitleText.text = db.GetSpeaker();
        descriptionText.text = "";

        string currChunk = db.NextChunk;
        do
        {
            // Output chunk letter by letter
            foreach (char c in currChunk)
            {
                descriptionText.text += c;
                yield return new WaitForSeconds(0.01f);
            }

            // Have to wait until next chunk is requested
            while (!Input.GetKeyDown(KeyCode.Space)) yield return null;

            // Current chunk is requested
            currChunk = db.NextChunk;
        } while (currChunk != null);

        speakerTitleText.text = "";
        descriptionText.text = "";
        dialogObject.SetActive(false);
    }
}
