using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{
    Toggle m_Toggle;
    // Start is called before the first frame update
    void Start()
    {

        m_Toggle = GetComponent<Toggle>();

        m_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(m_Toggle);
        });
    }

    //Output the new state of the Toggle into Text when the user uses the Toggle
    void ToggleValueChanged(Toggle change)
    {

		if (m_Toggle.isOn == true)
		{
            transform.parent.GetComponent<Image>().color = Color.green;
            AppController.madeIt.Add(transform.parent.gameObject);
        }
		else
		{
            transform.parent.GetComponent<Image>().color = Color.white;
            AppController.madeIt.Remove(transform.parent.gameObject);
        }
    }
}
