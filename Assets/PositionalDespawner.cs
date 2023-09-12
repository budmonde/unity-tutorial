using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionalDespawner : MonoBehaviour
{
    public float despawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < despawnPosition) {
            Destroy(gameObject);
        }
        
    }
}
