using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public RectTransform noti;
    public Text text;
    public List<GameObject> gameObjectToDisable1;
    public List<GameObject> gameObjectToDisable2;
    public List<GameObject> gameObjectToDisable3;
    public List<GameObject> gameObjectToDisable4;
    public List<GameObject> gameObjectToDisable5;
    public List<GameObject> gameObjectToDisable6;
    public List<GameObject> gameObjectToDisable7;
    public static string id;
    public static string sceneWhenChoiceScene2;
    public static string knowledgeKey;
    string _id;
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        setToZero(gameObjectToDisable1);
        setToZero(gameObjectToDisable2);
        setToZero(gameObjectToDisable3);
        setToZero(gameObjectToDisable4);
        setToZero(gameObjectToDisable5);
        setToZero(gameObjectToDisable6);
        setToZero(gameObjectToDisable7);
        knowledgeKey = "None";
        sceneWhenChoiceScene2 = "None";
        if (PlayerPrefs.GetString("id") != null)
        {
            //id = PlayerPrefs.GetString("id");
            id = "scene1";
        }
        else
        {
            id = "scene1";
        }
    }

    void setToZero(List<GameObject> gameObjects)
    {
        for(int i =0; i< gameObjects.Count; i++)
        {
            gameObjects[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Playing();
    }

    public void ontap()
    {
        index += 1;
    }

    void Playing()
    {
        switch (id)
        {
            case "scene1":
                try
                {
                    gameObjectToDisable1[index].SetActive(true);
                    if(index == 3)
                    {
                        knowledgeKey = "1";
                        text.text = "ยาขับเลือด คลิกเพื่ออ่านต่อ";
                        noti.DOAnchorPos(new Vector2(0,120),0.25f);
                        noti.DOAnchorPos(new Vector2(0, 292), 0.25f);
                    }
                }
                catch
                {
                    id = "scene2";
                    index = 0; 
                }
                break;
            case "scene2":
                gameObjectToDisable2[0].SetActive(true);
                try
                {
                    if(index == 3 && sceneWhenChoiceScene2 == "choice1") 
                    {
                        gameObjectToDisable2[3].SetActive(true);
                        gameObjectToDisable2[4].SetActive(false);
                        _id = "scene2.1";
                    }
                    else if(index == 4 && sceneWhenChoiceScene2 == "choice2")
                    {
                        gameObjectToDisable2[3].SetActive(false);
                        gameObjectToDisable2[4].SetActive(true);
                        _id = "scene2.2";
                    }
                    else
                    {
                        gameObjectToDisable2[index].SetActive(true);
                    }
                }
                catch
                {
                    id = _id;
                    gameObjectToDisable3[0].SetActive(true);
                    index = 0;
                }
                break;
            case "scene2.1":
                
                try
                {
                    gameObjectToDisable3[index].SetActive(true);
                    if (index == 1)
                    {
                        knowledgeKey = "2";
                        text.text = "การทำแท้ง คลิกเพื่ออ่านต่อ";
                        noti.DOAnchorPos(new Vector2(0, 120), 0.25f);
                        noti.DOAnchorPos(new Vector2(0, 292), 0.25f);
                    }
                }
                catch
                {
                    id = "scene3";
                    index = 0;
                }
                break;
            case "scene2.2":
                try
                {
                    gameObjectToDisable4[index].SetActive(true);
                    if (index == 1)
                    {
                        knowledgeKey = "2";
                        text.text = "การทำแท้ง คลิกเพื่ออ่านต่อ";
                        noti.DOAnchorPos(new Vector2(0, 120), 0.25f);
                        noti.DOAnchorPos(new Vector2(0, 292), 0.25f);
                    }
                }
                catch
                {
                    id = "scene3";
                    index = 0;
                }
                break;
            case "scene3":
                gameObjectToDisable5[0].SetActive(true);
                try
                {
                    gameObjectToDisable5[index].SetActive(true);
                }
                catch
                {
                    id = "scene4";
                    index = 0;
                }
                break;
            case "scene4":
                gameObjectToDisable6[0].SetActive(true);
                try
                {
                    gameObjectToDisable6[index].SetActive(true);
                }
                catch
                {
                    id = "scene5";
                    index = 0;
                }
                break;
            case "scene5":
                gameObjectToDisable7[0].SetActive(true);
                try
                {
                    gameObjectToDisable7[index].SetActive(true);
                }
                catch
                {
                    id = "scene5";
                    index = 0;
                }
                break;

        }
        
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(3);
    }
}
