using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppController : MonoBehaviour
{
    public Button buttonPrefab; 
    public GameObject layoutGroup;
	public static List<GameObject> madeIt = new List<GameObject>();


	public void ToDo()
	{

	}


    public void Add()
	{
		var toDo = Instantiate(buttonPrefab, transform.position, Quaternion.identity);
		toDo.transform.SetParent(layoutGroup.transform, false);
		
	}

	public void Delete()
	{
		for (int i = 0; i < madeIt.Count; i++)
		{
			Destroy(madeIt[i]);
		}
	}

}
