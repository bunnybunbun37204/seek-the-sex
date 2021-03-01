using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    public List<GameObject> sceneObjects;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < sceneObjects.Count; i++)
        {
            sceneObjects[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (ChatManager.id)
        {
            case "scene1":
                sceneObjects[0].SetActive(true);
                PlayerPrefs.SetString("id", ChatManager.id);
                break;
            case "scene2":
                sceneObjects[0].SetActive(false);
                sceneObjects[1].SetActive(true);
                PlayerPrefs.SetString("id", ChatManager.id);
                break;
            case "scene2.1":
                sceneObjects[0].SetActive(false);
                sceneObjects[1].SetActive(true);
                sceneObjects[2].SetActive(true);
                PlayerPrefs.SetString("id", ChatManager.id);
                break;
            case "scene2.2":
                sceneObjects[0].SetActive(false);
                sceneObjects[1].SetActive(true);
                sceneObjects[2].SetActive(false);
                sceneObjects[3].SetActive(true);
                PlayerPrefs.SetString("id", ChatManager.id);
                break;
            case "scene3":
                sceneObjects[0].SetActive(false);
                sceneObjects[1].SetActive(false);
                sceneObjects[2].SetActive(false);
                sceneObjects[3].SetActive(false);
                sceneObjects[4].SetActive(true);
                PlayerPrefs.SetString("id", ChatManager.id);
                break;
            case "scene4":
                sceneObjects[0].SetActive(false);
                sceneObjects[1].SetActive(false);
                sceneObjects[2].SetActive(false);
                sceneObjects[3].SetActive(false);
                sceneObjects[4].SetActive(false);
                sceneObjects[5].SetActive(true);
                PlayerPrefs.SetString("id", ChatManager.id);
                break;
            case "scene5":
                sceneObjects[0].SetActive(false);
                sceneObjects[1].SetActive(false);
                sceneObjects[2].SetActive(false);
                sceneObjects[3].SetActive(false);
                sceneObjects[4].SetActive(false);
                sceneObjects[5].SetActive(false);
                sceneObjects[6].SetActive(false);
                PlayerPrefs.SetString("id", ChatManager.id);
                break;
        }
    }
}
