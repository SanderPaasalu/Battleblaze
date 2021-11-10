using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{

    Rigidbody2D playerBody;

    public float z_Rotation;
    private Vector3 lookDirection;
    private float lookAngle;


    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player movement
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        playerBody.velocity = new Vector2(10 * x, 10 * y);

        // Mouse tracking
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Debug.Log(mousePos);

        float mouseX = mousePos.x;
        float mouseY = mousePos.y;

        //transform.Rotate(new Vector3(0, 0, (z_Rotation == 0) ? z_Rotation * Time.deltaTime * 10 : 0));
        Rotate();
    }

    private void Rotate()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90);
    }
}
