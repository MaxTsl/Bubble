using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creation : MonoBehaviour {

    public GameObject boubleSfere;

    public float Interval = 0;
    private float elapsed = 0;
    // Use this for initialization
    void Start () {
        
        //Через сколько будет создан бервый пузырь
        Interval = Random.Range(0f, 5f);
    }
	
	// Update is called once per frame
	void Update () {

        elapsed += Time.deltaTime;

        if (elapsed > Interval)
        {
            //параметры для создания по времени
            Interval = Random.Range(0f, 4f);
            elapsed = 0;

            //-9 - 9 ширина экрана. 5 - половина высоты для камеры по умолчанию
            GameObject newSfere = Instantiate(boubleSfere, new Vector3(Random.Range(-9.0f, 9.0f), 5, 0), Quaternion.identity);

            Destroy(newSfere, 10f);
        }
    }
}
