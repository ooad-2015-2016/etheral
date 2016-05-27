using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public Vector2 playerSpeed = new Vector2(50, 50);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(playerSpeed.x * inputX, playerSpeed.y * inputY, 0);
        movement *= Time.deltaTime;

        transform.Translate(movement);

        shootingMechanism();
	}

    private void shootingMechanism()
    {
        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");

        if (Input.GetMouseButton(0))
        {
            ShootingScript weapon = GetComponent<ShootingScript>();
            if (weapon != null)
            {
                weapon.Attack(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnDestroy()
    {
        transform.parent.gameObject.AddComponent<GameOverScript>();
    }

}
