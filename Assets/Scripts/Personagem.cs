using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public KeyCode pular; //fiz esse tipo de variável para o game designer poder editar diretamente na unity qual botão ele quer que pule, e assim com os demais botões
    public KeyCode esquerda;
    public KeyCode direita;
    public int velocidade;
    private Rigidbody2D rigidbody2D;
    private Animator animator;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public void Mover()
    {
        if(Input.GetKey(direita))
        {
            rigidbody2D.velocity = new Vector2(velocidade, 0) * Time.deltaTime;
            animator.SetBool("andando", true);
            animator.SetBool("andando", true);
            animator.SetBool("andando", true);
            animator.SetBool("andando", true);
            animator.SetBool("andando", true);
        }

        else if(Input.GetKey(esquerda))
        {
            rigidbody2D.velocity = new Vector2(-velocidade, 0) * Time.deltaTime;
        }

        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }
    }

    void FixedUpdate()
    {
        Mover();
    }
}
