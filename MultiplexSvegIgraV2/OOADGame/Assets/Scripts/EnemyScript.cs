using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    private ShootingScript[] weapons;

	// Use this for initialization
	void Start () {
	
	}

    void Awake ()
    {
        weapons = GetComponentsInChildren<ShootingScript>();
    }
	
	// Update is called once per frame
	void Update () {
	    
        foreach (ShootingScript weapon in weapons)
        {
            if (weapon != null && weapon.CanAttack)
            {
                weapon.Attack(true);
            }
        }

        // Destroy(gameObject, 10);
	}
}
