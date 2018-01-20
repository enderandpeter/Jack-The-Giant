using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour {

    private float minX, maxX;
    SpriteRenderer sp;
    private float halfPlayerWidth;

    // Use this for initialization
    void Start () {
        SetMinAndMaxX();
        sp = GetComponent<SpriteRenderer>();
        halfPlayerWidth = sp.size.x / 2;
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x - halfPlayerWidth < minX)
        {
            Vector3 temp = transform.position;
            temp.x = minX + halfPlayerWidth;
            transform.position = temp;
        }

        if (transform.position.x + halfPlayerWidth > maxX)
        {
            Vector3 temp = transform.position;
            temp.x = maxX - halfPlayerWidth;
            transform.position = temp;
        }
    }

    void SetMinAndMaxX()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        maxX = bounds.x;
        minX = -bounds.x;
    }
}
