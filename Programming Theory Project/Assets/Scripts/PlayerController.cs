using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //array containing the player location on the grid
    // Array of size 2; First value is the column position
    // Second value is the row position
    public int[] player_location;


    //player move speed
    private float _speed = 0.2f;

    public bool allowedUp;
    public bool allowedDown;
    public bool allowedRight;
    public bool allowedLeft;

    // Start is called before the first frame update
    void Start()
    {
        player_location = new int[2];
        player_location[0] = 0;
        player_location[1] = 0;

        allowedUp = true;
        allowedDown = false;
        allowedRight = true;
        allowedLeft = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && allowedUp)
        {
            PlayerMoveUp();
        }

        if (Input.GetKeyDown(KeyCode.S) && allowedDown)
        {
            PlayerMoveDown();
        }

        if (Input.GetKeyDown(KeyCode.D) && allowedRight)
        {
            PlayerMoveRight();
        }

        if (Input.GetKeyDown(KeyCode.A) && allowedLeft)
        {
            PlayerMoveLeft();
        }
    }


    //Move the Player
    public void PlayerMoveUp()
    {
        while (gameObject.transform.position.z < (player_location[1] + 1))
            gameObject.transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        player_location[1] += 1;

    }

    public void PlayerMoveDown()
    {
        while (gameObject.transform.position.z > (player_location[1] -1 ))
            gameObject.transform.Translate(Vector3.back * _speed * Time.deltaTime);

        player_location[1] -= 1;

    }

    public void PlayerMoveRight()
    {
        while (gameObject.transform.position.x < (player_location[0] + 1))
            gameObject.transform.Translate(Vector3.right * _speed * Time.deltaTime);

        player_location[0] += 1;

    }

    public void PlayerMoveLeft()
    {
        while (gameObject.transform.position.x > (player_location[1] - 1))
            gameObject.transform.Translate(Vector3.left * _speed * Time.deltaTime);

        player_location[0] -= 1;

    }

}
