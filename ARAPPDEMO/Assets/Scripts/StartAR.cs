using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAR : MonoBehaviour
{
	// \/Ar Manager\/
	public static bool GameIsPaused = false;
	public GameObject UI;

	private void Start()
	{
		GameIsPaused = true; // pause the scene
	}


	public void Resume() // resume's the scene and removes the small tutorial
	{
		UI.SetActive(false);
		GameIsPaused = false;
	}
}
