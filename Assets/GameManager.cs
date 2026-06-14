using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour 
{
    public TMP_Text fruitText;
    
    private int frutasColetadas = 0; // Quantos o sapo já pegou
    private int totalNaFase = 0;     // Quantos existem no total da fase atual

    void Start()
    {
        // O Radar: Conta todos os objetos que têm a tag "Abacaxi" na cena atual
        totalNaFase = GameObject.FindGameObjectsWithTag("Abacaxi").Length;
        
        // Já arruma o texto logo no segundo zero da fase! (Ex: Abacaxi 0/12)
        AtualizarTexto();
    }

    public void AddFruit()
    {
        // Adiciona 1 na conta de coletados
        frutasColetadas++;
        
        // Atualiza o texto na tela
        AtualizarTexto();
    }

    // Criamos essa função separada só para deixar o texto sempre certinho
    void AtualizarTexto()
    {
        // Agora ele junta as variáveis de forma inteligente, sem números fixos!
        fruitText.text = "Abacaxi: " + frutasColetadas + "/" + totalNaFase;
    }
}