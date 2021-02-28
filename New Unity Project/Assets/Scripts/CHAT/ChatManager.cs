using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatManager : MonoBehaviour
{
    public List<GameObject> gameObjectToDisable1;
    public List<GameObject> gameObjectToDisable2;
    public static string id;
    int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        setToZero(gameObjectToDisable1);
        setToZero(gameObjectToDisable2);
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
        if (Input.GetMouseButtonDown(0))
        {
            index += 1;
        }
    }

    void Playing()
    {
        switch (id)
        {
            case "scene1":
                try
                {
                    gameObjectToDisable1[index].SetActive(true);
                }
                catch
                {
                    id = "scene1";
                    index = 0; 
                }
                break;
            case "scene2":
                gameObjectToDisable2[0].SetActive(true);
                try
                {
                    gameObjectToDisable2[index].SetActive(true);
                }
                catch
                {
                    //id = "scene3";
                    index = 0;
                }
                break;
        }
        
    }
}
