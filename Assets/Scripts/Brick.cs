using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {


	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;


	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
	}


	
	// Update is called once per frame
	void Update () {
		if (timesHit >= maxHits){
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		timesHit++;
		SimulateWin();
	}

	//TODO remove simulate win and change it to actualy winning
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
}
