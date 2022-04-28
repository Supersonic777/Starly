using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    public float speed;
    public float damage;
    public float timeToDestroy = 10;
    private float rotationSpeed;
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
      damage /= 100; //получаем дробное число в диапазоне от 0.0 до 1.0 для адекватного взаимодействия с HealthBar
      rotationSpeed = Random.Range(-20,20);
      speed+=Random.Range(0,1);
      player = GameObject.FindGameObjectWithTag("Player");
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
    void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "Player")
      {
        player.GetComponent<PlayerController>().health -= damage;
        Destroy(gameObject);
      }
    }
}
