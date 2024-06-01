using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerController : MonoBehaviour
{
    public int speed;
    public Rigidbody2D playerRb;

    public float hInput;
    public float vInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        playerRb.velocity = new Vector2(hInput * speed, vInput * speed);
    }
}

