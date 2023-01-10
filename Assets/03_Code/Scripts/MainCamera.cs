using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public float FollowSpeed;
    public float yOffset;
    public float xOffset;
    public Transform player;
    public float camdistanz;

    void Update()
    {
        //MoveCamera();
    }

    private void LateUpdate()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        Vector3 newPos = new Vector3(player.position.x + xOffset, player.position.y + yOffset, camdistanz);
        //transform.position. = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        Vector3 StoragePosition = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
        transform.position = new Vector3(StoragePosition.x, player.position.y + yOffset, camdistanz);
        //transform.position = newPos;
    }


}
