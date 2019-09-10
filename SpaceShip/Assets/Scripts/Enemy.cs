using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float health;

    // Start is called before the first frame update
    
    public void TakeDamage(float damageIn)
    {
        health -= damageIn;
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
