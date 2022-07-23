using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerBuffer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [Range(1.0f, 10.0f)][SerializeField] private float cameraOffsetX = 5.0f;
    [Range(1.0f, 10.0f)][SerializeField] private float cameraOffsetY = 5.0f;

    // Update is called once per frame
    void Update()
    {
        if(player.position.x < transform.position.x - (0.5f * cameraOffsetX)) //Left
        {
            transform.position = new Vector3(
                player.position.x+ ( 0.5f * cameraOffsetX),
                transform.position.y,
                transform.position.z
            );
        }
        else if(player.position.x > transform.position.x + (0.5f * cameraOffsetX))
        {
            transform.position = new Vector3(
                player.position.x - ( 0.5f * cameraOffsetX),
                transform.position.y,
                transform.position.z
            );
        }

        if(player.position.y < transform.position.y - (0.5f * cameraOffsetY)) //Left
        {
            transform.position = new Vector3(
                transform.position.x,
                player.position.y + ( 0.5f * cameraOffsetY),
                transform.position.z
            );
        }
        else if(player.position.y > transform.position.y + (0.5f * cameraOffsetY))
        {
            transform.position = new Vector3(
                transform.position.x,
                player.position.y - ( 0.5f * cameraOffsetY),
                transform.position.z
            );
        }
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(cameraOffsetX, cameraOffsetY, 0.0f));
    }
}
