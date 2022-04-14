using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject Bullit;
   void onCollisionEnter2D(Collision2D other)
    {
        GameObject effect =Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(this.gameObject);
    }
}
