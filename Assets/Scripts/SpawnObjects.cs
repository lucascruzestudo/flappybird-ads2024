using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public float maxTime;
    public List<GameObject> prefabs;

    public float maxHeight;
    public float minHeight;

    private float timer;

    private void Start()
    {
        InstantiateObject();
    }

    private void Update()
    {
        if (timer > maxTime) {
            InstantiateObject();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void InstantiateObject()
    {
        var prefab = prefabs[Random.Range(0, prefabs.Count)];
        var instance = Instantiate(prefab);
        var y = Random.Range(minHeight, maxHeight);
        instance.transform.position = transform.position + new Vector3(0, y);

        Destroy(instance, 20f);
    }
}
