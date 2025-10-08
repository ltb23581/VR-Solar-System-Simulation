using UnityEngine;

public class EarthOrbit : MonoBehaviour
{
    public float orbitSpeed = 10f; // Degrees per second

    void Update()
    {
        transform.Rotate(Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
