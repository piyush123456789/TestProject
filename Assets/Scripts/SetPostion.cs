using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPostion : MonoBehaviour
{
    [SerializeField] private GameObject leftWall, rightWall;
    
    void Start()
    {
        float xPos = (((2f * Camera.main.orthographicSize) * Camera.main.aspect) / 2);
        leftWall.transform.position = new Vector3((-1 * xPos)+ leftWall.GetComponent<BoxCollider2D>().size.x/2, leftWall.transform.position.y, leftWall.transform.position.z);
        rightWall.transform.position = new Vector3((1 * xPos)-rightWall.GetComponent<BoxCollider2D>().size.x / 2, rightWall.transform.position.y, rightWall.transform.position.z);


    }

   
}
