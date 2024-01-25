using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Priovate variables
    private float speed = 35.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player's input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moving our car foraward
        // Using transform here means that we are using our transform component of our object (whihch the script is attached to)
        // Both lines are doing the same things
        // 20 meters every seconds going forward (if we don't multiply by a number it means it's moving a meters by seconds)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // transform.Translate(0, 0, 0.25f);
        // allows to go on left and right but not a rotation
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // allows to rotate for exemple to do a drift
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);

    }
}
