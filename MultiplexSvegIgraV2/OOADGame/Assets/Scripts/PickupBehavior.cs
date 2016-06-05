using UnityEngine;
using System.Collections;

public class PickupBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "player")
        {
            Destroy(gameObject);
        }
    }
}
