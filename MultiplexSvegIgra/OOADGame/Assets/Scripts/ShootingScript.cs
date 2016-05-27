using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {

    public Transform shotPrefab;
    public float shootingRate = 0.3f;
    public float cooldown;

	// Use this for initialization
	void Start () {

        cooldown = 0f;
	}
	
	// Update is called once per frame
	void Update () {
	    
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
	}

    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            cooldown = shootingRate;

            // kreira se novi shot
            var shotTransform = Instantiate(shotPrefab) as Transform;

            // dodjeljuje mu se pozicija
            shotTransform.position = transform.position;

            ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
            if (shot != null)
            {
                shot.isEnemyShot = isEnemy;
            }

            MovementScript move = shotTransform.gameObject.GetComponent<MovementScript>();
            if (move != null)
            {
                move.direction = this.transform.right;
            }
        }
    }

    public bool CanAttack
    {
        get
        {
            return cooldown <= 0f;
        }
    }
}
