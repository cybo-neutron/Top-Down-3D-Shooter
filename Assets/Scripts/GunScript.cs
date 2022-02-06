using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Rigidbody bullet;
    [SerializeField] Transform spawnPosition;

    [Header("Properties")]
    public float speed;
    public float bulletAliveTime;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("Mouse button clicked");
            Shoot();
        }
    }



    void Shoot()
    {
        Rigidbody rb = Instantiate(bullet.gameObject, spawnPosition.position, spawnPosition.transform.rotation).GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed, ForceMode.Impulse);

        Destroy(rb.gameObject, bulletAliveTime);
    }
}
