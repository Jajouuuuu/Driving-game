using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moving our car foraward
        // Using transform here means that we are using our transform component of our object (whihch the script is attached to)
        // Both lines are doing the same things
        // 20 meters every seconds going forward (if we don't multiply by a number it means it's moving a meters by seconds)
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
        // transform.Translate(0, 0, 0.25f);

    }
}
