using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayMove movement;
   
    // Start is called before the first frame update
  void OnCollisionEnter(Collision collInfo)
    {
        string str = "Collideobj";
        int n = str.Length;
        Debug.Log(collInfo.collider.name);
        if (collInfo.collider.name.Substring(0,10)==str)
        {
            movement.enabled = false;
            //FindObjectofType<GameManager>().EndGame();
            FindObjectOfType<GManage>().EndGame();
        }
    }
}
