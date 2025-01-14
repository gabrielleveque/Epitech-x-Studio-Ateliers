using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
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
        if (target.position.x >= 0)
        {
            transform.position = new Vector3 (0.0f, 0.0f, -10.0f);
        }
        else
        {
            transform.position = new Vector3 (target.position.x, 0.0f, -10.0f);
        }
    }
}
