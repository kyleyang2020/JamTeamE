using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static int scoreCount;

    // Update is called once per frame
    void Update()
    {
        score.text = scoreCount.ToString();
    }
}
