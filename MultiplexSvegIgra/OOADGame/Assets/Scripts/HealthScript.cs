using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

    public int HP = 2;
    public bool isEnemy = true;

    void OnTriggerEnter2D(Collider2D collider)
    {
        ShotScript shot = collider.gameObject.GetComponent<ShotScript>();

        if (shot != null)
        {
            if (shot.isEnemyShot != isEnemy)
            {
                HP -= shot.damage;
                Destroy(shot.gameObject);

                if (HP <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
