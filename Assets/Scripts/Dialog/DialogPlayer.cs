using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogPlayer : MonoBehaviour
{

    public GameObject dialogues;
    public GameObject textPanelGameObject;
    public GameObject portraits;

    private TextMeshProUGUI textMeshUguu;
    private TextMeshProUGUI buttonText;
    private DialogHandler currentDialog;
    private Image image;

    

    bool noMoreDialog = false;


    void Start()
    {
        textMeshUguu = textPanelGameObject.transform.Find("DialogText").GetComponent<TextMeshProUGUI>();
        buttonText = textPanelGameObject.transform.Find("Button").GetComponentInChildren<TextMeshProUGUI>();
        image = textPanelGameObject.transform.Find("Portrait").GetComponent<Image>();
    }

    public void nextDialog()
    {
            DialogEntry dialogEntry = currentDialog.getNextDialog();
        if (dialogEntry != null)
        {
            string dialog = dialogEntry.dialog;
            textMeshUguu.text = dialog;
            SpriteRenderer sprite = portraits.transform.Find(dialogEntry.speakingCharacterName).GetComponent<SpriteRenderer>();
            image.sprite = sprite.sprite;
        } else
        {
            textPanelGameObject.SetActive(false);
        }
        if(!currentDialog.hasMoreDialog())
        {
            buttonText.text = "Close";
        }


    }

    public void triggerDialog(string dialogName)
    {
        currentDialog = dialogues.transform.Find(dialogName).GetComponent<DialogHandler>();
        noMoreDialog = false;
        nextDialog();
    }

    void Update()
    {
        if(noMoreDialog)
        {
            textPanelGameObject.SetActive(false);
        }
    }
}
