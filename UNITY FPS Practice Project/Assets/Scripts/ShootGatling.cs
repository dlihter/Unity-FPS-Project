using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGatling : MonoBehaviour
{
    public GameObject BulletePrefab;
    public Transform BulletParent;
    //public Transform FiringPoint;
    public float Power = 10.0f;

    public List<Transform> FiringPoints;
    

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // ukoliko je GetButton onda samo držimo i puca svaki frame. Ovako samo kad se tipka stisne
        {
            ShootProjectiles();
        }
    }

    private void ShootProjectiles()
    {
        foreach (Transform FiringPoint in FiringPoints)
        {
            GameObject projectileClone = Instantiate(BulletePrefab, FiringPoint.position, Quaternion.identity);
            projectileClone.transform.SetParent(BulletParent);

            Rigidbody projectileRigidbody = projectileClone.GetComponent<Rigidbody>(); //dohvatili smo rigidbody metka da bi mogli utjecati silom na njega
            projectileRigidbody.AddForce(FiringPoint.forward * Power * Time.deltaTime, ForceMode.VelocityChange); //dodaje silu projektilu bez obzira na masu
        }
    }
}
