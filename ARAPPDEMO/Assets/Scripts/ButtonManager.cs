using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
	public void TimW() //goes to TimWwalker info Scene
	{
		SceneManager.LoadScene("TimW");
	}

	public void AR() // goes to the ar scene
	{
		SceneManager.LoadScene("ARScene");
	}
	public void Home() // goes to home
	{
		SceneManager.LoadScene("Home");
	}

	public void Tentoonstelling() // goes to the "tentoonstelling" scene
		{
		SceneManager.LoadScene("Tentoonstelling");
		}

	public void Kamer() // gies to Kamer Scene
	{
		SceneManager.LoadScene("Kamer");
	}

}
