using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //Move the Player
    public void PlayerMove(int steps)
    {
        gameObject.transform.Translate(Vector3.right * 3000 * Time.deltaTime);
    }

}
