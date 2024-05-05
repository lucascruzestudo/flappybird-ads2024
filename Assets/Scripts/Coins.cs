using UnityEngine;

public class Coins : MonoBehaviour
{

    public GameManager gameManager;

    public float speed = 5f;
    public int coinValue = 1;

    private void Start()
    {
        if (gameManager == null) {
            var obj = GameObject.FindWithTag("GameController");
            gameManager = obj.GetComponent<GameManager>();
        }
    }

    private void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.Score+=coinValue;
        Destroy(gameObject);
    }

}
