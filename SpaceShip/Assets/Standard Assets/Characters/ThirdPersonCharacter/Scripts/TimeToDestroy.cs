using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float timer;

    void Start()
    {
        Destroy(this.gameObject, timer);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
