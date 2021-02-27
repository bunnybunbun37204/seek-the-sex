using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saved : MonoBehaviour
{
    public void onClick()
    {
        PlayerPrefs.SetString("id",ChatManager.id);
        Debug.Log("id is "+PlayerPrefs.GetString("id"));
    }
}
