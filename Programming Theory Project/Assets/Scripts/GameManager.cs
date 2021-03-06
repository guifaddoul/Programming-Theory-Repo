using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameManager : MonoBehaviour
{
    //handles to UI elements
    public TextMeshProUGUI GameOverText;
    public TextMeshProUGUI WinText;
    public TextMeshProUGUI PlayerEnergyText;

    //handle to player
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //condition for GameOver
        if ( (_player.activeInHierarchy == false) || (_player.GetComponent<PlayerController>().getPlayerEnergy() <= 0 ) )
            GameOverText.gameObject.SetActive(true);

        //update of player energy UI
        PlayerEnergyText.text = "Player Energy : " + _player.GetComponent<PlayerController>().getPlayerEnergy();

        //condition for Winning
        if (_player.GetComponent<PlayerController>().getWiningStatus())
            WinText.gameObject.SetActive(true);

    }

}
