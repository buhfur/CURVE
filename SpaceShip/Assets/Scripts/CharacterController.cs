using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Ryan McVicker
 * 9/10/2019
 */
public class CharacterController : MonoBehaviour
{
    public GameObject FirstPersonCam;
    public GameObject ThirdPersonCam;
    public GameObject Player;

    public float sensitivityX = 30.0f;
    public float sensitivityY = 30.0f;
    public float speed = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Vertical number is:" + Input.GetAxis("Vertical"));
        MoveCharacter();
    }

    void MoveCharacter()
    {
            // if the player is in first person, rotate FirstPersonCamera only
            if (FirstPersonCam.activeSelf)
            {
                //move the character around based on user input
                    if(Input.GetAxis("Vertical") > 0.0f)
                    {
                         Player.transform.position += Player.transform.forward * Time.deltaTime * speed;
                        //Player.transform.position += Player.transform.forward * Time.deltaTime * speed;
            }
                    else if(Input.GetAxis("Vertical") < 0.0f)
                    {
                         Player.transform.position -= Player.transform.forward * Time.deltaTime * speed;
                    }

                    Player.transform.Rotate(

                        Input.GetAxis("Mouse X") * Time.deltaTime * sensitivityX,
                        Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivityY, 0

                        );
            }
        /*if the ThirdPersonCam is active, rotate ThirdPersonCamera based on which mouse 
          button is being pressed
          
        -rotating the player rotates all of its children which are the two cameras
        
         
         */
            else
            {

                Vector3 moveCharacter = new Vector3(
                    Input.GetAxis("Vertical") * Time.deltaTime + speed,
                    0, 0);

                //if the user holds down left mouse button then rotate the player

                if (Input.GetMouseButtonDown(0))
                {

                    ThirdPersonCam.transform.Rotate(

                        Input.GetAxis("Mouse X") * Time.deltaTime * sensitivityX,
                        Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivityY, 0

                        );

                }

                //if user holds down the right mouse button, then it rotates the player

                else if(Input.GetMouseButtonDown(1))
                {

                    Player.transform.Rotate(

                        Input.GetAxis("Mouse X") * Time.deltaTime * sensitivityX,
                        Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivityY, 0

                    );

                }

            //if player is not holding down mouse buttons then use horizontal to turn 

                else
                {
                    //wanna rotate the Y to turn left and right

                    Player.transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * sensitivityX,0);

                }
            }
    }
}
