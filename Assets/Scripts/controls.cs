using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
	public float speed = 50.0f;
	private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    // FixedUpdate is the physics update
    void FixedUpdate() {
    	Move( new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) );
    }

    void Move(Vector2 direction) {
    	rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }
}
