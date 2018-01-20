using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 8f, maxVelocity = 4f;

    private Rigidbody2D myBody;
    private Animator anim;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// FixedUpdate is called once every few frames (ideal for physics)
	void FixedUpdate () {
        PlayerMoveKeyboard();
	}

    void PlayerMoveKeyboard()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        float h = Input.GetAxisRaw("Horizontal");

        if(h > 0) // Moving right
        {
            if (vel < maxVelocity)
                forceX = speed;

            if (transform.localScale.x < 0)
            {
                flipXScale();
            }

            anim.SetBool("Walk", true);
        }

        if(h < 0) // Moving Left
        {
            if (vel < maxVelocity)
                forceX = -speed;

            if (transform.localScale.x >= 0)
            {
                flipXScale();
            }

            anim.SetBool("Walk", true);
        }

        if (h == 0) // No movement detected
        {
            anim.SetBool("Walk", false);
        }

        myBody.AddForce(new Vector2(forceX, 0));
    }

    private void flipXScale()
    {
        Vector3 temp = transform.localScale;
        temp.x = -temp.x;
        transform.localScale = temp;
    }
}
