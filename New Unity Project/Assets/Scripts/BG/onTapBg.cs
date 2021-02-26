using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onTapBg : MonoBehaviour
{
    // Start is called before the first frame update
   public void chatHome()
    {
        SceneManager.LoadScene("Chat");
    }
    private void FixedUpdate()
    {
        onTapDown();
    }
    void onTapDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            chatHome();
            
        }
    }
}
