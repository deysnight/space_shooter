using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_script : MonoBehaviour {

    public GameObject my_camera;

    public int panel = 0;
    public bool inmove = false;
    Vector3 panel_0 = new Vector3(0, 0, -10.0f);
    Vector3 panel_1 = new Vector3(0, -10.0f, -10.0f);

    // Use this for initialization
    void Start () {
        panel = 0;
	}

    void Update()
    {
        if (panel == 0)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
            if (Input.GetButtonDown("Fire1"))
                inmove = true;
            if (inmove == true)
            {
                my_camera.transform.position = Vector3.Lerp(my_camera.transform.position, panel_1, 0.05f);
            }
            if (my_camera.transform.position == panel_1)
            {
                panel = 1;
                inmove = false;
            }
        }
        else if (panel == 1)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                inmove = true;
            if (inmove == true)
            {
                my_camera.transform.position = Vector3.Lerp(my_camera.transform.position, panel_0, 0.05f);
            }
            if (my_camera.transform.position == panel_0)
            {
                panel = 0;
                inmove = false;
            }
        }


    }
}
