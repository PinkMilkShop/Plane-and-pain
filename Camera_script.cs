using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_script : MonoBehaviour
{
    public float CameraSpeed = 0.1f;
    public float CameraSpeedAfterStop = 0.01f;
    public Transform Camera;
    public Transform Player;
    
    void Update()
    {
        Vector3 cameraPosition = Camera.position;
        float zPosition = Mathf.Lerp(Camera.position.z, Player.position.z, CameraSpeed);
        float yPosition = Mathf.Lerp(Camera.position.y, Player.position.y, CameraSpeed);
        if (Player.position.z > 146.7003)
        {
            zPosition = Mathf.Lerp(Camera.position.z, Player.position.z, CameraSpeedAfterStop);
            //zPosition = 145.1368f;
        }
        if (Player.position.y > 70.92825f)
        {
            yPosition = Mathf.Lerp(Camera.position.y, Player.position.y, CameraSpeedAfterStop);
            //yPosition = 72.39418f;
        }
        if (Player.position.z < -144.8626)
        {
            zPosition = Mathf.Lerp(Camera.position.z, Player.position.z, CameraSpeedAfterStop);
            //zPosition = -143.8599f;
        }
        cameraPosition = new Vector3(50f, yPosition, zPosition);
        Camera.position = cameraPosition;

    }
}
