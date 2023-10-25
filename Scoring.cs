using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    private int Scoreplayer1 = 0;
    private int Scoreplayer2 = 0;
    public GameObject player1txtscore;
    public GameObject player2txtscore;

    public int goalScore;

    void Update()
    {
        if (this.Scoreplayer1 >= goalScore || this.Scoreplayer2 >= goalScore)
        {
            Debug.Log("Game Won");
        }
    }
    public void FixedUpdate()
    {
        TMP_Text UIscoreP1 = this.player1txtscore.GetComponent<TextMeshProUGUI>();
        UIscoreP1.text = this.Scoreplayer1.ToString();

        TMP_Text UIscoreP2 = this.player2txtscore.GetComponent<TextMeshProUGUI>();
        UIscoreP2.text = this.Scoreplayer2.ToString();
    }
    public void Goalplayer1()
    {
        this.Scoreplayer1++;
    }
    public void Goalplayer2()
    {
        this.Scoreplayer2++;
    }
}