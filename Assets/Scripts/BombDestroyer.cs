using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombDestroyer : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 8f;
    public ParticleSystem particle1;
    public float torquerange = 10;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * speed, ForceMode.Impulse);
        rb.AddTorque(Random.Range(-torquerange, torquerange), Random.Range(-torquerange, torquerange), Random.Range(-torquerange, torquerange), ForceMode.Impulse);
    }
    private void OnMouseDown()
    {
            Destroy(gameObject);
            Gamemanager.instance.LessScore();
            Gamemanager.instance.Chances();
            Gamemanager.instance.playmusic();
            GameObject temp= Instantiate(particle1, transform.position, particle1.transform.rotation).gameObject;
        Destroy(temp,2f);
        if (Gamemanager.instance.chance <= 0)
            {
                 SceneManager.LoadScene(2);
            }
    }
}
