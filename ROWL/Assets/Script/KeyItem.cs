using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public Dialogue Dialogue;

    private void OnTriggerEnter(Collider other)
    {
        Dialogue.DisplayDialogue("³–ÊŒºŠÖ‚ÌŒ®‚ğæ“¾‚µ‚½");
    }
}