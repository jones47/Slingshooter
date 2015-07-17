using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	static public FollowCam S;
	public GameObject poi;
	private float camZ;
	public float easing = 0.05f;

    GameObject originalTarget;

	void Awake() {
		S = this;
		camZ = transform.position.z;
        originalTarget = poi;
	}

	void FixedUpdate() {
		// If there is no poi, get outta here
		if(poi == null) {
			return;
		}

		Vector3 destination = poi.transform.position;

		destination.x = Mathf.Max(0.0f, destination.x );
		destination.y = Mathf.Max(0.0f, destination.y );

		destination = Vector3.Lerp(transform.position, destination, easing);

		destination.z = camZ;

		transform.position = destination;

		GetComponent<Camera>().orthographicSize = 10 + destination.y;

        if(poi.GetComponent<Rigidbody>())
        {
            if(poi.GetComponent<Rigidbody>().IsSleeping())
            {
                poi = originalTarget;
            }
        }


	}

    



}
