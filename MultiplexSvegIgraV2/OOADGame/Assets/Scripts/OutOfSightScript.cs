using UnityEngine;
using System.Collections;

public class OutOfSightScript : MonoBehaviour {

    private bool hasAppeared = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        var renderer = GetComponent<Renderer>();
        if (renderer.isVisible)
        {
            hasAppeared = true;
        }

        if (hasAppeared)
        {
            if (!renderer.isVisible)
            {
                if (gameObject.name == "PlayerScript")
                {
                    
                }

                Destroy(gameObject);
            }
        }
    }
}
