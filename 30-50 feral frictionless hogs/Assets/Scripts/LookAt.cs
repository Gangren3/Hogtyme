using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private GameObject hog;
    public GameObject FPS;
    private float timer;
    private float cooldown;
    private Rigidbody rb;


    private void Start()
    {
        hog = GetComponent<GameObject>();
        rb = GetComponent<Rigidbody>();
        timer = 5;
        
    }
    void Update()
    {
        transform.LookAt(FPS.transform);
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = 6;
            cooldown = .5f;
        }
        if (cooldown == .5f)
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
            rb.velocity = transform.forward * Random.Range(10, 20);
        }
    }
}
