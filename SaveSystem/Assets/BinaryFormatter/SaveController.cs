using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveController : MonoBehaviour
{
    public string name;
    public int level;
    public Vector3 vector;

    public Text stringInput, intInput, xInput, yInput, zInput;
    public Text stringDisplay, intDisplay, vectorDisplay;

    private SaveData data;

    public void SaveBinary()
    {
        name = stringInput.text;
        level = int.Parse(intInput.text);
        vector = new Vector3(float.Parse(xInput.text), float.Parse(yInput.text), float.Parse(zInput.text));

        BinaryFormatterSystem.SaveGame(this);
    }

    public void LoadBinary()
    {
        data = BinaryFormatterSystem.LoadGame();
        stringDisplay.text = data.name;
        intDisplay.text = data.level.ToString();
        vectorDisplay.text = data.vector.x.ToString() + ", " + data.vector.y.ToString() + ", " + data.vector.z.ToString();
    }
}
