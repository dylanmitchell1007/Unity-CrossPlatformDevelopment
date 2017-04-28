using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {
  
    public GameObject ammo;
    public GameObject spawner;
    public int speed;

    void Shoot()
    {
        var spawn = (GameObject)Instantiate(ammo, spawner.transform.position, spawner.transform.rotation);
        spawn.GetComponent<Rigidbody>().velocity = ammo.transform.forward * speed;
        Destroy(spawn, 2.0f);
    }
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            
            Shoot();
        }
	}
}
