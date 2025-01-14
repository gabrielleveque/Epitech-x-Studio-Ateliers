using UnityEngine;

public class InstantiatePlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject gameManager;
    public bool isInstantiate; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(isInstantiate);
        if (!isInstantiate)
        {
            Instantiate(player, new Vector2(0.0f, 0.0f), Quaternion.identity);
            isInstantiate = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameManager);
    }
}
