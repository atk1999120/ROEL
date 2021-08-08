using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public void Start()
    {
        SoundManager.Instance.PlayBGMSound("VSQSE_0666_forest");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("ROWL_Field");
    }
}
