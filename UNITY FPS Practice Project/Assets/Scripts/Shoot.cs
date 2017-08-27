using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject rocketPrefab;    
    public float flyForce;

    private Transform rocketParent;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Fireing();
        }
	}

    void Fireing()
    {
        GameObject rocketClone = Instantiate(rocketPrefab, transform.position, transform.parent.rotation);
        rocketClone.transform.SetParent(rocketParent);

        flyForce = rocketClone.GetComponent<Rocket>().Speed;
        rocketClone.GetComponent<Rigidbody>().AddForce(rocketClone.transform.forward * flyForce);
    }
}
