using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{

    public float speed;
    public float health;
    public Image healthBar;
    private bool downPressed;
    private bool upPressed;
    private bool downToched;
    private bool upToched;

    // Start is called before the first frame update
    void Start()
    {
      health /= 100;
    }

    // Update is called once per frame
    void Update()
    {
      if(health <= 0)
      {
        Destroy(gameObject);
      }
      healthBar.fillAmount=health;
      if(upToched != true)
      {
        if(upPressed){gameObject.transform.position += Vector3.up * speed * Time.deltaTime;}
      }
      if(downToched != true)
      {
        if(downPressed){gameObject.transform.position += Vector3.down * speed * Time.deltaTime;}
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
