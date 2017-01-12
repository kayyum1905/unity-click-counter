/*
Deveped by: Abdulkayyum Uçkun
*/
using UnityEngine;

public class GameState : MonoBehaviour 
{
	public int clickCount
	{
		get
		{
			return click;
		}
		set
		{
			click = value;
		}
	}

	private int click;
}
