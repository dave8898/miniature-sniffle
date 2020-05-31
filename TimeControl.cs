using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Time.timeScale = 0.25f;
        }
    if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Time.timeScale = 0.50f;
        }
    if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Time.timeScale = 0.75f;
        }
    if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Time.timeScale = 1f;
        }
    }
}
