
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    // Update is called once per frame
    public Transform player;
    public Text scoreText;
    void Update()
    {
        scoreText.text=(player.position.z+63.8).ToString("0");
    }
}
