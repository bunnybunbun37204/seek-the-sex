using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManage : MonoBehaviour
{
    public GameObject choice1,choice2;
    public Text chatText;
    string txt;
    public void scene2_choice1()
    {
        txt = "a";
        choice1.SetActive(false);
        choice2.SetActive(false);
        ChatManager.sceneWhenChoiceScene2 = "choice1";
    }
    public void scene2_choice2()
    {
        chatText.text = "b";
        choice1.SetActive(false);
        choice2.SetActive(false);
        ChatManager.sceneWhenChoiceScene2 = "choice2";
    }
    private void Update()
    {
        chatText.text = txt;
    }
}
