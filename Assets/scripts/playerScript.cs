using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerScript : MonoBehaviour {
	public float speed, HP;
	public Image hpBar;
	private Rigidbody2D RB2D;
	// Use this for initialization
	void Start () {
		RB2D = GetComponent<Rigidbody2D> ();
		hpBar.transform.localScale = new Vector2 (HP, hpBar.transform.localScale.y);

	}
	
	// Update is called once per frame
	void Update () {
		RB2D.velocity = new Vector2 (speed, RB2D.velocity.y);
	}
	public void recieveDamage(){
		HP -= (Time.deltaTime*2);
		hpBar.transform.localScale = new Vector2 (HP, hpBar.transform.localScale.y);
	}
}
