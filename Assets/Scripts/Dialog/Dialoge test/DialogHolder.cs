using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialog",menuName = "Dialog")]
public class DialogHolder : ScriptableObject
{
    public TextAsset dialog;
    public Sprite character;
}
