using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 8, -12);
    private bool isCameraSwitched = false;  
    public Camera mainCamera;
    public Camera seatCamera;

    void Start()
    {
        mainCamera.enabled = true;
        seatCamera.enabled = false;
    }

    void Update() 
    {
        if (Input.GetButtonDown("Camera"))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        isCameraSwitched = !isCameraSwitched;  
        mainCamera.enabled = !isCameraSwitched;  
        seatCamera.enabled = isCameraSwitched; 
    }

    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position 
        transform.position = player.transform.position + offset;
    }
}
