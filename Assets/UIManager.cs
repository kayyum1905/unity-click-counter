/*
Deveped by: Abdulkayyum Uçkun
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	Text clickText;

	void Start () 
	{
		clickText = GameObject.Find("Canvas/Count").GetComponent<Text>();
	}

	public void UpdateText (int n) 
	{
		clickText.text = n.ToString();
	}
}
