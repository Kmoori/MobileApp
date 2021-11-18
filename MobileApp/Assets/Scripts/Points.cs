using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{
    int input;
    private int allPoints;
    public TextMeshProUGUI allPointsText;
    private int pointToAdd;
    public string pointToAddPrefs;

    public TMP_InputField inputField;

    // Update is called once per frame
    void Update()
    {
        allPointsText.text = "All points: " + PlayerPrefs.GetInt(pointToAddPrefs);
    }

    public void plusPoint()
    {
        pointToAdd++;
        inputField.text = pointToAdd.ToString();
    }

    public void minusPoints()
    {
        pointToAdd--;
        inputField.text = pointToAdd.ToString();
    }

    public void AddPoints()
    {
        
        allPoints += input;
        PlayerPrefs.SetInt(pointToAddPrefs, allPoints);
        PlayerPrefs.Save();
    }

    public void EctractPoints()
    {
        allPoints -= input;
        PlayerPrefs.SetInt(pointToAddPrefs, allPoints);
        PlayerPrefs.Save();
    }

    public void ReadStringInput()
    {
        input = int.Parse(inputField.text);
        Debug.Log(input);
    }
}
