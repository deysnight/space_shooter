using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_script : MonoBehaviour {

    public GameObject my_camera;

    public int panel = 0;
    public bool inmove = false;
    Vector3 panel_0 = new Vector3(0, 0, -10.0f);
    Vector3 panel_1 = new Vector3(0, -10.0f, -10.0f);
    Vector3 panel_2 = new Vector3(0, -20.0f, -10.0f);
    Vector3 panel_3 = new Vector3(18.0f, -10.0f, -10.0f);

    Vector3 target;
    int target_panel;

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
                //Initiate.Fade("test2", Color.black, 1.0f);
                Application.Quit();
            }
            if (Input.GetButtonDown("Fire1"))
            {
                target = panel_1;
                inmove = true;
                target_panel = 1;
            }
            if (inmove == true)
            {
                my_camera.transform.position = Vector3.Lerp(my_camera.transform.position, target, 0.05f);
            }
            if (my_camera.transform.position == target)
            {
                panel = target_panel;
                inmove = false;
            }
        }
        else if (panel == 1)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                target = panel_0;
                target_panel = 0;
                inmove = true;
            }
            if (inmove == true)
            {
                my_camera.transform.position = Vector3.Lerp(my_camera.transform.position, target, 0.05f);
            }
            if (my_camera.transform.position == target)
            {
                panel = target_panel;
                inmove = false;
            }
        }
        else if (panel == 2)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                target = panel_1;
                target_panel = 1;
                inmove = true;
            }
        }
        else if (panel == 3)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                target = panel_1;
                target_panel = 1;
                inmove = true;
            }
        }
    }

    public void play_button()
    {
        print("play");
    }

    public void stats_button()
    {
        target = panel_2;
        target_panel = 2;
        inmove = true;
    }

    public void setting_button()
    {
        target = panel_3;
        target_panel = 3;
        inmove = true;
    }

    public void about_button()
    {
        target = panel_3;
        target_panel = 3;
        inmove = true;
    }

    public void button_return()
    {
        if (panel == 1)
        {
            target = panel_0;
            target_panel = 0;
            inmove = true;
        }
        else if (panel == 2 || panel == 3)
        {
            target = panel_1;
            target_panel = 1;
            inmove = true;
        }
    }
}
