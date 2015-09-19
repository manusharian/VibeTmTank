using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MainScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler {

   public GameObject joystick = null;
   public GameObject button = null;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	   
	}


    public void OnDrag(PointerEventData data)
    { 
    
    }

    public void OnPointerUp(PointerEventData data)
    {
    }

    public void OnPointerDown(PointerEventData data)
    {
    }

}
