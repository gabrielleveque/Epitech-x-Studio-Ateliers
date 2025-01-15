using UnityEngine;

public class CameraHubFollowPlayer : MonoBehaviour
{
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target.position.y <= 0)
        {
            transform.position = new Vector3 (0.0f, 0.0f, -10.0f);
        }
        else
        {
            transform.position = new Vector3 (target.position.x, target.position.y, -10.0f);
        }
    }
}
