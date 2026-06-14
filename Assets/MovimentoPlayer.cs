using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    // Variáveis de controle
    public float velocidade = 5f;
    public float forcaDoPulo = 7f;

    [Header("Sons do Player")]
    public AudioClip somDoPulo; // A fita cassete com o som
    private AudioSource altoFalante; // O aparelho de som

    // Componentes
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator anim;

    // Variáveis de estado
    private float movimentoX;
    private bool noChao;
    private int pulosExtras;
    public int limitePulosExtras = 1;

    // Controle de animação
    private string animacaoAtual;

    void Start()
    {
        // Conectando o cérebro aos componentes do boneco
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>(); 
        
        // Conecta o aparelho de som que instalamos no sapo!
        altoFalante = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Lê as setas do teclado ou WASD
        movimentoX = Input.GetAxisRaw("Horizontal");

        // 1. Vira o rosto do personagem
        if (movimentoX > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (movimentoX < 0)
        {
            spriteRenderer.flipX = true;
        }

        // 2. Sistema de Pulos
        if (Input.GetButtonDown("Jump"))
        {
            if (noChao) 
            {
                // Pulo normal do chão
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaDoPulo);
                noChao = false;
                TocarSomPulo(); // Chama o som!
            }
            else if (pulosExtras > 0)
            {
                // Pulo Duplo no ar
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaDoPulo);
                pulosExtras--;
                MudarAnimacao("Player_DoubleJump"); 
                TocarSomPulo(); // Chama o som no pulo duplo também!
            }
        }

        // 3. Sistema de Animações
        if (noChao)
        {
            if (movimentoX != 0)
            {
                MudarAnimacao("Player_Run"); 
            }
            else
            {
                MudarAnimacao("Player_idle"); 
            }
        }
        else
        {
            if (rb.linearVelocity.y > 0.1f && pulosExtras == limitePulosExtras) 
            {
                MudarAnimacao("Player_Jump");
            }
            else if (rb.linearVelocity.y < -0.1f)
            {
                MudarAnimacao("Player_Fall");
            }
        }
    }

    void FixedUpdate()
    {
   
        rb.linearVelocity = new Vector2(movimentoX * velocidade, rb.linearVelocity.y);
    }

    
    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Chao"))
        {
            noChao = true;
            pulosExtras = limitePulosExtras;
        }
    }

    // Quando SAI do chão (Ex: cai de um degrau sem apertar pulo)
    private void OnCollisionExit2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Chao"))
        {
            noChao = false;
        }
    }

  
    void MudarAnimacao(string novaAnimacao)
    {
        if (animacaoAtual == novaAnimacao) return;

        anim.Play(novaAnimacao);
        animacaoAtual = novaAnimacao;
    }

    // Função nova que criamos só para organizar o som do pulo
    void TocarSomPulo()
    {
        if (altoFalante != null && somDoPulo != null)
        {
            altoFalante.PlayOneShot(somDoPulo);
        }
    }
}