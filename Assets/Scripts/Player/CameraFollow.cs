using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Vector3 cameraDistance;

    [SerializeField]
    private float cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 followVec = new Vector3(player.position.x + cameraDistance.x,
                                        transform.position.y,
                                        player.position.z + cameraDistance.z);


        transform.position = Vector3.Lerp(transform.position, followVec, Time.deltaTime * cameraSpeed);
    }
}
