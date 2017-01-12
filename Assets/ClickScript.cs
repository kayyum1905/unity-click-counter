/*
Deveped by: Abdulkayyum Uçkun
*/
using UnityEngine;
using System.Collections;

public class ClickScript : MonoBehaviour 
{
	GameObject manager;
	GameState gamestate;
	UIManager uiManager;

	void Start () 
	{
		manager = GameObject.Find("GameManager");
		gamestate = manager.GetComponent<GameState>();
		uiManager = manager.GetComponent<UIManager>();
	}

	public void Click () 
	{
		gamestate.clickCount += 1;

		int i = gamestate.clickCount;

		uiManager.UpdateText(i);
	}

	public void Reset()
	{
		gamestate.clickCount = 0;

		int i = gamestate.clickCount;

		uiManager.UpdateText(i);
	}
}
