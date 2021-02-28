using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceManage : MonoBehaviour
{
    public GameObject choice1,choice2;
    public void scene2_choice1()
    {
        choice1.SetActive(false);
        choice2.SetActive(false);
        ChatManager.sceneWhenChoiceScene2 = "choice1";
    }
    public void scene2_choice2()
    {
        choice1.SetActive(false);
        choice2.SetActive(false);
        ChatManager.sceneWhenChoiceScene2 = "choice2";
    }
}
