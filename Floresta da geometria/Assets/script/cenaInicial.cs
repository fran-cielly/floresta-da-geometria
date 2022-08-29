using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cenaInicial : MonoBehaviour
{
    int frase = 0;
    int quantFrases = 2;

    string[] cenaInicialDialogo = new string[2] {" Fico feliz com a sua ajuda! Precisamos conseguir a ajuda dos moradores da floresta para conseguir atravessar superando os desafios.",
    "Eles vão desafiar nosso conhecimento sobre as formas geométricas, para ser sincero eu não sou muito bom em geometria por isso preciso da sua ajuda. Vamos lá!",
    };
    string[] cenaInicialDialogoJogador = new string[2] {"Como são os desafios?","Seguir ele"};

    public void dialogoCenaInicial(){
       
        if(frase < 2){

            Text dialogo = GameObject.Find("Canvas/caixaDialogo").GetComponent<Text>();
            dialogo.text = cenaInicialDialogo[frase];

            Text dialogoJogador = GameObject.Find("Canvas/BotaoDialogo/TextoBotaoDialogo").GetComponent<Text>();
            dialogoJogador.text = cenaInicialDialogoJogador[frase];

        }else{
            SceneManager.LoadScene("Cena1");
        }

        frase++;
    }
}
