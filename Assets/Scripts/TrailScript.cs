using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
#if UNITY_EDITOR
    // Set up touch input propagation while using Instant Preview in the editor.
    using Input = GoogleARCore.InstantPreviewInput;
#endif


public class TrailScript : MonoBehaviour {

	public GameObject gameObject;
	public GameObject camera;
	public List<GameObject> Points = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButton(0) || Input.touchCount>0) {
			Debug.Log("Touched");
			Vector3 camPos = camera.transform.position;
 			Vector3 camDirection = camera.transform.forward;
 			Quaternion camRotation = camera.transform.rotation;
 			float spawnDistance = 2;
			Debug.Log("Touched"+camPos.x+" "+camPos.y+" "+camPos.z);
 			Vector3 spawnPos = camPos + (camDirection * spawnDistance);
			GameObject cur = Instantiate(gameObject, spawnPos,  camRotation);
			cur.transform.SetParent(this.transform);
		}
	}
}
