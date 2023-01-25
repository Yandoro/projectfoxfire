using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject checkpointfire;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        checkpointfire.SetActive(true);
    }
}
