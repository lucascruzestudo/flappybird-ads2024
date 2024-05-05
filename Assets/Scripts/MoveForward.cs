using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
    }

    /*private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }*/
}
