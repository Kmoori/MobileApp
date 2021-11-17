using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputFieldController : MonoBehaviour
{
    string input;
    public TMP_InputField inputField;
    public string id;
    // Start is called before the first frame update
    void Start()
    {
        inputField.text = PlayerPrefs.GetString(id);
    }

    private void Update()
    {
        if (!transform.parent.gameObject.activeSelf)
        {
            PlayerPrefs.DeleteKey(id);
        }
        Debug.Log(transform.parent.gameObject.activeSelf);
    }

    public void ReadStringInput(string s)
    {
        input = inputField.text;
        Debug.Log(input);

        PlayerPrefs.SetString(id, input);
        PlayerPrefs.Save();
    }
}