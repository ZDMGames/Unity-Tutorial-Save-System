using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsSystem : MonoBehaviour
{
    public Text stringInput, intInput, xInput, yInput, zInput;
    public Text stringDisplay, intDisplay, vectorDisplay;

    public void SavePref()
    {
        PlayerPrefs.SetString("Name", stringInput.text);
        PlayerPrefs.SetInt("Level", int.Parse(intInput.text));
        PlayerPrefs.SetFloat("VectorX", float.Parse(xInput.text));
        PlayerPrefs.SetFloat("VectorY", float.Parse(yInput.text));
        PlayerPrefs.SetFloat("VectorZ", float.Parse(zInput.text));
    }

    public void LoadPref()
    {
        stringDisplay.text = PlayerPrefs.GetString("Name");
        intDisplay.text = PlayerPrefs.GetInt("Level").ToString();
        vectorDisplay.text = PlayerPrefs.GetFloat("VectorX").ToString() + ", " + PlayerPrefs.GetFloat("VectorY").ToString() + ", " + PlayerPrefs.GetFloat("VectorZ").ToString();
    }
}
