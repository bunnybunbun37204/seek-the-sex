﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSaved : MonoBehaviour
{
    public void DeleteSaveAll()
    {
        PlayerPrefs.DeleteKey("id");
    }
}
