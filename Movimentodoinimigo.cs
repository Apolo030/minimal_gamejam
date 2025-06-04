using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform[] pontodocaminho;

    [SerializeField] private float velocidadedoMovimento;

    private int pontoAtual;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame


    void Update()
    {

    }
    private void movimentarInimigo()
    {
        transform.position = Vector2.MoveTowards(transform.position, pontodocaminho[pontoAtual].position, velocidadedoMovimento * time. )
         deltatime);
     }


    
}

