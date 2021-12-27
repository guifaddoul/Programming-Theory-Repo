using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BoardScript : MonoBehaviour
{
    //GameObject linked to basic cell prefabs
    public GameObject CellParent;

    private GameObject Cell;

    //number of rows and columns in the grid
    private int columns = 10;
    private int rows = 10;

    //2D array storing the grib
    private GameObject[,] grid;

    public Material startingCell;
    public Material endingCell;
    public Material blankCell;
    public Material goodCell;
    public Material badCell;

    //handle to Player
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();

        //we grab the player
        _player = GameObject.Find("Player");

        //We grab the Cell
        

        //We grab the text
    }

    // Update is called once per frame
    void Update()
    {
   //     grid[i, j].GetComponentInChildren




    }

    //Function to create the grid
    private void CreateGrid()
    {
        grid = new GameObject[columns, rows];
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                grid[i, j] = (GameObject)Instantiate(CellParent, new Vector3(i, 0, j), Quaternion.identity,gameObject.transform);
                grid[i, j].GetComponent<CellParentScript>().cell.GetComponent<Renderer>().material = blankCell;
            }
        }

        //We set the name material of the starting and ending cell
            grid[0, 0].GetComponent<CellParentScript>().cell.GetComponent<Renderer>().material  = startingCell;
            grid[columns-1, rows -1].GetComponent<CellParentScript>().cell.GetComponent<Renderer>().material  = endingCell;
    }



    //Activate the cells around the player
    private void ActivateCell()
    {
        //we activate a cell if:
        // it is near the player ; if it is in blank cell material

        //We grab the player position
        int playerColumn = _player.GetComponent<PlayerController>().player_location[0];
        int playerRow = _player.GetComponent<PlayerController>().player_location[1];

        for(int i = playerColumn - 1; i <= playerColumn +1; i++ )
        {
            for (int j = playerRow - 1; j <= playerRow + 1; j++)
            {
                if ( (i >= 0) && (j >= 0) && (grid[i, j].GetComponent<Renderer>().material == blankCell) )
                {
     //               grid[i, j].GetComponent<Renderer>().material = goodCell;
                }
            }
        }
    }
}
