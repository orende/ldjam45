using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogHandler : MonoBehaviour {
    int hasSeen = -1;
    protected List<DialogEntry> entries = new List<DialogEntry>();
    public DialogHolder dialoge;
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

    private void Start()
    {
        if(dialoge != null)
        {
            for (int i = 0; i < dialoge.dialogEntrys.Length; i++)
            {
                string speakingCharacterName = dialoge.dialogEntrys[i].speakingCharacterName;
                string[] dial = dialoge.dialogEntrys[i].dialog;
                foreach (string text in dial)
                {
                    this.entries.Add(
                        new DialogEntry(speakingCharacterName,text));
                }
            }
        }
    }
}
