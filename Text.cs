using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public GameManager gameManager;

    public TextMeshProUGUI hpText;
    public TextMeshProUGUI scoreText;

    public void Update()
    {
        hpText.text = gameManager.hp.ToString();
        scoreText.text = gameManager.score.ToString();
    }
}
