using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float starlySpeed;
    private bool downPressed;
    private bool upPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(upPressed){gameObject.transform.position += Vector3.up * starlySpeed * Time.deltaTime;}
      if(downPressed){gameObject.transform.position += Vector3.down * starlySpeed * Time.deltaTime;}
    }
    public void OnButtonUp()
    {
      upPressed = true;
    }
    public void OnButtonDown()
    {
      downPressed = true;
    }
    public void Stay()
    {
      downPressed = false;
      upPressed = false;
    }
}
