using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ScreenManager : MonoBehaviour
{
    public RectTransform chatMenu, knowledgeMenu, settingMenu, charactersMenu, seekMenu;
    public void KnowledgeBtn()
    {
        chatMenu.DOAnchorPos(new Vector2(500, 0), 0.25f);
        settingMenu.DOAnchorPos(new Vector2(0, 500), 0.25f);
        charactersMenu.DOAnchorPos(new Vector2(-500, 0), 0.25f);
        seekMenu.DOAnchorPos(new Vector2(290, 0), 0.25f);
        knowledgeMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }
    public void CharactersBtn()
    {
        chatMenu.DOAnchorPos(new Vector2(500, 0), 0.25f);
        settingMenu.DOAnchorPos(new Vector2(0, 500), 0.25f);
        seekMenu.DOAnchorPos(new Vector2(290, 0), 0.25f);
        knowledgeMenu.DOAnchorPos(new Vector2(290,0), 0.25f);
        charactersMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }
    public void Chatbtn()
    {
        chatMenu.DOAnchorPos(Vector2.zero,0.25f);
        settingMenu.DOAnchorPos(new Vector2(0, 500), 0.25f);
        seekMenu.DOAnchorPos(new Vector2(290, 0), 0.25f);
        knowledgeMenu.DOAnchorPos(new Vector2(-290, 0), 0.25f);
        charactersMenu.DOAnchorPos(new Vector2(-500,0), 0.25f);
    }
    public void Seekbtn()
    {
        chatMenu.DOAnchorPos(new Vector2(-790,0), 0.25f);
        settingMenu.DOAnchorPos(new Vector2(0, 500), 0.25f);
        seekMenu.DOAnchorPos(Vector2.zero, 0.25f);
        knowledgeMenu.DOAnchorPos(new Vector2(-290, 0), 0.25f);
        charactersMenu.DOAnchorPos(new Vector2(-500, 0), 0.25f);
    }
    public void SettingBtn()
    {
        settingMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }
}
