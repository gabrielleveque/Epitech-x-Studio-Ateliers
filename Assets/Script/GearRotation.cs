using UnityEngine;

public class GearRotation : MonoBehaviour
{

    public PlaceGear placeGear;
    public float rotationZ = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (placeGear.rotate)
        {
            Vector3 rotation = Vector3.zero;

            rotation.z += rotationZ;
            transform.Rotate(rotation);
        }
    }
}