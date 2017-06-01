using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerControl : MonoBehaviour
{
    public Transform bullet;
    public float speed;
    private float fireRate = 20f;
    private float cooldown;

    void Start() {
        cooldown = 0f;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed);
        }
        if (Input.GetMouseButton(0)&&cooldown<=0) {
            Transform t=Instantiate(bullet,this.gameObject.transform.position, Quaternion.Euler(0, 0, 0));
            Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            float angle = Mathf.Atan2(-dir.x, dir.y) * Mathf.Rad2Deg;
            t.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            gameObject.GetComponent<AudioSource>().Play();
            cooldown = fireRate;
        }
        cooldown--;
    }
   



}
