using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnowLedgeManager : MonoBehaviour
{
    public List<GameObject> knowLedgeObj;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < knowLedgeObj.Count; i++)
        {
            knowLedgeObj[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (ChatManager.knowledgeKey)
        {
            case "1":
                knowLedgeObj[0].SetActive(true);
                break;
        }
    }
}
