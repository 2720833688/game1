using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNER : MonoBehaviour
{
    public GameObject TaoPrefab;
    public Transform spawnPoint;
    public float objectSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(TaoPrefab, mousePos, Quaternion.identity,spawnPoint);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(TaoPrefab, mousePos, Quaternion.identity);
        }
    }
}
