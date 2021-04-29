using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 8f;
    public float torquerange = 10f;
    public ParticleSystem particle2;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * speed, ForceMode.Impulse);
        rb.AddTorque(Random.Range(-torquerange, torquerange), Random.Range(-torquerange, torquerange), 0, ForceMode.Impulse);
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        Gamemanager.instance.UpdateScore();
        Gamemanager.instance.playmusic();
        GameObject temp = Instantiate(particle2, transform.position, particle2.transform.rotation).gameObject;
        Destroy(temp, 2f);
    }
}