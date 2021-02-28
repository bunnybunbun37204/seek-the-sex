using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public List<GameObject> gameObjectToDisable1;
    public RectTransform noti;
    public Text text;
    public List<GameObject> gameObjectToDisable2;
    public static string id;
    public static string sceneWhenChoiceScene2;
    public static string knowledgeKey;
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        setToZero(gameObjectToDisable1);
        setToZero(gameObjectToDisable2);
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
                    if(sceneWhenChoiceScene2 == "choice1" || sceneWhenChoiceScene2 == "None")
                    {
                        if(index == 4)
                        {
                            gameObjectToDisable2[3].SetActive(true);
                            gameObjectToDisable2[index].SetActive(false);
                        }
                        else
                        {
                            gameObjectToDisable2[index].SetActive(true);
                        }
                    }
                    else if  (sceneWhenChoiceScene2 == "choice2")
                    {
                        if (index == 3)
                        {
                            gameObjectToDisable2[index].SetActive(false);
                        }
                        else
                        {
                            gameObjectToDisable2[4].SetActive(true);
                        }
                    }
                }
                catch
                {
                    //id = "scene3";
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
