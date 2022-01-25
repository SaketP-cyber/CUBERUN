
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GManage gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
