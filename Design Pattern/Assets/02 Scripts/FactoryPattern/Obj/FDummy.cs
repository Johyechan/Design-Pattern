using UnityEngine;

public class FDummy : MonoBehaviour
{
    public int Health { get; set; }

    public void Initialized(int health)
    {
        Health = health;
        Debug.Log($"{transform.name} Health: {health}");
    }
}
