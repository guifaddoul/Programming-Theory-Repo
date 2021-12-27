using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class UIScript : MonoBehaviour
{
    private PlayerController _player;


    public TextMeshProUGUI DiceText;

    // Start is called before the first frame update
    void Start()
    {
  //      _player = GameObject.Find("Player").GetComponent<PlayerController>() ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //We generate a number between 1 and 4
/*    public void GenerateNumber()
    {
        int random_number = Random.Range(1, 5);
        DiceText.text = random_number.ToString() ;

        _player.PlayerMove(random_number);
    }
    */
}
