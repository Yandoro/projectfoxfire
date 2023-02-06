using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(ExampleCoroutine());
    }
    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(37f);

        //After we have waited 5 seconds print the time again.
        SceneManager.LoadScene("GoldMaster_Scene_TestingFoxFire");
    }
}
