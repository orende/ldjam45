using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLevelDialog : DialogHandler
{
    FirstLevelDialog()
    {
        this.entries.Add(
            new DialogEntry("boss",
                "I haven't seen my worker for a couple of days. Maybe he forgot where he works, or he ded. Can you find the lazy (or dead) bastard for me?"));
        this.entries.Add(
            new DialogEntry("detective",
                "I'll find him. Joe Average have never lost a case."));
        this.entries.Add(
            new DialogEntry("detective",
                "This case smelled like a dead fish. Still, I needed the money."));
    }
}
