using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlView : MonoBehaviour
{

    public GameObject FirstPersonCam;
    public GameObject ThirdPersonCam;
    public bool check = true;


    void Start()
    {
        ThirdPersonCam.SetActive(false);
        FirstPersonCam.SetActive(true);



    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            if (FirstPersonCam.activeSelf)
            {
                ThirdPersonCam.SetActive(true);
                FirstPersonCam.SetActive(false);
            }
            else
            {
                ThirdPersonCam.SetActive(false);
                FirstPersonCam.SetActive(true);
            }
        }
            
        

    }


    
}
