using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool IsGirlOnly = true;
    void Start()
    {
        var CapsuleCollider = this.transform.parent.gameObject.AddComponent<CapsuleCollider>();
        CapsuleCollider.radius = 1.5f;
        CapsuleCollider.height = 1f;
        CapsuleCollider.isTrigger = true;
        var doorAction = CapsuleCollider.gameObject.AddComponent<SetDoorAction>();
        var Animator = GetComponent<Animator>();
        doorAction.animator = Animator;
    }
}