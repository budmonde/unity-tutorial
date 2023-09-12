using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float jumpStrength;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
        foreach (Touch touch in Input.touches) {
            if (touch.phase == TouchPhase.Began) {
                Jump();
            }
        }
    }

    void Jump() => rigidBody.velocity = Vector2.up * jumpStrength;
}
