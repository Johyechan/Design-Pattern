using Manager;
using UnityEngine;

public class SDummy : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            SGameManager.Instance.ChangeScene(1);
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            SGameManager.Instance.ChangeScene(0);
        }
    }
}
