using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChatCHR",menuName = "ChatCHR/Create a new ChatCHR")]
public class ChatBase : ScriptableObject
{
    //[SerializeField] string charactersName;
    
    [SerializeField] Sprite characterSprite;
    [SerializeField] Sprite chatSprite;
    [SerializeField] CharactersName charactersName;
    //[SerializeField] Text text;
    [TextArea]
    [SerializeField] string textStr;

    ChatBase()
    {
    }

    public string getName()
    {
        return textStr;
    }


}

public enum CharactersName
{
    Kate,
    Arm,
    Gavin,
    Pang,
    GrandMa,
    Dad,
    Mom
}
