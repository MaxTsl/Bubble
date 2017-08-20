using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buble : MonoBehaviour {

    float rotation; //
    int sign; //знак для поворота по или против часовой стрелки

    // Use this for initialization
    void Start () {
        rotation = Random.Range(0.1f, 0.5f);

        float rand = Random.Range(1f, 9f);
        sign = rand >= 5 ? -1 : 1;

        //пытаемся разнообразить шарики
        float skale = Random.Range(0.2f, 1.2f);
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        rb.gravityScale = 1;
        rb.AddForce(new Vector2(0, Random.Range(1.0f, 7.0f)));

        gameObject.transform.localScale = new Vector3(skale, skale, 0);
        gameObject.transform.Rotate(new Vector3(skale, skale, 0));
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, sign * rotation));
    }
}
