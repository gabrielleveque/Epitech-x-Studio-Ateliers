using UnityEngine;

public class CameraFollowPlayerinVertical : MonoBehaviour
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
        else if (target.position.y >= 21.30)
        {
            transform.position = new Vector3 (0.0f, 21.30f, -10.0f);
        }
        else
        {
            transform.position = new Vector3 (0.0f, target.position.y, -10.0f);
        }
    }
}

