using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{

    public float speed = 5f;             //Speed variable
    public Transform target;
    public float Range;
    bool isTarget = false;

    void FindPlayer()
    {

        target = GameObject.Find("player(Clone)").transform;
        if(target != null)
        {
            isTarget = true;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if(isTarget==false)
        {

            FindPlayer();
        }
        else
        {
            Vector2 direction = target.position - transform.position;
            if (direction.sqrMagnitude <= Range)
            {
              float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime); 
            }
            
            //Debug.Log(target.position.x);
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Range);
    }
}
