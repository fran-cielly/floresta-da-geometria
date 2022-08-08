using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cena1 : MonoBehaviour
{
    int frase = 0;

    string[] cenaInicialDialogo= new string[4] {"Olá, quem está ai?",
    "Oi, me perdi e preciso atravessar a floresta para chegar ao Reino dos cogumelos",
    "Sou Hipátia, sou a guardiã do portão e junto com as outras flores protegemos a entrada da floresta, se você quer entrar precisa passar pelo meu desafio de geometria. Você consegue?",
    "Eu não, mas os meus amigos conseguem!"
    };
    string[] cenaInicialDialogoJogador = new string[4] {"proximo", "proximo","proximo","Sim, eu vou ajudar"};

    public void dialogoCena1(){
       
        if(frase < 2){

            Text dialogo = GameObject.Find("Canvas/caixaDialogoCena1").GetComponent<Text>();
            dialogo.text = cenaInicialDialogo[frase];

            Text dialogoJogador = GameObject.Find("Canvas/BotaoDialogo/TextoBotaoDialogoCena1").GetComponent<Text>();
            dialogoJogador.text = cenaInicialDialogoJogador[frase];

        }else{
            
        }

        frase++;
    }
   
}
