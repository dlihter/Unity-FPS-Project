using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullsEye : MonoBehaviour
{
    public Transform left;
    public Transform right;
    public float speed = 1.0f;

    bool direction = false;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (direction)
        {
            transform.position = Vector3.MoveTowards(transform.position, right.transform.position, Time.deltaTime * speed);
            if (transform.position == right.position)
            {
                direction = !direction; 
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, left.transform.position, Time.deltaTime * speed);
            if (transform.position == left.position)
            {
                direction = !direction;
            }
        }
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Rocket"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        
    }
}
