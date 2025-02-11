using UnityEngine;
using UnityEngine.SceneManagement;

namespace Manager
{
    public class GameManager : Singleton<GameManager>
    {
        public void ChangeScene(int sceneNum)
        {
            SceneManager.LoadScene(sceneNum);
        }
    }
}

