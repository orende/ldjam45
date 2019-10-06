using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogHandler : MonoBehaviour {
    int hasSeen = -1;
    protected List<DialogEntry> entries = new List<DialogEntry>();
    public UnityEvent onFinishEvents;


    public bool hasMoreDialog()
    {
        return hasSeen < entries.Count - 1;
    }

    public DialogEntry getNextDialog()
    {
        if (hasSeen < entries.Count - 1) {
            return entries[++hasSeen];
        } else {
            onFinish();
            return null;
        }
    }

    public void onFinish() {
        onFinishEvents.Invoke();
    }
}
