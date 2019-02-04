using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	
	public KeyCode upKey;
	public KeyCode downKey;
	public KeyCode leftKey;
	public KeyCode rightKey;
	public float forceAmount = 1;

	public Text ScoreText;
	
	public int Score = 0;
	
	private Rigidbody2D rb;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	// In Unity 50 frame per second
	void Update ()
	{
		Vector2 newForce = new Vector2(0,0); //the force we will add to our player
		
		if (Input.GetKey(upKey)) //When someone presses "W"
		{
			Debug.Log("Pressed W");
			newForce.y += forceAmount;
		}
		
		if (Input.GetKey(downKey)) //When someone presses "S"
		{
			Debug.Log("Pressed S");
			newForce.y -= forceAmount;
		}
		
		if (Input.GetKey(leftKey)) //When someone presses "A"
		{
			Debug.Log("Pressed A");
			newForce.x -= forceAmount;
		}
		
		if (Input.GetKey(rightKey)) //When someone presses "D"
		{
			Debug.Log("Pressed D");
			newForce.x += forceAmount;
		}
		
		rb.AddForce(newForce);

		ScoreText.text = "" + Score;
	}
}
