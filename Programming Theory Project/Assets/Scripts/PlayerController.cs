using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //array containing the player location on the grid
    // Array of size 2; First value is the column position
    // Second value is the row position
    private int[] player_location;

    private int[] playerPrevious_location;


    //player move speed
    private float _speed = 0.005f;

    //bolean indicating fi the player reached the target
    private bool won = false;

    //player energy
    private int playerEnergy = 50;

    // Start is called before the first frame update
    void Start()
    {
        player_location = new int[2];
        player_location[0] = 0;
        player_location[1] = 0;

        playerPrevious_location = new int[2];
        UpdatePreviousPosition();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && !won)
        {
            PlayerMoveUp();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && !won)
        {
            PlayerMoveDown();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !won)
        {
            PlayerMoveRight();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && !won)
        {
            PlayerMoveLeft();
        }

        if (gameObject.transform.position.y < -1)
            DesactivatePlayer();
    }


    //Move the Player Up and update previous and current position
    public void PlayerMoveUp()
    {
        while (gameObject.transform.position.z < (player_location[1] + 1))
            gameObject.transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        UpdatePreviousPosition();
        player_location[1] += 1;

    }

    //Move the Player Down and update previous and current position
    public void PlayerMoveDown()
    {
        while (gameObject.transform.position.z > (player_location[1] -1 ))
            gameObject.transform.Translate(Vector3.back * _speed * Time.deltaTime);

        UpdatePreviousPosition();
        player_location[1] -= 1;

    }

    //Move the Player Right and update previous and current position
    public void PlayerMoveRight()
    {
        while (gameObject.transform.position.x < (player_location[0] + 1))
            gameObject.transform.Translate(Vector3.right * _speed * Time.deltaTime);

        UpdatePreviousPosition();
        player_location[0] += 1;

    }

    //Move the Player Left and update previous and current position
    public void PlayerMoveLeft()
    {
        while (gameObject.transform.position.x > (player_location[0] - 1))
            gameObject.transform.Translate(Vector3.left * _speed * Time.deltaTime);

        UpdatePreviousPosition();
        player_location[0] -= 1;

    }

    //Getter for current position
    public int[] getCurrentPosition()
    {
        return player_location;
    }

    //Getter for previous position
    public int[] getPreviousPosition()
    {
        return playerPrevious_location;
    }

    //Getter for winning status
    public bool getWiningStatus()
    {
        return won;
    }

    //Setter for winning status
    public void setWiningStatus(bool winningStatus)
    {
         won = winningStatus;
    }

    //Getter for player Energy
    public int getPlayerEnergy()
    {
        return playerEnergy;
    }

    //Setter for player Energy
    public void setPlayerEnergy(int change)
    {
        playerEnergy += change;
    }



    //Update the previous position values using "almost old" current position
    private void UpdatePreviousPosition()
    {
        playerPrevious_location[0] = player_location[0];
        playerPrevious_location[1] = player_location[1];
    }


    
    //Set the player Inactive
    private void DesactivatePlayer()
    {  
            gameObject.SetActive(false);
    }




}
