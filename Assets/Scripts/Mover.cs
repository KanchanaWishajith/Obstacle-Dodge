using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        printInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void printInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Use WASD or arrow keys to move the player");
        Debug.Log("Have fun!");
    }
    
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;

        xValue *= moveSpeed;
        zValue *= moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
