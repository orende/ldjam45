using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogPlayer : MonoBehaviour
{
    
    public GameObject dialogHandlerGameObject;
    public GameObject textPanelGameObject;
    public GameObject portraits;

    private TextMeshProUGUI textMeshUguu;
    private TextMeshProUGUI buttonText;
    private DialogHandler dialogHandler;
    private Image image;
    

    bool noMoreDialog = false;


    void Start()
    {
        dialogHandler = dialogHandlerGameObject.GetComponent<DialogHandler>();
        textMeshUguu = textPanelGameObject.transform.Find("DialogText").GetComponent<TextMeshProUGUI>();
        buttonText = textPanelGameObject.transform.Find("Button").GetComponentInChildren<TextMeshProUGUI>();
        image = textPanelGameObject.transform.Find("Portrait").GetComponent<Image>();


        this.nextDialog();
    }

    public void nextDialog()
    {
        if (dialogHandler.isLastDialog())
        {
            buttonText.text = "Close";
        }
        else if (dialogHandler.hasMoreDialog())
        {
            DialogEntry dialogEntry = dialogHandler.getNextDialog();
            string dialog = dialogEntry.dialog;
            SpriteRenderer sprite = portraits.transform.Find(dialogEntry.speakingCharacterName).GetComponent<SpriteRenderer>();

            image.sprite = sprite.sprite;

            textMeshUguu.text = dialog;
        }
        else
        {
            this.noMoreDialog = true;
        }

    }

    void Update()
    {
        if(noMoreDialog)
        {
            textPanelGameObject.SetActive(false);
        }
    }
}
