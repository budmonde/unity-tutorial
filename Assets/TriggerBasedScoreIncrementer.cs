using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBasedScoreIncrementer : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    public LayerMask triggerLayer;
    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreKeeper>();
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (triggerLayer != (triggerLayer | (1 << other.gameObject.layer))) {
            return;
        }
        scoreKeeper.IncrementScore();
    }

}
