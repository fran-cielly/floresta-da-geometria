using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cenaPerguntas1 : MonoBehaviour
{
    int soma = 0;
    int nPergunta = 0;
    void Start()
    {
       carregarPergunta();
    }
    public void carregarPergunta(){
        if(nPergunta == 3){
            Dados.pontuacao = soma;
            SceneManager.LoadScene("CenaResultado1");
        }
        int n = Random.Range(0,2);
        string[] perguntas = new string[3]{"Quantas faces tem essa forma?","Quantas arestas tem essa forma?","Quantos vértices tem essa forma?"};

        string[,] respostas = new string[,] { {"6","1","3","5","0"}, {"3","0","12","8","2"}, {"0","8","5","2","1"}};
        
        Text caixaPergunta = GameObject.Find("Canvas/TextoPergunta").GetComponent<Text>();

        string perguntaEscolhida = perguntas[n];
        caixaPergunta.text = perguntaEscolhida;

        Text botao1 = GameObject.Find("Canvas/botao1/botao1texto").GetComponent<Text>();
        Text botao2 = GameObject.Find("Canvas/botao2/botao2texto").GetComponent<Text>();
        Text botao3 = GameObject.Find("Canvas/botao3/botao3texto").GetComponent<Text>();
        Text botao4 = GameObject.Find("Canvas/botao4/botao4texto").GetComponent<Text>();

        botao1.text = respostas[n, 0];
        botao2.text = respostas[n, 1];
        botao3.text = respostas[n, 2];
        botao4.text = respostas[n, 3];

        string respostaCerta = respostas[n, 4];

        Text caixaResposta = GameObject.Find("Canvas/Resposta").GetComponent<Text>();
        caixaResposta.text = respostaCerta;

        nPergunta++;
    }
    public void resposta0(){
        Text caixaResposta = GameObject.Find("Canvas/Resposta").GetComponent<Text>();
        string respostaCerta = caixaResposta.text;

        Text caixaPergunta = GameObject.Find("Canvas/TextoPergunta").GetComponent<Text>();

        if(respostaCerta.Equals("0")){
            caixaPergunta.text = "acertou";
            soma++;
        }else{
            caixaPergunta.text = "errou";
        }
        carregarPergunta();
    }
    public void resposta1(){
        Text caixaResposta = GameObject.Find("Canvas/Resposta").GetComponent<Text>();
        string respostaCerta = caixaResposta.text;

        Text caixaPergunta = GameObject.Find("Canvas/TextoPergunta").GetComponent<Text>();

        if(respostaCerta.Equals("1")){
            caixaPergunta.text = "acertou";
            soma++;
        }else{
            caixaPergunta.text = "errou";
        }
        carregarPergunta();
    }
     public void resposta2(){
        Text caixaResposta = GameObject.Find("Canvas/Resposta").GetComponent<Text>();
        string respostaCerta = caixaResposta.text;

        Text caixaPergunta = GameObject.Find("Canvas/TextoPergunta").GetComponent<Text>();

        if(respostaCerta.Equals("2")){
            caixaPergunta.text = "acertou";
            soma++;
        }else{
            caixaPergunta.text = "errou";
        }
        carregarPergunta();
    }
     public void resposta3(){
        Text caixaResposta = GameObject.Find("Canvas/Resposta").GetComponent<Text>();
        string respostaCerta = caixaResposta.text;

        Text caixaPergunta = GameObject.Find("Canvas/TextoPergunta").GetComponent<Text>();

        if(respostaCerta.Equals("3")){
            caixaPergunta.text = "acertou";
            soma++;
        }else{
            caixaPergunta.text = "errou";
        }
        carregarPergunta();
    }
}
