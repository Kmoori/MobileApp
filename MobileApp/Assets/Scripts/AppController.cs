using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AppController : MonoBehaviour
{
	public List<GameObject> players = new List<GameObject>();
	private int i;

    private void Start()
    {
		i = PlayerPrefs.GetInt("i");

		for (int j = 0; j < i; j++)
        {
			players[j].SetActive(true);
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
