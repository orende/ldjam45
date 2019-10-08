using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEndDialog : DialogHandler
{
    TheEndDialog()
    {
        this.entries.Add(
            new DialogEntry("MrM",
            "Hi. Who are you?"));
        this.entries.Add(
            new DialogEntry("detective",
            "I am a detective. Your boss wanted me to find you."));
        this.entries.Add(
            new DialogEntry("MrM",
            "Well, pleas tell him that I still have a couple of weeks left on my vacation."));
        this.entries.Add(
            new DialogEntry("detective",
            "..."));
        this.entries.Add(
            new DialogEntry("detective",
            "Sure"));
        this.entries.Add(
            new DialogEntry("detective",
            "Have a nice vacation..."));
        this.entries.Add(
            new DialogEntry("MrM",
            "Thank you!"));
    }
}
