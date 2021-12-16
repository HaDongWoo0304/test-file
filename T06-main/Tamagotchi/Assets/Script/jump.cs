using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class jump : MonoBehaviour
{
    Rigidbody2D rb;
    public string scene;
    public float power;
    public string pipe;
    public string ground;
    bool jump2 = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(jump2 != true)
            {
                rb.AddForce(new Vector2(0,power), ForceMode2D.Impulse);
                jump2 = true;
            }
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collider2D) {
        if(collider2D.gameObject.name == ground)
       {
           jump2 = false;
       }
       
    }
   private void OnCollisionEnter2D(Collision2D other) {
       if(other.gameObject.name == pipe)
       {
           SceneManager.LoadScene(scene);
           point.points += addscore.score;
           addscore.score = 0;
       }
      
   }
}
