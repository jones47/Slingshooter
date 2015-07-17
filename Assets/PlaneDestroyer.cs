using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlaneDestroyer : MonoBehaviour {

    public Text missCounterText;
    int missCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.collider.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (other.tag == "Plane")
        {
            missCounter++;
            missCounterText.text = "Missed planes " + missCounter;
        }
    }
}
