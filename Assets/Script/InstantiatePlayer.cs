using UnityEngine;

public class InstantiatePlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject gameManager;
    public bool isInstantiate; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!isInstantiate)
        {
            Instantiate(player, new Vector2(-8.58f, 15.0f), Quaternion.identity);
            isInstantiate = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameManager);
    }
}
