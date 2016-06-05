using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public Vector2 playerSpeed = new Vector2(50, 50);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("main_menu_scene");
            TestScript.forGUI = 0;
        }

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
    }

    void OnDestroy()
    {
        transform.parent.gameObject.AddComponent<GameOverScript>();
    }

}
