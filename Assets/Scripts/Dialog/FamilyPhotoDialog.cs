using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyPhotoDialog: DialogHandler
{
    FamilyPhotoDialog()
    {
        this.entries.Add(
            new DialogEntry("detective", "My lovely family."));
        this.entries.Add(
            new DialogEntry("detective", "They wanted me to become a coal miner instead of a detective."));
        this.entries.Add(
            new DialogEntry("detective", "Nothing but bad memories. I'll take this down."));
    }
    
}
