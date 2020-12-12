using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public Vector3 target;
    private Vector3 direction;
    public float moveSpeed;

    public float spinSpeed;
    private Quaternion spin;

    // OnEnable is called when the gameobject is set to active
    void OnEnable()
    {
        spin = Random.rotation;
        direction = target - transform.position;
    }

    // Update is called at a consistent rate with regards to time
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, transform.rotation * spin, spinSpeed);
        transform.position += direction * moveSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }
}
