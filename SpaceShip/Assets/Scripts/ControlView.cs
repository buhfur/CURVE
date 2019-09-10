using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlView : MonoBehaviour
{

    public GameObject FirstPersonCam;
    public GameObject ThirdPersonCam;
    //check determines which camera the level starts in
    //true for First person, false for third person
    public bool check = true;


    void Start()
    {
        if (check)
        {
                ThirdPersonCam.SetActive(false);
                FirstPersonCam.SetActive(true);
        }
        else
        {
                ThirdPersonCam.SetActive(true);
                FirstPersonCam.SetActive(false);
        }


    }

    void Update()
    {
        //ChangeView is a custom input be default, mapped to "R"  or "r"
        if(Input.GetButtonDown("ChangeView"))

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
