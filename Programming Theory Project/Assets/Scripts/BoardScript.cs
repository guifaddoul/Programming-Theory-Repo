using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BoardScript : MonoBehaviour
{
    //GameObject linked to basic cell prefabs
    public GameObject StartCellParent;
    public GameObject EndCellParent;
    public GameObject[] OtherCell;

    //number of rows and columns in the grid
    private int columns = 10;
    private int rows = 10;

    //2D array storing the grib
    private GameObject[,] grid;

    
    //handle to Player
    private GameObject _player;

    //number of cell of different types allowed
    private int goodCellAmount = 30;
    private int badCellAmount = 40;
    private int regularCellAmount = 28;

    // Start is called before the first frame update
    void Start()
    {
        //We create the board
        CreateGrid();

        //we grab the player
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //We activate cells arround the player
         // ABSTRACTION
        ActivateCell();
        //We desactivate cells after the player
         // ABSTRACTION
        DesactivateCell();
    }
    

    //Function to create the grid
    private void CreateGrid()
    {
        grid = new GameObject[columns, rows];


        grid[0, 0] = (GameObject)Instantiate(StartCellParent, new Vector3(0, 0, 0), Quaternion.identity, gameObject.transform);
        grid[columns-1, rows-1] = (GameObject)Instantiate(EndCellParent, new Vector3(columns-1, 0, rows-1), Quaternion.identity, gameObject.transform);

        
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {  
                while(grid[i,j] == null)
                {
                    GameObject Cell = OtherCell[Random.Range(0, 3)];
                    if(Cell.gameObject.name == "BadCellParent" &&  badCellAmount > 0)
                    {
                        grid[i, j] = (GameObject)Instantiate(Cell, new Vector3(i, 0, j), Quaternion.identity, gameObject.transform);
                        badCellAmount--;
                    }
                    else if (Cell.gameObject.name == "GoodCellParent" && goodCellAmount > 0)
                    {
                        grid[i, j] = (GameObject)Instantiate(Cell, new Vector3(i, 0, j), Quaternion.identity, gameObject.transform);
                        goodCellAmount--;
                    }
                    else if (Cell.gameObject.name == "RegularCellParent" && regularCellAmount > 0)
                    {
                        grid[i, j] = (GameObject)Instantiate(Cell, new Vector3(i, 0, j), Quaternion.identity, gameObject.transform);
                        regularCellAmount--;
                    }
                }
            }
        }
    }



    //Activate the cells around the player
    private void ActivateCell()
    {
        //we activate a cell if:
        // it is near the player ; if it is in blank cell material

        //We grab the player position
        int playerColumn = _player.GetComponent<PlayerController>().getCurrentPosition()[0];
        int playerRow = _player.GetComponent<PlayerController>().getCurrentPosition()[1];
     
        for(int i = playerColumn - 1; i <= playerColumn +1; i++ )
        {
            for (int j = playerRow - 1; j <= playerRow + 1; j++)
            {
                if ((i >= 0) && (j >= 0))
                {
                    grid[i, j].GetComponent<CellParentScript>().coverPlane.SetActive(false);
                }
            }
        }
    }



    //Desactive Cell After Player
    private void DesactivateCell()
    {
        if( (_player.GetComponent<PlayerController>().getCurrentPosition()[0] != _player.GetComponent<PlayerController>().getPreviousPosition()[0]) 
            || (_player.GetComponent<PlayerController>().getCurrentPosition()[1] != _player.GetComponent<PlayerController>().getPreviousPosition()[1]) )
        {
            grid[_player.GetComponent<PlayerController>().getPreviousPosition()[0], _player.GetComponent<PlayerController>().getPreviousPosition()[1]].gameObject.SetActive(false);
        }
    }

}
