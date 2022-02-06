using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{




    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Bullet Hit : " + (other.gameObject.name));
        //Play Collision Effect 
        Destroy(this.gameObject);
    }

}
