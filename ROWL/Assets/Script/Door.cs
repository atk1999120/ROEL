using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public SetDoorAction.DoorOpenRestriction DoorOpenRestriction;
    void Start()
    {
        CapsuleCollider CapsuleCollider = null;
        if (DoorOpenRestriction == SetDoorAction.DoorOpenRestriction.IsGetKeyItem)
        {
            CapsuleCollider = this.gameObject.AddComponent<CapsuleCollider>();
            CapsuleCollider.center = Vector3.zero;
            CapsuleCollider.radius = 1.5f;
            CapsuleCollider.height = 1f;
            CapsuleCollider.isTrigger = true;
        }
        else
        {
            CapsuleCollider = this.transform.parent.gameObject.AddComponent<CapsuleCollider>();
            CapsuleCollider.radius = 1.5f;
            CapsuleCollider.height = 1f;
            CapsuleCollider.isTrigger = true;
        }
        var doorAction = CapsuleCollider.gameObject.AddComponent<SetDoorAction>();
        doorAction.ThisDoorOpenRestriction = DoorOpenRestriction;
        var Animator = GetComponent<Animator>();
        doorAction.animator = Animator;
    }
}