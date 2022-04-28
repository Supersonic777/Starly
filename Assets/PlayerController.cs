using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{

    public float starlySpeed;
    public int starlyHealth;
    private float healthInFloat;
    private bool downPressed;
    private bool upPressed;
    private bool downToched;
    private bool upToched;

    // Start is called before the first frame update
    void Start()
    {
      healthInFloat = starlyHealth/100;
    }

    // Update is called once per frame
    void Update()
    {
      if(upToched != true)
      {
        if(upPressed){gameObject.transform.position += Vector3.up * starlySpeed * Time.deltaTime;}
      }
      if(downToched != true)
      {
        if(downPressed){gameObject.transform.position += Vector3.down * starlySpeed * Time.deltaTime;}
      }
    }
    public void OnButtonUp()
    {
      upPressed = true;
      downToched = false;
    }
    public void OnButtonDown()
    {
      downPressed = true;
      upToched = false;
    }
    public void Stay()
    {
      downPressed = false;
      upPressed = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "TopBorder")
      {
       upToched = true;
      }
      else
      {
       upToched = false;
      }
      if(collision.gameObject.tag == "DownBorder")
      {
       downToched = true;
      }
      else
      {
       downToched = false;
      }
    }
}
