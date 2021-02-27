using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loaded : MonoBehaviour
{
    // Start is called before the first frame update
    public void loaded()
    {
        ChatManager.id = PlayerPrefs.GetString("id");
        Debug.Log("load is" + ChatManager.id);
    }
}
