using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    [SerializeField]
    private float variacaoposicaoY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoposicaoY,variacaoposicaoY));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }
    private void Destruir()
    {
        Destroy(this.gameObject);
    }
}
