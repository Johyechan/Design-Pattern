using Manager;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            GameManager.Instance.ChangeScene(1);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            GameManager.Instance.ChangeScene(0);
        }
    }
}
