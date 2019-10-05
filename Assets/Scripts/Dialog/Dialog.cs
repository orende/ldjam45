using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHandler: MonoBehaviour {
    int hasSeen = -1;
    protected List<DialogEntry> entries = new List<DialogEntry>();


    public bool hasMoreDialog()
    {
        return hasSeen < entries.Count;
    }

    public bool isLastDialog()
    {
        return hasSeen == entries.Count - 1;
    }

    public DialogEntry getNextDialog()
    {
        if(hasSeen < entries.Count)
        {
            return entries[++hasSeen];
        } else
        {
            return null;
        }
    }
}
