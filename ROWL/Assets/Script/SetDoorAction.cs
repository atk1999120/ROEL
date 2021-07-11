using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDoorAction : MonoBehaviour
{
    public bool isOpen = false;
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }
        if (!isOpen)
        {
            isOpen = true;
            animator.SetBool("IsOpen", isOpen);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }
        if (isOpen)
        {
            isOpen = false;
            animator.SetBool("IsOpen", isOpen);
        }
    }
}
