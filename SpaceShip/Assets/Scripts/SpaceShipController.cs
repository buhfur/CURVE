using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ryan mcvicker
public class SpaceShipController : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject FirstPersonCam;
    public GameObject ThirdPersonCam;
    public float pitch = 60f;
    public float yaw = 60f;
    public float roll = 1000f;
    public float sensitivityX = 30.0f;
    public float sensitivityY = 30.0f;
    public Rigidbody rigidBody;
    public float speed = 90.0f;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position += transform.forward * 0.5f;
        if (FirstPersonCam.activeSelf)
        {

            if (Input.GetKey(KeyCode.W))
            {

                transform.position += transform.forward * Time.deltaTime * speed;
            }
            else
            {
                //slow down the plane


            }

            transform.Rotate(
                Input.GetAxis("Vertical") * Time.deltaTime * yaw,
                Input.GetAxis("Mouse X") * Time.deltaTime * pitch,
                Input.GetAxis("Horizontal") * Time.deltaTime * roll);


            float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

            if (terrainHeightWhereWeAre > transform.position.y)
            {
                transform.position = new Vector3(transform.position.x,
                                                 terrainHeightWhereWeAre,
                                                 transform.position.z);
            }


        }
        else if (ThirdPersonCam.activeSelf)
        {

            //if the player view is in third person, then the controls change 
            transform.position += transform.forward * Time.deltaTime * 0.5f;


           


        }
    }
    

}
