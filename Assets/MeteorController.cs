using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    public float speed;
    private float rotationSpeed;
    public float timeToDestroy = 10;
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(-20,20);
        speed+=Random.Range(0,1);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
        Invoke("Destroy", timeToDestroy);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime, Space.Self);
    }
    void Destroy()
    {
        Destroy(gameObject);
    }
}
