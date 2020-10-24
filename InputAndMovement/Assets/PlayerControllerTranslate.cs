using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTranslate : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(x, y, 0) * speed * Time.deltaTime;
        
        transform.Translate(movement);
    }
}
