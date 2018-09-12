using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(movHorizontal, 0.0f, movVertical);

        rb.AddForce(movement*speed);
     }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
