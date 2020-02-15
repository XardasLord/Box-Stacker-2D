using UnityEngine;
using System.Collections;

public class InitialVelocity : MonoBehaviour {

    public Vector3 initVel;

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = initVel;
    }

}
