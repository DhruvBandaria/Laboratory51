using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rBody2d;
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        rBody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Used when manipulating physics
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rBody2d.velocity = new Vector2(horizontal * speed, vertical * speed);

        //gameObject.Transform.Position(new Vector2(Transform.Position.x, Transform.Position.y));
        gameObject.transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y,-10),transform.rotation);
    }
}
