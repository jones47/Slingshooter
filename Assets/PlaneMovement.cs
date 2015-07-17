using UnityEngine;
using System.Collections;

public class PlaneMovement : MonoBehaviour {

    public float speed = 2.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(-speed, 0, 0);
	
	}

    public void SetSpeed(float s)
    {
        speed = s;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile")
        {
            //Destroy(this.gameObject);
            GetComponent<Rigidbody>().isKinematic = false;
            gameObject.tag = "Destroyed";
        }
    }
}
