using UnityEngine;

public static class FDummyFactory
{
    private static int num = 0;

    public static FDummy CreateDummy(GameObject prefab, Vector3 position)
    {
        GameObject obj = Object.Instantiate(prefab, position, Quaternion.identity);
        obj.name += num;
        num++;
        FDummy dummy = obj.GetComponent<FDummy>();
        dummy.Initialized(100);
        return dummy;
    }
}
