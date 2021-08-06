using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; //position, rotation, and scale

    public float smoothSpeed = 0.125f; //higher = faster to lock on to target 
    public Vector3 offset; 

    void FixedUpdate() //runs right after Update()
    {
        transform.position = target.position + offset;
        
    }
}
