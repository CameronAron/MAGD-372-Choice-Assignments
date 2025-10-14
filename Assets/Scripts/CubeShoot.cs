using UnityEngine;

public class CubeShoot : MonoBehaviour, IPooledObject
{
    public float upForce = 1f;
    public float sideForce = .1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnObjectSpawn()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().linearVelocity = force;
    }
}
