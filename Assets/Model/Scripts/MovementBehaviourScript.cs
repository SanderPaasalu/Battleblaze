using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviourScript : MonoBehaviour
{
    private float lookAngle;
    private Vector3 lookDirection;
    private float movementSpeed = 20f;
    private float maxVelocity = 7f;

    // Update is called once per frame
    public void MovePlayer(Rigidbody2D playerBody)
    {
        // Player movement
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        playerBody.velocity += new Vector2(movementSpeed * x, movementSpeed * y) * Time.deltaTime;
        playerBody.velocity = Vector2.ClampMagnitude(playerBody.velocity, maxVelocity); ;

        Rotate(playerBody);
    }

    // Function that deals with local rotation
    public void Rotate(Rigidbody2D body)
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - body.transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        body.transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90);
    }
}
