using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
	// \/Button Manager\/
	public void TimW() //goes to TimWwalker info Scene
	{
		SceneManager.LoadScene("TimW");
	}

	public void AR() // goes to the ar scene
	{
		SceneManager.LoadScene("ARScene");
	}
	public void Home() // goes to home scene
	{
		SceneManager.LoadScene("Home");
		Debug.Log("press!");
	}

	public void Tentoonstelling() // goes to the "tentoonstelling" scene and doubles as back button in two scenes
		{
		SceneManager.LoadScene("Tentoonstelling");
		}

	public void Kamer() // goes to Kamer Scene
	{
		SceneManager.LoadScene("Kamer");
	}

	public void Geschiednis() // Goes to the scene with history of Tim Walker
	{
		SceneManager.LoadScene("WITW");
	}

	public void BesteWerk() //Goes to the "Best work of Tim Walker" scene
	{
		SceneManager.LoadScene("HBWVTM");
	}

	public void Contact()
	{
		SceneManager.LoadScene("Contact");
	}

	public void Adress()
	{
		SceneManager.LoadScene("ContactExtra");
	}
}
