using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogEntry 
{
    public string speakingCharacterName;
    public string dialog;

    public DialogEntry(string speakingCharacterName, string dialog)
    {
        this.speakingCharacterName = speakingCharacterName;
        this.dialog = dialog;
    }
}
