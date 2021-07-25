using UnityEngine;
using UnityEngine.UI;
using System;
public class Score : MonoBehaviour
{
    public Text score;
    public Transform player;
    private void Update()
    {
        float playerPosition = player.position.y;
        score.text = Math.Round(playerPosition).ToString();
    }

}
