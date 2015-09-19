using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

    public float speed = 5;
   
    private Rigidbody2D myBody;
	// Use this for initialization
	void Start () {
        myBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 moveVector = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * speed;
        bool isFiring = CrossPlatformInputManager.GetButtonDown("FireButton");
        if (isFiring)
        {
            myBody.AddForce(moveVector * 2);
        }
        else
        {
            myBody.AddForce(moveVector);
        }
	}
}
