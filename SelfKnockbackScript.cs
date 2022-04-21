using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfKnockbackScript : MonoBehaviour
{
    public float range = 3f;
    public float KnockbackForce = 500;
    public Camera Cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ShootRaycast();
        }
    }

    void ShootRaycast()
    {
        RaycastHit hit;
        if(Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                Knockback();
            }
        }
    }

    void Knockback()
    {
        transform.position -= transform.forward * Time.deltaTime * KnockbackForce;
    }
}
