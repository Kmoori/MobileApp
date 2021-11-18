using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AppController : MonoBehaviour
{
	public List<GameObject> players = new List<GameObject>();
	public List<TMP_InputField> playersInputField = new List<TMP_InputField>();
	public List<TMP_InputField> playersPointsInputField = new List<TMP_InputField>();
	private int i;



    private void Start()
    {
		i = PlayerPrefs.GetInt("i");

		for (int j = 0; j < i; j++)
        {
			players[j].SetActive(true);
		}
    }

    private void Update()
    {
        if (!players[0].activeSelf)
        {
			PlayerPrefs.DeleteKey("0");
			PlayerPrefs.DeleteKey("Player0");
			playersInputField[0].text = "";
			playersPointsInputField[0].text = "";
		}
        else if (!players[1].activeSelf)
        {
			PlayerPrefs.DeleteKey("1");
			PlayerPrefs.DeleteKey("Player1");
			playersInputField[1].text = "";
			playersPointsInputField[1].text = "";
		}
		else if (!players[2].activeSelf)
		{
			PlayerPrefs.DeleteKey("2");
			PlayerPrefs.DeleteKey("Player2");
			playersInputField[2].text = "";
			playersPointsInputField[2].text = "";
		}
		else if (!players[3].activeSelf)
		{
			PlayerPrefs.DeleteKey("3");
			PlayerPrefs.DeleteKey("Player3");
			playersInputField[3].text = "";
			playersPointsInputField[3].text = "";
		}
	}

    public void Add()
	{
        if (i < 4)
        {
			players[i].SetActive(true);
			i++;
			PlayerPrefs.SetInt("i", i);
			PlayerPrefs.Save();
        }
        else
        {
			Debug.Log("Nincs több játékos");
        }
	}

	public void Delete()
	{
		if (i > 0)
		{
			i--;
			players[i].SetActive(false);
			PlayerPrefs.SetInt("i", i);
			PlayerPrefs.Save();
		}
		else
		{
			Debug.Log("Nincs több törölhetõ játékos");
		}
	}

}
