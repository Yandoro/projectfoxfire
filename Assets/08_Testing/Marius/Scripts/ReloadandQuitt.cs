using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadandQuitt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.Quit();
            Debug.Log("Spiel beenden");
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("GoldMaster_Scene_TestingFoxFire");
        }
    }
}
