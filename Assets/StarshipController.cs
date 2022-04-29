using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarshipController : MonoBehaviour
{
    public float speed;
    public float timeToDestroy = 30;
    
    // Start is called before the first frame update
    void Start()
    {
      speed+=Random.Range(0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
        Invoke("Destroy", timeToDestroy);
    }
    void Destroy()
    {
        Destroy(gameObject);
    }
}
