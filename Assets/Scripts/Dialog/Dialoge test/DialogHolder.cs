using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialog",menuName = "Dialog",order = 1)]
public class DialogHolder : ScriptableObject
{
    public DialogText[] dialogEntrys = new DialogText[1];
}

[System.Serializable]
public class DialogText
{
    public string speakingCharacterName;
    [TextArea(2, 20)]
    public string[] dialog= new string[1];
}
