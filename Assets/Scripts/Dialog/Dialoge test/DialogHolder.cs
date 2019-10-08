using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialog",menuName = "Dialog")]
public class DialogHolder : ScriptableObject
{
    public Sprite character;
    [TextArea(2, 20)]
    public string dialog;  
}
