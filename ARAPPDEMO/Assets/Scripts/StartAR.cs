using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAR : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject UI;

	private void Start()
	{
		GameIsPaused = true; // pause the scene
	}

	// Update is called once per frame
	void Update()
    {
        
    }

    public void Resume() // resume's the scene and removes the small tutorial
	{
        UI.SetActive(false); 
        GameIsPaused = false;
	}
}
