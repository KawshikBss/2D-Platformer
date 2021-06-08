using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCount : MonoBehaviour
{
    public GameObject player;
    public Text coinsText;
    void Update()
    {
        coinsText.text = player.GetComponent<Player>().coinsCollected.ToString();
    }
}
