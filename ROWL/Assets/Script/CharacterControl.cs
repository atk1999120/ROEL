using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Cameras;
using UnityStandardAssets.Characters.ThirdPerson;


public class CharacterControl : MonoBehaviour
{
    public GameObject GirlCharacter;
    public GameObject BoyCharacter;
    public AutoCam autoCam;

    private ThirdPersonUserControl girlThirdPersonUserControl;
    private ThirdPersonUserControl boyThirdPersonUserControl;

    private AICharacterControl girlAICharacterControl;
    private AICharacterControl boyAICharacterControl;

    private NavMeshAgent girlNavMeshAgent;
    private NavMeshAgent boyNavMeshAgent;

    private void Awake()
    {
        girlThirdPersonUserControl = GirlCharacter.GetComponent<ThirdPersonUserControl>();
        girlAICharacterControl = GirlCharacter.GetComponent<AICharacterControl>();
        girlNavMeshAgent = GirlCharacter.GetComponent<NavMeshAgent>();
        boyThirdPersonUserControl = BoyCharacter.GetComponent<ThirdPersonUserControl>();
        boyAICharacterControl = BoyCharacter.GetComponent<AICharacterControl>();
        boyNavMeshAgent = BoyCharacter.GetComponent<NavMeshAgent>();
    }

    public void CharacterChange()
    {
        // 女の子が操作可能のときはThirdPersonUserControlをGetし、使用可能にする
        var playableCharacterIsAGirl = GirlCharacter.GetComponent<ThirdPersonUserControl>().enabled;
        
        if(playableCharacterIsAGirl == true)
        {
            //操作可能キャラクターが女の子のときはカメラのターゲットを男の子から女の子へ変更する
            autoCam.SetTarget(BoyCharacter.transform);
        }
        else
        {
            //違うときは女の子から男の子へ変更する
            autoCam.SetTarget(GirlCharacter.transform);
        }

        girlThirdPersonUserControl.enabled = !playableCharacterIsAGirl;
        girlAICharacterControl.enabled = playableCharacterIsAGirl;
        girlNavMeshAgent.enabled = playableCharacterIsAGirl;
        boyThirdPersonUserControl.enabled = playableCharacterIsAGirl;
        boyAICharacterControl.enabled = !playableCharacterIsAGirl;
        boyNavMeshAgent.enabled = !playableCharacterIsAGirl;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            CharacterChange();
        }
    }
}
