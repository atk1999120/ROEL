using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class SetDoorAction : MonoBehaviour
{
    public bool isOpen = false;

    public Animator animator;

    public bool IsGirlOnly;

    public string OnlyTag = string.Empty;

    private AICharacterControl notOnlyAICharacter;

    private void Start()
    {
        if(IsGirlOnly == true)
        {
            OnlyTag = "GirlCharacter";
        }
        else
        {
            OnlyTag = "BoyCharacter";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != OnlyTag)
        {
            notOnlyAICharacter = other.GetComponent<AICharacterControl>();
            notOnlyAICharacter.Stop = true;
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
        if (other.tag != OnlyTag)
        {
            return;
        }
        if (isOpen)
        {
            if(notOnlyAICharacter != null)
            {
                notOnlyAICharacter.Stop = false;
            }
            isOpen = false;
            animator.SetBool("IsOpen", isOpen);
        }
    }
}
