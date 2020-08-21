 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public string name;
    public int level;
    public Vector3 vector;

    public SaveData(SaveController saveInfo)
    {
        name = saveInfo.name;
        level = saveInfo.level;
        vector = saveInfo.vector;
    }
}
