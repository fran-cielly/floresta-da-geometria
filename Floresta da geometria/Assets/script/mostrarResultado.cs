using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mostrarResultado : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text caixa = GameObject.Find("Canvas/Resultado").GetComponent<Text>();
        int pontuacao = Dados.pontuacao;

        if(pontuacao>=3){
            string t1 = "Você acertou "+(pontuacao)+" pergunta(s). Conseguiu entrar na floresta";
            caixa.text = t1;
        }else{
            string t2 = "Você acertou "+(pontuacao)+" pergunta(s). Não foi o suficiente mas vou te dar outra chance";
            caixa.text = t2;
        }
    }

    public void continuar(){

    }
    public void refazer(){
        SceneManager.LoadScene("CenaPerguntas1");
    }
}
