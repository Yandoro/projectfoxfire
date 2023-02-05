using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFoxFireBlastMovement : MonoBehaviour
{
    [SerializeField] float Speed = 5;
    [SerializeField] float destroyAfter = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Die());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * Speed * Time.deltaTime;
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(destroyAfter);
        Destroy(gameObject);
    }
}
