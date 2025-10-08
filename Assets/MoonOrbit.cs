using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public float orbitSpeed = 50f; 
    void Update()
    {
        transform.Rotate(Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
