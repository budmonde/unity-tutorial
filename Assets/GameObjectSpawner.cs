using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameObjectSpawner : MonoBehaviour
{
    public GameObject spawnPrefab;
    public float spawnInterval;
    public float heightOffset;
    private float spawnTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer < spawnInterval) {
            spawnTimer += Time.deltaTime;
        } else {
            Spawn();
            spawnTimer = 0f;
        }
        
    }
    void Spawn() {
        float lowest_point = transform.position.y - heightOffset;
        float highest_point = transform.position.y + heightOffset;
        float position_y = Random.Range(lowest_point, highest_point);
        Instantiate(spawnPrefab,
                    new Vector3(transform.position.x, position_y, transform.position.z),
                    transform.rotation);
    }
}