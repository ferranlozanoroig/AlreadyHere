using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJoystick : MonoBehaviour
{

    public Joystick joystick;
    public int velocidad;
    public Rigidbody2D rb;
    public bool fisicas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        Vector2 direction = Vector2.up * joystick.Vertical + Vector2.right * joystick.Horizontal;

        if (fisicas)
        {
            rb.AddForce(direction * velocidad * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }else
        {
            gameObject.transform.Translate(direction * velocidad * Time.deltaTime);
        }
    }
}
