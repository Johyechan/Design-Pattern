using UnityEngine;

public class FGameManager : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FDummyFactory.CreateDummy(_prefab, new Vector3(Random.Range(0, 10), 1, Random.Range(0, 10)));
        }
    }
}
