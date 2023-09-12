using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBasedGameOverSetter : MonoBehaviour
{
    public GameOverSetter gameOverSetter;
    // Start is called before the first frame update
    void Start()
    {
        gameOverSetter = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameOverSetter>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        gameOverSetter.SetGameOver();
        gameObject.GetComponent<JumpController>().enabled = false;
    }

}
