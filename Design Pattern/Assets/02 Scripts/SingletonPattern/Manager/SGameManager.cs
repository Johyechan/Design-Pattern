using UnityEngine;
using UnityEngine.SceneManagement;

namespace Manager
{
    public class SGameManager : Singleton<SGameManager>
    {
        public void ChangeScene(int sceneNum)
        {
            SceneManager.LoadScene(sceneNum);
        }
    }
}

