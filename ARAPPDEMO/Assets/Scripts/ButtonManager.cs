using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
	public void TimW()
	{
		SceneManager.LoadScene("TimW");
	}

	public void AR()
	{
		SceneManager.LoadScene("SampleScene");
	}
	public void Home()
	{
		SceneManager.LoadScene("Home");
	}

}
