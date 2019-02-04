using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Experimental.UIElements.StyleEnums;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public GameObject Player1;
	public GameObject Player2;
	private PlayerController Player1Controller;
	private PlayerController Player2Controller;
	
	public float Timeleft=30;
	
	private int Seconds;

	private int Player1Score;
	private int Player2Score;

	public GameObject P1Win;
	public GameObject P2Win;

	public Text TimerText;
	// Use this for initialization
	void Start ()
	{
		Player1Controller = Player1.GetComponent<PlayerController>();
		Player2Controller = Player2.GetComponent<PlayerController>();
		
		P1Win.GetComponent<Text>().enabled = false;
		P2Win.GetComponent<Text>().enabled = false;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		Timeleft -= Time.deltaTime;
		TimerText.text=""+Timeleft;
		
		if (Timeleft < 0)
		{
			if (Player1Controller.Score > Player2Controller.Score)
			{
				P1Win.GetComponent<Text>().enabled = true;
				
			}
			else
			{
				P2Win.GetComponent<Text>().enabled = true;
			}
		}
	}
}
