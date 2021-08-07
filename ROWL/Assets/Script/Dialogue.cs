using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI DescriptionText;
    private void Awake()
    {
        this.gameObject.SetActive(false);
    }

    public void DisplayDialogue(string message)
    {
        this.gameObject.SetActive(true);
        DescriptionText.text = message;
        StartCoroutine(DisapearDialog());
    }

    IEnumerator DisapearDialog()
    {
        yield return new WaitForSeconds(1f);
        this.gameObject.SetActive(false);
    }
}
