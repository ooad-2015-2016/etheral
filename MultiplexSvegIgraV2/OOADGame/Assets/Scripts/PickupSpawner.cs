using UnityEngine;
using System.Collections;

public class PickupSpawner : MonoBehaviour
{

    public GameObject[] pickups;
    private float cooldown = -2f;
    public float cooldownAmount = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (cooldown < 0)
        {
            spawnEnemy();
            cooldown = cooldownAmount;
        }

        cooldown -= Time.deltaTime;
    }

    public void spawnEnemy()
    {
        Vector3 createPosition = new Vector3(Random.Range(15, 30), Random.Range(-7, 7), 0);
        Instantiate(pickups[(int)Random.Range(0, pickups.Length)], createPosition, transform.rotation);
    }
}
