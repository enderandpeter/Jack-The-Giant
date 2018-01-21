using UnityEngine;

public class PlayerMoveJoystick : MonoBehaviour {
    public float speed = 8f, maxVelocity = 4f;

    private Rigidbody2D myBody;
    private Animator anim;

    private bool moveLeft, moveRight;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	void FixedUpdate () {
        if (moveLeft)
        {
            MoveLeft();
        }

        if (moveRight)
        {
            MoveRight();
        }
	}

    void MoveLeft()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        if (vel < maxVelocity)
            forceX = -speed;

        if (transform.localScale.x >= 0)
        {
            flipXScale();
        }

        anim.SetBool("Walk", true);

        myBody.AddForce(new Vector2(forceX, 0));
    }

    void MoveRight()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        if (vel < maxVelocity)
            forceX = speed;

        if (transform.localScale.x < 0)
        {
            flipXScale();
        }

        anim.SetBool("Walk", true);

        myBody.AddForce(new Vector2(forceX, 0));
    }

    void flipXScale()
    {
        Vector3 temp = transform.localScale;
        temp.x = -temp.x;
        transform.localScale = temp;
    }

    public void SetMoveLeft(bool moveLeft)
    {
        this.moveLeft = moveLeft;
        this.moveRight = !moveLeft;
    }

    public void StopMoving()
    {
        moveLeft = moveRight = false;
        anim.SetBool("Walk", false);
    }
}
