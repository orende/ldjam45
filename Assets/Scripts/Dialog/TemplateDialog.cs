using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateDialog : DialogHandler
{
    TemplateDialog()
    {
        this.entries.Add(
            new DialogEntry("NPC",
            "The Dialog"));
    }
}
