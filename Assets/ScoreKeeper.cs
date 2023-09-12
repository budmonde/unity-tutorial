using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreKeeper : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    [ContextMenu("Increment Score")]
    public void IncrementScore() {
        score += 1;
        scoreText.text = score.ToString();
    }
}
