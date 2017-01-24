using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlepos = new Vector3 (8f , this.transform.position.y , 0f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

		paddlepos.x = Mathf.Clamp(mousePosInBlocks, .5f, 15.5f);
		this.transform.position = paddlepos;
	}
}	
